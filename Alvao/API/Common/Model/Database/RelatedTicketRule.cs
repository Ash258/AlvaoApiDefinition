using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>The rules for automatic creation of linked tickets while transiting the source ticket to a certain status.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRule.html"/>
[Table("dbo.RelatedTicketRule")]
public class RelatedTicketRule {
    /// <summary>Relation direction; 1 = the created ticket is at the beginning of the relation, 0 = the created ticket is at the end of the relation.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRule.html#Alvao_API_Common_Model_Database_RelatedTicketRule_InDirection"/>
    public virtual bool InDirection { get; set; }
    /// <summary>ID of requester setting method (see RelatedTicketRuleRequesterMode.id). 1 = source ticket requester; 2 = source ticket solver; 3 = RequesterPersonId.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRule.html#Alvao_API_Common_Model_Database_RelatedTicketRule_RelatedTicketRuleRequesterModeId"/>
    public virtual byte RelatedTicketRuleRequesterModeId { get; set; }
    /// <summary>ID of selected custom field of type User. This column is used when RelatedTicketRuleRequesterModeId=4. Otherwise is null.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRule.html#Alvao_API_Common_Model_Database_RelatedTicketRule_RequesterColumnId"/>
    public virtual int? RequesterColumnId { get; set; }
    /// <summary>ID of requester for a new ticket (see tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRule.html#Alvao_API_Common_Model_Database_RelatedTicketRule_RequesterPersonId"/>
    public virtual int? RequesterPersonId { get; set; }
    /// <summary>SQL condition for creating a ticket</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRule.html#Alvao_API_Common_Model_Database_RelatedTicketRule_SqlCondition"/>
    public virtual string SqlCondition { get; set; }
    /// <summary>Ticket descrition template</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRule.html#Alvao_API_Common_Model_Database_RelatedTicketRule_TicketDescriptionTemplate"/>
    public virtual string TicketDescriptionTemplate { get; set; }
    /// <summary>Ticket name template</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRule.html#Alvao_API_Common_Model_Database_RelatedTicketRule_TicketNameTemplate"/>
    public virtual string TicketNameTemplate { get; set; }
    /// <summary>ID of the relation type between tickets (see TicketRelationType.id)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRule.html#Alvao_API_Common_Model_Database_RelatedTicketRule_TicketRelationTypeId"/>
    public virtual int TicketRelationTypeId { get; set; }
    /// <summary>Ticket status ID (TicketState.id)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRule.html#Alvao_API_Common_Model_Database_RelatedTicketRule_TicketStateId"/>
    public virtual int TicketStateId { get; set; }
    /// <summary>Ticket template ID (see TicketTemplate.id)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRule.html#Alvao_API_Common_Model_Database_RelatedTicketRule_TicketTemplateId"/>
    public virtual int TicketTemplateId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRule.html#Alvao_API_Common_Model_Database_RelatedTicketRule_id"/>
    [Key]
    public virtual int id { get; set; }
}
