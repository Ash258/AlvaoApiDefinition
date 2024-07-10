using System;
using Microsoft.Data.SqlClient;
using Alvao.Apps.API;
using System.Collections.Generic;
using Dapper;

namespace Alvao.Helpdesk
{
    class AutoCloseInactiveTickets : IPeriodicAction
    {
        public string Name { get; set; }

        public AutoCloseInactiveTickets()
        {
            Name = "Automatic closure of resolved requests after the set deadline for reopening by the applicant";
        }

        public void OnPeriod(SqlConnection con)
        {
            string sql = @"
            select
                t.iHdTicketId id
            from tHdTicket t
                left join tHdSection s on s.iHdSectionId=t.liHdTicketHdSectionId
                join TicketState ts on ts.TicketStateBehaviorId=3 AND ts.TicketTypeId=s.TicketTypeId
            where t.dHdTicketResolved is not null
                and t.dHdTicketRemoved is null
                and ClosedDate is null
                and dateadd(day, isnull(s.nHdSectionUserReopenDays, 0), t.dHdTicketResolved)<getutcdate()";

            var ids = con.Query<int>(sql);

            var systemPerson = API.Common.Person.GetSystem();

            foreach (int id in ids)
            {
                API.SD.Ticket.Close(id, systemPerson.iPersonId, API.SD.Ticket.CloseFlags.IgnoreRights);
            }
        }
    }
}
