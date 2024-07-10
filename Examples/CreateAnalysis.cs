
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Alvao.Apps.API;
using Alvao.API.SD;
using Alvao.API.SD.Model;
using Alvao.API.Common;
using Dapper;

namespace Alvao.Helpdesk
{
    class CreateAnalysis : ITicketAutoAction
    {
        public string name;

        public string Name
        {
            get { return name; }
            set { }
        }

        public CreateAnalysis()
        {
            name = Settings.CA_ActionName;
        }

        public void OnTicketChanged(SqlConnection con, SqlTransaction trans, int ticketId, int personId, string properties)
        {
            throw new NotImplementedException();
        }

        public void OnTicketCreated(SqlConnection con, SqlTransaction trans, int ticketId, int personId)
        {
            // Get values.
            bool createAnalysis;
            try
            {
                createAnalysis = con.QueryFirstOrDefault<bool>(@"SELECT createAnalysis from tHdTicketCust where liHdTicketId = @ticketId",
                    new { ticketId }, trans);
            }
            catch (SqlException)
            {
                return;
            }

            int? analysisServiceId = con.QueryFirstOrDefault<int?>(@"SELECT iHdSectionId from tHdSection where sHdSection = @sectionName",
                new { sectionName = Settings.CA_AnalysisServiceName }, trans);

            string section = API.Common.Database.ReadColumn(ticketId, "TicketForeignKeyInfo", "SectionName");
            string name = API.Common.Database.ReadColumn(ticketId, "tHdTicket", "sHdTicket");

            // Check values.
            if (section == Settings.CA_ServiceName && createAnalysis)
            {
                // Create a new request for analysis.

                var newTicketModel = new NewTicketModel();
                newTicketModel.Ticket.sHdTicket = name + " - analysis";
                newTicketModel.Ticket.liHdTicketUserPersonId = personId;
                newTicketModel.LoadRequesterData = true;
                newTicketModel.Ticket.liHdTicketHdSectionId = analysisServiceId.Value;
                var ticket = Ticket.Create(newTicketModel);
                int newTicketId = ticket.iHdTicketId;

                // Creat a link.
                Relation.Create(ticketId, newTicketId, 2, Person.GetSystem().iPersonId);
            }
        }
    }
}
