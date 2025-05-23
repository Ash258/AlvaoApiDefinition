namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Model_ApprovalSchemaStepModel.htm"/>
public class ApprovalSchemaStepModel {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ApprovalSchemaStepModel_AuthorityManagerOfUser.htm"/>
    public bool AuthorityManagerOfUser { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ApprovalSchemaStepModel_AuthorityRequester.htm"/>
    public bool AuthorityRequester { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ApprovalSchemaStepModel_AuthorityRootManagerOfUser.htm"/>
    public bool AuthorityRootManagerOfUser { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ApprovalSchemaStepModel_AutoApproveByRequester.htm"/>
    public bool AutoApproveByRequester { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ApprovalSchemaStepModel_AutoApproveStepsSameApprover.htm"/>
    public bool AutoApproveStepsSameApprover { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ApprovalSchemaStepModel_ExpirationHours.htm"/>
    public double ExpirationHours { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_ApprovalSchemaStepModel_TicketApprovalId.htm"/>
    public int TicketApprovalId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_ApprovalSchemaStepModel__ctor.htm"/>
    public ApprovalSchemaStepModel() { }
}
