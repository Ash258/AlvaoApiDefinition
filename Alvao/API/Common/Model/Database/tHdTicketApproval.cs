using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Ticket approval process instance - main record.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApproval.html"/>
[Table("dbo.tHdTicketApproval")]
public class tHdTicketApproval {
    /// <summary>ID of the person who canceled approving.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApproval.html#Alvao_API_Common_Model_Database_tHdTicketApproval_CanceledPersonId"/>
    /// <remarks>Column <c>CanceledPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? CanceledPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApproval.html#Alvao_API_Common_Model_Database_tHdTicketApproval_TicketStateId"/>
    /// <remarks>Column <c>TicketStateId</c>: int, null. References <see cref="TicketState"/>.</remarks>
    public virtual int? TicketStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApproval.html#Alvao_API_Common_Model_Database_tHdTicketApproval_dHdTicketApprovalStarted"/>
    /// <remarks>Column <c>dHdTicketApprovalStarted</c>: datetime, null.</remarks>
    public virtual DateTime? dHdTicketApprovalStarted { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApproval.html#Alvao_API_Common_Model_Database_tHdTicketApproval_iHdTicketApprovalId"/>
    /// <remarks>Column <c>iHdTicketApprovalId</c>: int, not null.</remarks>
    [Key]
    public virtual int iHdTicketApprovalId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApproval.html#Alvao_API_Common_Model_Database_tHdTicketApproval_liHdTicketApprovalApprovalSchemaId"/>
    /// <remarks>
    /// Column <c>liHdTicketApprovalApprovalSchemaId</c>: int, null. References <see cref="tApprovalSchema"/>.
    /// </remarks>
    public virtual int? liHdTicketApprovalApprovalSchemaId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApproval.html#Alvao_API_Common_Model_Database_tHdTicketApproval_liHdTicketApprovalHdTicketId"/>
    /// <remarks>
    /// Column <c>liHdTicketApprovalHdTicketId</c>: int, not null. References <see cref="tHdTicket"/>.
    /// </remarks>
    public virtual int liHdTicketApprovalHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApproval.html#Alvao_API_Common_Model_Database_tHdTicketApproval_liHdTicketApprovalStartedPersonId"/>
    /// <remarks>Column <c>liHdTicketApprovalStartedPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? liHdTicketApprovalStartedPersonId { get; set; }
}
