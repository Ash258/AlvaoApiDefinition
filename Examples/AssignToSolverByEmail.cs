
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using Alvao.Apps.API;
using Alvao.API;
using Dapper;
using Rebex.Mail;

namespace Alvao.Helpdesk
{
    public class AssignToSolverByEmail : IMailMessageAutoAction
    {
        public string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public AssignToSolverByEmail()
        {
            name = Settings.ATSBE_ActionName;
        }

        public bool OnMessageReceived(SqlConnection con, SqlTransaction trans, MailMessage message, int sectionId, int ticketId, int fromPersonId)
        {
            if (ticketId == 0) return true;
            if (message.BodyText == null) return true;

            int startIndex = message.BodyText.IndexOf("ASSIGNTO:");
            if (startIndex < 0) return true;

            int length = message.BodyText.IndexOf("\n", startIndex) - (startIndex + 9);
            string user = message.BodyText.Substring(startIndex + 9, length).Trim();
            int? solverId = null;
            var users = con.Query<FoundPerson>(@"exec spPersonSearch @sample, NULL, 0, NULL, '', 1", new { sample = user }, trans);
            if (users.Any())
            {
                solverId = users.First().PersonId;
            }

            if (solverId.HasValue)
            {
                Alvao.API.SD.Ticket.ChangeSolverOrGroup(ticketId, solverId, null, new API.Common.Model.HtmlTextModel(string.Empty), null, fromPersonId);
                return false;
            }

            return true;
        }

        class FoundPerson
        {
            public int? PersonId { get; set; }
        }
    }
}
