using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// The rules for automatic creation of linked tickets while transiting the source ticket to a certain status.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_RelatedTicketRule.htm"/>
[TableAttribute("dbo.RelatedTicketRule")]
public class RelatedTicketRule
{
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Relation direction; 1 = the created ticket is at the beginning of the relation, 0 = the created ticket is at the end of the relation.</summary>
    public virtual bool InDirection { get; set; }
    /// <summary>ID of requester setting method (see RelatedTicketRuleRequesterMode.id). 1 = source ticket requester; 2 = source ticket solver; 3 = RequesterPersonId.</summary>
    public virtual byte RelatedTicketRuleRequesterModeId { get; set; }
    /// <summary>ID of selected custom field of type User. This column is used when RelatedTicketRuleRequesterModeId=4. Otherwise is null.</summary>
    public virtual int? RequesterColumnId { get; set; }
    /// <summary>ID of requester for a new ticket (see tPerson.iPersonId)</summary>
    public virtual int? RequesterPersonId { get; set; }
    /// <summary>SQL condition for creating a ticket</summary>
    public virtual string SqlCondition { get; set; }
    /// <summary>Ticket name template</summary>
    public virtual string TicketNameTemplate { get; set; }
    /// <summary>ID of the relation type between tickets (see TicketRelationType.id)</summary>
    public virtual int TicketRelationTypeId { get; set; }
    /// <summary>Ticket status ID (TicketState.id)</summary>
    public virtual int TicketStateId { get; set; }
    /// <summary>Ticket template ID (see TicketTemplate.id)</summary>
    public virtual int TicketTemplateId { get; set; }

    public RelatedTicketRule() { }
}
