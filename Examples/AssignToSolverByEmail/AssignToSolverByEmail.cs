using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Alvao.Apps.API;
using Alvao.API;
using Alvao.Context;
using Dapper;

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
            name = Settings.ActionName;
        }

        public async Task<bool> OnMessageReceivedAsync(MailMessageEventArgs e, CancellationToken cancellationToken)
        {
            if (e.TicketId == 0)
                return true;

            if (e.Message?.BodyText != null)
            {
                int startIndex = e.Message.BodyText.IndexOf("ASSIGNTO:");
                if (startIndex >= 0)
                {
                    int length = e.Message.BodyText.IndexOf("\n", startIndex) - (startIndex + 9);
                    string user = e.Message.BodyText.Substring(startIndex + 9, length).Trim();
                    int? solverId = null;

                    using var scope = AlvaoContext.GetConnectionScope();
                    var users = scope.Connection.Query<FoundPerson>(@"exec spPersonSearch @sample, NULL, 0, NULL, '', 1", new { sample = user }, scope.LegacyTransaction);
                    if (users.Any())
                    {
                        solverId = users.First().PersonId;
                    }

                    if (solverId.HasValue)
                    {
                        Alvao.API.SD.Ticket.ChangeSolverOrGroup(e.TicketId, solverId, null, new API.Common.Model.HtmlTextModel(string.Empty), null, e.FromPersonId);
                        return false;
                    }
                }
            }
            return true;
        }

        class FoundPerson
        {
            public int? PersonId { get; set; }
        }
    }
}
