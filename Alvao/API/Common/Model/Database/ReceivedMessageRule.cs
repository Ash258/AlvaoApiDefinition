using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Rules for incoming messages to service mailboxes.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html"/>
[Table("dbo.ReceivedMessageRule")]
public class ReceivedMessageRule {
    /// <summary>Condition for comparing with the body of the loaded mail.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_BodyCondition"/>
    /// <remarks>Column <c>BodyCondition</c>: nvarchar(255), null.</remarks>
    public virtual string BodyCondition { get; set; }
    /// <summary>Permit &quot;Remove ticket&quot; option (Yes/no).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_DeleteRequest"/>
    /// <remarks>Column <c>DeleteRequest</c>: bit, not null.</remarks>
    public virtual bool DeleteRequest { get; set; }
    /// <summary>Message subject for &quot;Send message&quot; action.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_MailSubject"/>
    /// <remarks>Column <c>MailSubject</c>: nvarchar(255), null.</remarks>
    public virtual string MailSubject { get; set; }
    /// <summary>Message text for &quot;Send message&quot; action.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_MailText"/>
    /// <remarks>Column <c>MailText</c>: nvarchar(max), null.</remarks>
    public virtual string MailText { get; set; }
    /// <summary>Message recipient for &quot;Send message&quot; action.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_MailTo"/>
    /// <remarks>Column <c>MailTo</c>: nvarchar(255), null.</remarks>
    public virtual string MailTo { get; set; }
    /// <summary>Person who edited the rules.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_ModifiedByPersonId"/>
    /// <remarks>Column <c>ModifiedByPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? ModifiedByPersonId { get; set; }
    /// <summary>Date and time of last rule edit.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_ModifiedDate"/>
    /// <remarks>Column <c>ModifiedDate</c>: datetime, null.</remarks>
    public virtual DateTime? ModifiedDate { get; set; }
    /// <summary>Permit &quot;Move to service&quot; action (Yes/No).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_MoveRequestToService"/>
    /// <remarks>Column <c>MoveRequestToService</c>: bit, not null.</remarks>
    public virtual bool MoveRequestToService { get; set; }
    /// <summary>If &quot;Move to service&quot; is permitted, the service id is displayed, otherwise NULL.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_MoveToSectionId"/>
    /// <remarks>Column <c>MoveToSectionId</c>: int, null. References <see cref="tHdSection"/>.</remarks>
    public virtual int? MoveToSectionId { get; set; }
    /// <summary>Determines the order in which the rules are detected and applied.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_OrderNum"/>
    /// <remarks>Column <c>OrderNum</c>: int, not null.</remarks>
    public virtual int OrderNum { get; set; }
    /// <summary>Condition for comparing with the sender of the loaded mail.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_ReceiverCondition"/>
    /// <remarks>Column <c>ReceiverCondition</c>: nvarchar(255), null.</remarks>
    public virtual string ReceiverCondition { get; set; }
    /// <summary>Enabling the option &quot;Resolve ticket&quot; (Yes/No).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_ResolveRequest"/>
    /// <remarks>Column <c>ResolveRequest</c>: bit, not null.</remarks>
    public virtual bool ResolveRequest { get; set; }
    /// <summary>Name of rules (must be unique).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_RuleName"/>
    /// <remarks>Column <c>RuleName</c>: nvarchar(255), not null.</remarks>
    public virtual string RuleName { get; set; }
    /// <summary>Permit &quot;Send message&quot; action (Yes/No).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_SendMessage"/>
    /// <remarks>Column <c>SendMessage</c>: bit, not null.</remarks>
    public virtual bool SendMessage { get; set; }
    /// <summary>Condition for comparing with the recipient of the loaded mail.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_SenderCondition"/>
    /// <remarks>Column <c>SenderCondition</c>: nvarchar(255), null.</remarks>
    public virtual string SenderCondition { get; set; }
    /// <summary>Condition for comparing with the subject of the loaded mail.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_SubjectCondition"/>
    /// <remarks>Column <c>SubjectCondition</c>: nvarchar(255), null.</remarks>
    public virtual string SubjectCondition { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessageRule.html#Alvao_API_Common_Model_Database_ReceivedMessageRule_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
