using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cache of the localizations of ticket states.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketStateLoc.html"/>
[Table("dbo.TicketStateLoc")]
public class TicketStateLoc {
    /// <summary>Localized customer message template for approvers. If the record has a value of NULL, then the default template is used (available in tString).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketStateLoc.html#Alvao_API_Common_Model_Database_TicketStateLoc_CustomMessageForApproverTemplate"/>
    public virtual string CustomMessageForApproverTemplate { get; set; }
    /// <summary>Localized custom template of notifications to requester about the change of ticket status. If the record has a value of NULL, then the default template is used (saved in tString).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketStateLoc.html#Alvao_API_Common_Model_Database_TicketStateLoc_CustomNotificationForRequesterTemplate"/>
    public virtual string CustomNotificationForRequesterTemplate { get; set; }
    /// <summary>Localized ticket status description.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketStateLoc.html#Alvao_API_Common_Model_Database_TicketStateLoc_Description"/>
    public virtual string Description { get; set; }
    /// <summary>Language ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketStateLoc.html#Alvao_API_Common_Model_Database_TicketStateLoc_LocaleId"/>
    public virtual int LocaleId { get; set; }
    /// <summary>Localized instructions for solver.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketStateLoc.html#Alvao_API_Common_Model_Database_TicketStateLoc_SolverInstructions"/>
    public virtual string SolverInstructions { get; set; }
    /// <summary>Localized ticket status name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketStateLoc.html#Alvao_API_Common_Model_Database_TicketStateLoc_TicketState"/>
    public virtual string TicketState { get; set; }
    /// <summary>Ticket status ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketStateLoc.html#Alvao_API_Common_Model_Database_TicketStateLoc_TicketStateId"/>
    [ExplicitKey]
    public virtual int TicketStateId { get; set; }
}
