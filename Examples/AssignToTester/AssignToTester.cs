using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Alvao.Apps.API;
using Alvao.API.SD;
using Alvao.API.Common.Model;
using Dapper;

namespace Alvao.Helpdesk
{
    class AssignToTester : ITicketAutoAction
    {
        public string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public AssignToTester()
        {
            name = Settings.ActionName;
        }

        public void OnTicketCreated(SqlConnection con, SqlTransaction trans, int ticketId, int personId)
        {
            throw new NotImplementedException();
        }

        public void OnTicketChanged(SqlConnection con, SqlTransaction trans, int ticketId, int personId, string properties)
        {
            if (properties.Contains("tHdTicketCust.solvedInVersion"))
            {
                // Get values.
                string solvedInVersion = API.Common.Database.ReadColumn(ticketId, "tHdTicketCust", "solvedInVersion");
                string section = API.Common.Database.ReadColumn(ticketId, "TicketForeignKeyInfo", "SectionName");
                int stateId = int.Parse(API.Common.Database.ReadColumn(ticketId, "tHdTicket", "TicketStateId"));

                // Values check.
                if (!String.IsNullOrEmpty(solvedInVersion) && section == Settings.ServiceName && stateId == Settings.ControlStateId)
                {
                    // Get solver.
                    int? newSolverId = con.QueryFirstOrDefault<int?>($@"SELECT TOP 1 TRP.liRolePersonPersonId newSolverId
                        FROM tRolePerson TRP JOIN tRole TR ON TRP.liRolePersonRoleId=TR.iRoleId WHERE TR.sRole = N'{Settings.SolverGroupName}'", transaction: trans);

                    // Assign to solver.
                    if (newSolverId.HasValue)
                        Ticket.ChangeSolverOrGroup(ticketId, newSolverId, null, new HtmlTextModel(string.Empty));                    
                }
            }
        }
    }
}
