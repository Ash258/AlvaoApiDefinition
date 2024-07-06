using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Ticket approval process instance - main record.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tHdTicketApproval.htm"/>
[TableAttribute("dbo.tHdTicketApproval")]
public class tHdTicketApproval
{
    /// <summary>ID of the person who canceled approving.</summary>
    public virtual int? CanceledPersonId { get; set; }
    public virtual DateTime? dHdTicketApprovalStarted { get; set; }
    [KeyAttribute]
    public virtual int iHdTicketApprovalId { get; set; }
    public virtual int? liHdTicketApprovalApprovalSchemaId { get; set; }
    public virtual int liHdTicketApprovalHdTicketId { get; set; }
    public virtual int? liHdTicketApprovalStartedPersonId { get; set; }
    public virtual int? TicketStateId { get; set; }

    public tHdTicketApproval() { }
}
