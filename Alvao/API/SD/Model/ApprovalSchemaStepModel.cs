namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ApprovalSchemaStepModel.html"/>
public class ApprovalSchemaStepModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ApprovalSchemaStepModel.html#Alvao_API_SD_Model_ApprovalSchemaStepModel_AuthorityManagerOfUser"/>
    public bool AuthorityManagerOfUser { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ApprovalSchemaStepModel.html#Alvao_API_SD_Model_ApprovalSchemaStepModel_AuthorityRequester"/>
    public bool AuthorityRequester { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ApprovalSchemaStepModel.html#Alvao_API_SD_Model_ApprovalSchemaStepModel_AuthorityRootManagerOfUser"/>
    public bool AuthorityRootManagerOfUser { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ApprovalSchemaStepModel.html#Alvao_API_SD_Model_ApprovalSchemaStepModel_AutoApproveByRequester"/>
    public bool AutoApproveByRequester { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ApprovalSchemaStepModel.html#Alvao_API_SD_Model_ApprovalSchemaStepModel_AutoApproveStepsSameApprover"/>
    public bool AutoApproveStepsSameApprover { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ApprovalSchemaStepModel.html#Alvao_API_SD_Model_ApprovalSchemaStepModel_ExpirationHours"/>
    public double ExpirationHours { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.ApprovalSchemaStepModel.html#Alvao_API_SD_Model_ApprovalSchemaStepModel_TicketApprovalId"/>
    public int TicketApprovalId { get; set; }
}
