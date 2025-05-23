namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Model_MessageForRequesterDataModel.htm"/>
public class MessageForRequesterDataModel : MessageDataBaseModel {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageForRequesterDataModel_ApprovalResultWithComment.htm"/>
    public string ApprovalResultWithComment { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_FirstReactionDeadline.htm"/>
    public DateTime? FirstReactionDeadline { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_Impact.htm"/>
    public int Impact { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_OriginalMessageActId.htm"/>
    public string OriginalMessageActId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_OriginalMessageAttachmentList.htm"/>
    public string OriginalMessageAttachmentList { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_OriginalMessageHtml.htm"/>
    public string OriginalMessageHtml { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_OriginalMessageSubject.htm"/>
    public string OriginalMessageSubject { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_Priority.htm"/>
    public int? Priority { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_RelatedAccountId.htm"/>
    public int? RelatedAccountId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketDeadline.htm"/>
    public DateTime? TicketDeadline { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketId.htm"/>
    public string TicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketMessageTag.htm"/>
    public string TicketMessageTag { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequestedForAccountName.htm"/>
    public string TicketRequestedForAccountName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequestedForDepartment.htm"/>
    public string TicketRequestedForDepartment { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequestedForEmail.htm"/>
    public string TicketRequestedForEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequestedForEmail2.htm"/>
    public string TicketRequestedForEmail2 { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequestedForManagerName.htm"/>
    public string TicketRequestedForManagerName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequestedForMobile.htm"/>
    public string TicketRequestedForMobile { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequestedForName.htm"/>
    public string TicketRequestedForName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequestedForOffice.htm"/>
    public string TicketRequestedForOffice { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequestedForOtherContacts.htm"/>
    public string TicketRequestedForOtherContacts { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequestedForPersonalNumber.htm"/>
    public string TicketRequestedForPersonalNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequestedForPhoneToWork.htm"/>
    public string TicketRequestedForPhoneToWork { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequestedForPhoneToWork2.htm"/>
    public string TicketRequestedForPhoneToWork2 { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequestedForPosition.htm"/>
    public string TicketRequestedForPosition { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequesterAccountName.htm"/>
    public string TicketRequesterAccountName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequesterDepartment.htm"/>
    public string TicketRequesterDepartment { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequesterEmail.htm"/>
    public string TicketRequesterEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequesterEmail2.htm"/>
    public string TicketRequesterEmail2 { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequesterManagerName.htm"/>
    public string TicketRequesterManagerName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequesterMobile.htm"/>
    public string TicketRequesterMobile { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequesterName.htm"/>
    public string TicketRequesterName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequesterOffice.htm"/>
    public string TicketRequesterOffice { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequesterOtherContacts.htm"/>
    public string TicketRequesterOtherContacts { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequesterPersonalNumber.htm"/>
    public string TicketRequesterPersonalNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequesterPhoneToWork.htm"/>
    public string TicketRequesterPhoneToWork { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequesterPhoneToWork2.htm"/>
    public string TicketRequesterPhoneToWork2 { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketRequesterPosition.htm"/>
    public string TicketRequesterPosition { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketService.htm"/>
    public string TicketService { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketServicePhone.htm"/>
    public string TicketServicePhone { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketServiceProcess.htm"/>
    public string TicketServiceProcess { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketSla.htm"/>
    public string TicketSla { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketSolverAccountName.htm"/>
    public string TicketSolverAccountName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketSolverDepartment.htm"/>
    public string TicketSolverDepartment { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketSolverEmail.htm"/>
    public string TicketSolverEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketSolverEmail2.htm"/>
    public string TicketSolverEmail2 { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketSolverManagerName.htm"/>
    public string TicketSolverManagerName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketSolverMobile.htm"/>
    public string TicketSolverMobile { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketSolverName.htm"/>
    public string TicketSolverName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketSolverOffice.htm"/>
    public string TicketSolverOffice { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketSolverOtherContacts.htm"/>
    public string TicketSolverOtherContacts { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketSolverPersonalNumber.htm"/>
    public string TicketSolverPersonalNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketSolverPhoneToWork.htm"/>
    public string TicketSolverPhoneToWork { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketSolverPhoneToWork2.htm"/>
    public string TicketSolverPhoneToWork2 { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketSolverPosition.htm"/>
    public string TicketSolverPosition { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketStatus.htm"/>
    public string TicketStatus { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_TicketTitle.htm"/>
    public string TicketTitle { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_MessageDataBaseModel_Urgency.htm"/>
    public int Urgency { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_MessageForRequesterDataModel__ctor.htm"/>
    public MessageForRequesterDataModel() { }
}
