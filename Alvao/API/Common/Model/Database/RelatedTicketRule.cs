using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// The rules for automatic creation of linked tickets while transiting the source ticket to a certain status.
/// </summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRule.html"/>
[Table("dbo.RelatedTicketRule")]
public class RelatedTicketRule {
    /// <summary>
    /// Relation direction; 1 = the created ticket is at the beginning of the relation, 0 = the created ticket is at the
    /// end of the relation.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRule.html#Alvao_API_Common_Model_Database_RelatedTicketRule_InDirection"/>
    /// <remarks>Column <c>InDirection</c>: bit, not null.</remarks>
    public virtual bool InDirection { get; set; }
    /// <summary>
    /// ID of requester setting method (see RelatedTicketRuleRequesterMode.id). 1 = source ticket requester; 2 = source
    /// ticket solver; 3 = RequesterPersonId.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRule.html#Alvao_API_Common_Model_Database_RelatedTicketRule_RelatedTicketRuleRequesterModeId"/>
    /// <remarks>
    /// Column <c>RelatedTicketRuleRequesterModeId</c>: tinyint, not null. References <see
    /// cref="RelatedTicketRuleRequesterMode"/>.
    /// </remarks>
    public virtual byte RelatedTicketRuleRequesterModeId { get; set; }
    /// <summary>
    /// ID of selected custom field of type User. This column is used when RelatedTicketRuleRequesterModeId=4. Otherwise
    /// is null.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRule.html#Alvao_API_Common_Model_Database_RelatedTicketRule_RequesterColumnId"/>
    /// <remarks>Column <c>RequesterColumnId</c>: int, null. References <see cref="tColumn"/>.</remarks>
    public virtual int? RequesterColumnId { get; set; }
    /// <summary>ID of requester for a new ticket (see tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRule.html#Alvao_API_Common_Model_Database_RelatedTicketRule_RequesterPersonId"/>
    /// <remarks>Column <c>RequesterPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? RequesterPersonId { get; set; }
    /// <summary>SQL condition for creating a ticket</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRule.html#Alvao_API_Common_Model_Database_RelatedTicketRule_SqlCondition"/>
    /// <remarks>Column <c>SqlCondition</c>: nvarchar(max), null.</remarks>
    public virtual string SqlCondition { get; set; }
    /// <summary>Ticket descrition template</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRule.html#Alvao_API_Common_Model_Database_RelatedTicketRule_TicketDescriptionTemplate"/>
    /// <remarks>Column <c>TicketDescriptionTemplate</c>: nvarchar(max), null.</remarks>
    public virtual string TicketDescriptionTemplate { get; set; }
    /// <summary>Ticket name template</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRule.html#Alvao_API_Common_Model_Database_RelatedTicketRule_TicketNameTemplate"/>
    /// <remarks>Column <c>TicketNameTemplate</c>: nvarchar(1024), null.</remarks>
    public virtual string TicketNameTemplate { get; set; }
    /// <summary>ID of the relation type between tickets (see TicketRelationType.id)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRule.html#Alvao_API_Common_Model_Database_RelatedTicketRule_TicketRelationTypeId"/>
    /// <remarks>
    /// Column <c>TicketRelationTypeId</c>: int, not null. References <see cref="TicketRelationType"/>.
    /// </remarks>
    public virtual int TicketRelationTypeId { get; set; }
    /// <summary>Ticket status ID (TicketState.id)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRule.html#Alvao_API_Common_Model_Database_RelatedTicketRule_TicketStateId"/>
    /// <remarks>Column <c>TicketStateId</c>: int, not null. References <see cref="TicketState"/>.</remarks>
    public virtual int TicketStateId { get; set; }
    /// <summary>Ticket template ID (see TicketTemplate.id)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRule.html#Alvao_API_Common_Model_Database_RelatedTicketRule_TicketTemplateId"/>
    /// <remarks>Column <c>TicketTemplateId</c>: int, not null. References <see cref="TicketTemplate"/>.</remarks>
    public virtual int TicketTemplateId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRule.html#Alvao_API_Common_Model_Database_RelatedTicketRule_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
