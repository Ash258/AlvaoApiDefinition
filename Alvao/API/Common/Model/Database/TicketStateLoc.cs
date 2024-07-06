using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Cache of the localizations of ticket states.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketStateLoc.htm"/>
[TableAttribute("dbo.TicketStateLoc")]
public class TicketStateLoc
{
    /// <summary>Localized customer message template for approvers. If the record has a value of NULL, then the default template is used (available in tString).</summary>
    public virtual string CustomMessageForApproverTemplate { get; set; }
    /// <summary>Localized custom template of notifications to requester about the change of ticket status. If the record has a value of NULL, then the default template is used (saved in tString).</summary>
    public virtual string CustomNotificationForRequesterTemplate { get; set; }
    /// <summary>Localized ticket status description.</summary>
    public virtual string Description { get; set; }
    /// <summary>Language ID.</summary>
    public virtual int LocaleId { get; set; }
    /// <summary>Localized instructions for solver.</summary>
    public virtual string SolverInstructions { get; set; }
    /// <summary>Localized ticket status name.</summary>
    public virtual string TicketState { get; set; }
    /// <summary>Ticket status ID.</summary>
    [ExplicitKeyAttribute]
    public virtual int TicketStateId { get; set; }

    public TicketStateLoc() { }
}
