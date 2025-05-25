using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Ticket approval process instance - main record.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApproval.html"/>
[Table("dbo.tHdTicketApproval")]
public class tHdTicketApproval {
    /// <summary>ID of the person who canceled approving.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApproval.html#Alvao_API_Common_Model_Database_tHdTicketApproval_CanceledPersonId"/>
    public virtual int? CanceledPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApproval.html#Alvao_API_Common_Model_Database_tHdTicketApproval_TicketStateId"/>
    public virtual int? TicketStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApproval.html#Alvao_API_Common_Model_Database_tHdTicketApproval_dHdTicketApprovalStarted"/>
    public virtual DateTime? dHdTicketApprovalStarted { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApproval.html#Alvao_API_Common_Model_Database_tHdTicketApproval_iHdTicketApprovalId"/>
    [Key]
    public virtual int iHdTicketApprovalId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApproval.html#Alvao_API_Common_Model_Database_tHdTicketApproval_liHdTicketApprovalApprovalSchemaId"/>
    public virtual int? liHdTicketApprovalApprovalSchemaId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApproval.html#Alvao_API_Common_Model_Database_tHdTicketApproval_liHdTicketApprovalHdTicketId"/>
    public virtual int liHdTicketApprovalHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketApproval.html#Alvao_API_Common_Model_Database_tHdTicketApproval_liHdTicketApprovalStartedPersonId"/>
    public virtual int? liHdTicketApprovalStartedPersonId { get; set; }
}
