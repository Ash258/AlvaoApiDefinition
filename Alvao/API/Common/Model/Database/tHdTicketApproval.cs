using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Ticket approval process instance - main record.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tHdTicketApproval.htm"/>
[TableAttribute("dbo.tHdTicketApproval")]
public class tHdTicketApproval {
    /// <summary>ID of the person who canceled approving.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdTicketApproval_CanceledPersonId.htm"/>
    public virtual int? CanceledPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdTicketApproval_dHdTicketApprovalStarted.htm"/>
    public virtual DateTime? dHdTicketApprovalStarted { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdTicketApproval_iHdTicketApprovalId.htm"/>
    [KeyAttribute]
    public virtual int iHdTicketApprovalId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdTicketApproval_liHdTicketApprovalApprovalSchemaId.htm"/>
    public virtual int? liHdTicketApprovalApprovalSchemaId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdTicketApproval_liHdTicketApprovalHdTicketId.htm"/>
    public virtual int liHdTicketApprovalHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdTicketApproval_liHdTicketApprovalStartedPersonId.htm"/>
    public virtual int? liHdTicketApprovalStartedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdTicketApproval_TicketStateId.htm"/>
    public virtual int? TicketStateId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tHdTicketApproval__ctor.htm"/>
    public tHdTicketApproval() { }
}
