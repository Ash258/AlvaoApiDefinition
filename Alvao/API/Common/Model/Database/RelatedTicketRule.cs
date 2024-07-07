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
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RelatedTicketRule_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Relation direction; 1 = the created ticket is at the beginning of the relation, 0 = the created ticket is at the end of the relation.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RelatedTicketRule_InDirection.htm"/>
    public virtual bool InDirection { get; set; }
    /// <summary>ID of requester setting method (see RelatedTicketRuleRequesterMode.id). 1 = source ticket requester; 2 = source ticket solver; 3 = RequesterPersonId.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RelatedTicketRule_RelatedTicketRuleRequesterModeId.htm"/>
    public virtual byte RelatedTicketRuleRequesterModeId { get; set; }
    /// <summary>ID of selected custom field of type User. This column is used when RelatedTicketRuleRequesterModeId=4. Otherwise is null.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RelatedTicketRule_RequesterColumnId.htm"/>
    public virtual int? RequesterColumnId { get; set; }
    /// <summary>ID of requester for a new ticket (see tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RelatedTicketRule_RequesterPersonId.htm"/>
    public virtual int? RequesterPersonId { get; set; }
    /// <summary>SQL condition for creating a ticket</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RelatedTicketRule_SqlCondition.htm"/>
    public virtual string SqlCondition { get; set; }
    /// <summary>Ticket name template</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RelatedTicketRule_TicketNameTemplate.htm"/>
    public virtual string TicketNameTemplate { get; set; }
    /// <summary>ID of the relation type between tickets (see TicketRelationType.id)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RelatedTicketRule_TicketRelationTypeId.htm"/>
    public virtual int TicketRelationTypeId { get; set; }
    /// <summary>Ticket status ID (TicketState.id)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RelatedTicketRule_TicketStateId.htm"/>
    public virtual int TicketStateId { get; set; }
    /// <summary>Ticket template ID (see TicketTemplate.id)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RelatedTicketRule_TicketTemplateId.htm"/>
    public virtual int TicketTemplateId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_RelatedTicketRule__ctor.htm"/>
    public RelatedTicketRule() { }
}
