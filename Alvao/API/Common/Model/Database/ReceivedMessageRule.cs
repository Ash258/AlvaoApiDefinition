using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Rules for incoming messages to service mailboxes.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_ReceivedMessageRule.htm"/>
[TableAttribute("dbo.ReceivedMessageRule")]
public class ReceivedMessageRule {
    /// <summary>Condition for comparing with the body of the loaded mail.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ReceivedMessageRule_BodyCondition.htm"/>
    public virtual string BodyCondition { get; set; }
    /// <summary>Permit "Remove ticket" option (Yes/no).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ReceivedMessageRule_DeleteRequest.htm"/>
    public virtual bool DeleteRequest { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ReceivedMessageRule_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Message subject for "Send message" action.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ReceivedMessageRule_MailSubject.htm"/>
    public virtual string MailSubject { get; set; }
    /// <summary>Message text for "Send message" action.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ReceivedMessageRule_MailText.htm"/>
    public virtual string MailText { get; set; }
    /// <summary>Message recipient for "Send message" action.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ReceivedMessageRule_MailTo.htm"/>
    public virtual string MailTo { get; set; }
    /// <summary>Person who edited the rules.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ReceivedMessageRule_ModifiedByPersonId.htm"/>
    public virtual int? ModifiedByPersonId { get; set; }
    /// <summary>Date and time of last rule edit.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ReceivedMessageRule_ModifiedDate.htm"/>
    public virtual DateTime? ModifiedDate { get; set; }
    /// <summary>Permit "Move to service" action (Yes/No).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ReceivedMessageRule_MoveRequestToService.htm"/>
    public virtual bool MoveRequestToService { get; set; }
    /// <summary>If "Move to service" is permitted, the service id is displayed, otherwise NULL.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ReceivedMessageRule_MoveToSectionId.htm"/>
    public virtual int? MoveToSectionId { get; set; }
    /// <summary>Determines the order in which the rules are detected and applied.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ReceivedMessageRule_OrderNum.htm"/>
    public virtual int OrderNum { get; set; }
    /// <summary>Condition for comparing with the sender of the loaded mail.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ReceivedMessageRule_ReceiverCondition.htm"/>
    public virtual string ReceiverCondition { get; set; }
    /// <summary>Enabling the option "Resolve ticket" (Yes/No).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ReceivedMessageRule_ResolveRequest.htm"/>
    public virtual bool ResolveRequest { get; set; }
    /// <summary>Name of rules (must be unique).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ReceivedMessageRule_RuleName.htm"/>
    public virtual string RuleName { get; set; }
    /// <summary>Condition for comparing with the recipient of the loaded mail.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ReceivedMessageRule_SenderCondition.htm"/>
    public virtual string SenderCondition { get; set; }
    /// <summary>Permit "Send message" action (Yes/No).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ReceivedMessageRule_SendMessage.htm"/>
    public virtual bool SendMessage { get; set; }
    /// <summary>Condition for comparing with the subject of the loaded mail.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ReceivedMessageRule_SubjectCondition.htm"/>
    public virtual string SubjectCondition { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_ReceivedMessageRule__ctor.htm"/>
    public ReceivedMessageRule() { }
}
