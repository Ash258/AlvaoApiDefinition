using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Rules for incoming messages to service mailboxes.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html"/>
[Table("dbo.ReceivedMessageRule")]
public class ReceivedMessageRule {
    /// <summary>Condition for comparing with the body of the loaded mail.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_BodyCondition"/>
    public virtual string BodyCondition { get; set; }
    /// <summary>Permit &quot;Remove ticket&quot; option (Yes/no).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_DeleteRequest"/>
    public virtual bool DeleteRequest { get; set; }
    /// <summary>Message subject for &quot;Send message&quot; action.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_MailSubject"/>
    public virtual string MailSubject { get; set; }
    /// <summary>Message text for &quot;Send message&quot; action.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_MailText"/>
    public virtual string MailText { get; set; }
    /// <summary>Message recipient for &quot;Send message&quot; action.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_MailTo"/>
    public virtual string MailTo { get; set; }
    /// <summary>Person who edited the rules.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_ModifiedByPersonId"/>
    public virtual int? ModifiedByPersonId { get; set; }
    /// <summary>Date and time of last rule edit.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_ModifiedDate"/>
    public virtual DateTime? ModifiedDate { get; set; }
    /// <summary>Permit &quot;Move to service&quot; action (Yes/No).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_MoveRequestToService"/>
    public virtual bool MoveRequestToService { get; set; }
    /// <summary>If &quot;Move to service&quot; is permitted, the service id is displayed, otherwise NULL.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_MoveToSectionId"/>
    public virtual int? MoveToSectionId { get; set; }
    /// <summary>Determines the order in which the rules are detected and applied.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_OrderNum"/>
    public virtual int OrderNum { get; set; }
    /// <summary>Condition for comparing with the sender of the loaded mail.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_ReceiverCondition"/>
    public virtual string ReceiverCondition { get; set; }
    /// <summary>Enabling the option &quot;Resolve ticket&quot; (Yes/No).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_ResolveRequest"/>
    public virtual bool ResolveRequest { get; set; }
    /// <summary>Name of rules (must be unique).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_RuleName"/>
    public virtual string RuleName { get; set; }
    /// <summary>Permit &quot;Send message&quot; action (Yes/No).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_SendMessage"/>
    public virtual bool SendMessage { get; set; }
    /// <summary>Condition for comparing with the recipient of the loaded mail.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_SenderCondition"/>
    public virtual string SenderCondition { get; set; }
    /// <summary>Condition for comparing with the subject of the loaded mail.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_SubjectCondition"/>
    public virtual string SubjectCondition { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_id"/>
    [Key]
    public virtual int id { get; set; }
}
