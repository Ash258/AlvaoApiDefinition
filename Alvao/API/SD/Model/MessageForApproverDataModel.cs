namespace Alvao.API.SD.Model;

public class MessageForApproverDataModel : MessageDataBaseModel
{
    public string CurrentApprovers { get; set; }
    public DateTime? ExpirationTime { get; set; }
    public DateTime? FirstReactionDeadline { get; set; }
    public int Impact { get; set; }
    public string MessageForRequesterActId { get; set; }
    public string MessageForRequesterHtml { get; set; }
    public string OriginalMessageActId { get; set; }
    public string OriginalMessageAttachmentList { get; set; }
    public string OriginalMessageHtml { get; set; }
    public string OriginalMessageSubject { get; set; }
    public int? Priority { get; set; }
    public int? RelatedAccountId { get; set; }
    public DateTime? TicketDeadline { get; set; }
    public string TicketId { get; set; }
    public string TicketMessageTag { get; set; }
    public string TicketRequestedForAccountName { get; set; }
    public string TicketRequestedForDepartment { get; set; }
    public string TicketRequestedForEmail { get; set; }
    public string TicketRequestedForEmail2 { get; set; }
    public string TicketRequestedForManagerName { get; set; }
    public string TicketRequestedForMobile { get; set; }
    public string TicketRequestedForName { get; set; }
    public string TicketRequestedForOffice { get; set; }
    public string TicketRequestedForOtherContacts { get; set; }
    public string TicketRequestedForPersonalNumber { get; set; }
    public string TicketRequestedForPhoneToWork { get; set; }
    public string TicketRequestedForPhoneToWork2 { get; set; }
    public string TicketRequestedForPosition { get; set; }
    public string TicketRequesterAccountName { get; set; }
    public string TicketRequesterDepartment { get; set; }
    public string TicketRequesterEmail { get; set; }
    public string TicketRequesterEmail2 { get; set; }
    public string TicketRequesterManagerName { get; set; }
    public string TicketRequesterMobile { get; set; }
    public string TicketRequesterName { get; set; }
    public string TicketRequesterOffice { get; set; }
    public string TicketRequesterOtherContacts { get; set; }
    public string TicketRequesterPersonalNumber { get; set; }
    public string TicketRequesterPhoneToWork { get; set; }
    public string TicketRequesterPhoneToWork2 { get; set; }
    public string TicketRequesterPosition { get; set; }
    public string TicketService { get; set; }
    public string TicketServicePhone { get; set; }
    public string TicketServiceProcess { get; set; }
    public string TicketSla { get; set; }
    public string TicketSolverAccountName { get; set; }
    public string TicketSolverDepartment { get; set; }
    public string TicketSolverEmail { get; set; }
    public string TicketSolverEmail2 { get; set; }
    public string TicketSolverManagerName { get; set; }
    public string TicketSolverMobile { get; set; }
    public string TicketSolverName { get; set; }
    public string TicketSolverOffice { get; set; }
    public string TicketSolverOtherContacts { get; set; }
    public string TicketSolverPersonalNumber { get; set; }
    public string TicketSolverPhoneToWork { get; set; }
    public string TicketSolverPhoneToWork2 { get; set; }
    public string TicketSolverPosition { get; set; }
    public string TicketStatus { get; set; }
    public string TicketTitle { get; set; }
    public int Urgency { get; set; }

    public MessageForApproverDataModel() { }
}
