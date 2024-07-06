using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Rules for incoming messages to service mailboxes.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_ReceivedMessageRule.htm"/>
[TableAttribute("dbo.ReceivedMessageRule")]
public class ReceivedMessageRule
{
    /// <summary>Condition for comparing with the body of the loaded mail.</summary>
    public virtual string BodyCondition { get; set; }
    /// <summary>Permit "Remove ticket" option (Yes/no).</summary>
    public virtual bool DeleteRequest { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Message subject for "Send message" action.</summary>
    public virtual string MailSubject { get; set; }
    /// <summary>Message text for "Send message" action.</summary>
    public virtual string MailText { get; set; }
    /// <summary>Message recipient for "Send message" action.</summary>
    public virtual string MailTo { get; set; }
    /// <summary>Person who edited the rules.</summary>
    public virtual int? ModifiedByPersonId { get; set; }
    /// <summary>Date and time of last rule edit.</summary>
    public virtual DateTime? ModifiedDate { get; set; }
    /// <summary>Permit "Move to service" action (Yes/No).</summary>
    public virtual bool MoveRequestToService { get; set; }
    /// <summary>If "Move to service" is permitted, the service id is displayed, otherwise NULL.</summary>
    public virtual int? MoveToSectionId { get; set; }
    /// <summary>Determines the order in which the rules are detected and applied.</summary>
    public virtual int OrderNum { get; set; }
    /// <summary>Condition for comparing with the sender of the loaded mail.</summary>
    public virtual string ReceiverCondition { get; set; }
    /// <summary>Enabling the option "Resolve ticket" (Yes/No).</summary>
    public virtual bool ResolveRequest { get; set; }
    /// <summary>Name of rules (must be unique).</summary>
    public virtual string RuleName { get; set; }
    /// <summary>Condition for comparing with the recipient of the loaded mail.</summary>
    public virtual string SenderCondition { get; set; }
    /// <summary>Permit "Send message" action (Yes/No).</summary>
    public virtual bool SendMessage { get; set; }
    /// <summary>Condition for comparing with the subject of the loaded mail.</summary>
    public virtual string SubjectCondition { get; set; }

    public ReceivedMessageRule() { }
}
