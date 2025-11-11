using System;
using Microsoft.Data.SqlClient;
using Alvao.Apps.API;
using System.Linq;

public class ApproveByGroupMember : ITicketAutoAction
{
    public string Name
    {
        get => "ApproveByGroupMember";
        set { }
    }

    public void OnTicketChanged(SqlConnection con, SqlTransaction trans, int ticketId, int personId, string properties)
    {
        if (properties.Contains("TicketStateId"))
        {
            try
            {
                int stateId = Alvao.API.SD.TicketState.GetCurrentStateByTicketId(ticketId).id;
                bool isAdHocApproval = Alvao.API.SD.TicketState.IsAdHocApproval(stateId);

                if (isAdHocApproval)
                {
                    string approvalGroup = Alvao.API.Common.Database.ReadColumn(stateId, "TicketStateCust", "ApprovalGroupName");

                    if (!string.IsNullOrEmpty(approvalGroup))
                    {
                        var group = Alvao.API.Common.Role.GetByName(approvalGroup);
                        if (group == null)
                        {
                            throw new Exception("Unable to find the specified group.");
                        }

                        var ticket = Alvao.API.SD.Ticket.GetById(ticketId);
                        string requesterOrgName = ticket.sHdTicketUserCompany;
                        var requesterOrg = Alvao.API.SD.Organization.GetByName(requesterOrgName);
                        int? requesterOrgId = requesterOrg == null ? (int?)null : requesterOrg.iAccountId;
                        string requesterOffice = ticket.sHdTicketUserOffice;

                        var groupMembers = Alvao.API.Common.Role.GetMembers(group.iRoleId);
                        var approver = groupMembers.Where(x => x.liAccountId == requesterOrgId && x.sPersonOffice == requesterOffice);

                        var systemPerson = Alvao.API.Common.Person.GetSystem();
                        var messageForApprover = new Alvao.API.Common.Model.HtmlTextModel("Please approve this request.");

                        if (approver.Any())
                        {
                            Alvao.API.SD.Approval.EnterByPerson(ticketId, approver.First().iPersonId, 0.0, systemPerson.iPersonId, messageForApprover);
                        }
                    }
                }

            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }              
        }
    }

    public void OnTicketCreated(SqlConnection con, SqlTransaction trans, int ticketId, int personId)
    {
        throw new System.NotImplementedException();
    }
}

