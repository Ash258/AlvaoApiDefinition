using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Alvao.Apps.API;
using Dapper;
using System.Collections.Generic;
using Alvao.Context;
using System.Linq;

public class UpdateSuperiorGroupPeriodic : IPeriodicAction
{
    public string Name
    {
        get => "UpdateSuperiorGroupPeriodic";
        set { }
    }

    public void OnPeriod(SqlConnection con)
    {
        if (Settings.UPDATE_HOUR != DateTime.Now.Hour) return;

        var org = Alvao.API.SD.Organization.GetByName(Settings.ORGANIZATION_NAME);

        if (org == null)
        {
            throw new Exception("Unable to find the specified organization.");
        }

        var group = Alvao.API.Common.Role.GetByName(Settings.SUPERIOR_GROUP_NAME);

        if (group == null)
        {
            throw new Exception("Unable to find the specified group.");
        }

        var groupMembers = Alvao.API.Common.Role.GetDirectMemberUsers(group.iRoleId);

        using (var scope = AlvaoContext.GetConnectionScope())
        {
            try
            {
                var managersIds = scope.Connection.Query<int>(@"
                    select distinct ManagerPersonId from PersonManager pm
                        join tPerson p on p.iPersonId = pm.EmployeePersonId
                    where p.liAccountId = @organizationId and p.bHidden = 0 and p.dPersonRemoved is null", new { organizationId = org.iAccountId }, scope.LegacyTransaction).ToList();

                var idsToAdd = managersIds.Where(x => groupMembers.All(y => y.iPersonId != x)).ToList();
                var idsToRemove = groupMembers.Select(x => x.iPersonId).Where(x => managersIds.All(y => x != y)).ToList();

                foreach (int id in idsToAdd)
                {
                    Alvao.API.Common.Person.AddToGroup(id, new List<int>() { group.iRoleId });
                }

                foreach (int id in idsToRemove)
                {
                    Alvao.API.Common.Person.RemoveFromGroup(id, group.iRoleId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

