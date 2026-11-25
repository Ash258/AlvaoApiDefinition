using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Links Between Tickets.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketRelation.html"/>
[Table("dbo.TicketRelation")]
public class TicketRelation {
    /// <summary>The ticket ID at the beginning of the link, see tHdTicket.iHdTicket.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketRelation.html#Alvao_API_Common_Model_Database_TicketRelation_BeginHdTicketId"/>
    /// <remarks>Column <c>BeginHdTicketId</c>: int, not null. References <see cref="tHdTicket"/>.</remarks>
    public virtual int BeginHdTicketId { get; set; }
    /// <summary>Link creation date and time</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketRelation.html#Alvao_API_Common_Model_Database_TicketRelation_Created"/>
    /// <remarks>Column <c>Created</c>: datetime, null.</remarks>
    public virtual DateTime? Created { get; set; }
    /// <summary>Link author ID, see tPerson.iPersonId.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketRelation.html#Alvao_API_Common_Model_Database_TicketRelation_CreatedByPersonId"/>
    /// <remarks>Column <c>CreatedByPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? CreatedByPersonId { get; set; }
    /// <summary>The ticket ID at the end of the link, see tHdTicket.iHdTicket.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketRelation.html#Alvao_API_Common_Model_Database_TicketRelation_EndHdTicketId"/>
    /// <remarks>Column <c>EndHdTicketId</c>: int, not null. References <see cref="tHdTicket"/>.</remarks>
    public virtual int EndHdTicketId { get; set; }
    /// <summary>Link removal date and time</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketRelation.html#Alvao_API_Common_Model_Database_TicketRelation_Removed"/>
    /// <remarks>Column <c>Removed</c>: datetime, null.</remarks>
    public virtual DateTime? Removed { get; set; }
    /// <summary>User ID of a person who deleted the link - see tPerson.iPersonId.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketRelation.html#Alvao_API_Common_Model_Database_TicketRelation_RemovedByPersonId"/>
    /// <remarks>Column <c>RemovedByPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? RemovedByPersonId { get; set; }
    /// <summary>Link kind ID, see TicketRelationType.id.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketRelation.html#Alvao_API_Common_Model_Database_TicketRelation_TicketRelationTypeId"/>
    /// <remarks>
    /// Column <c>TicketRelationTypeId</c>: int, not null. References <see cref="TicketRelationType"/>.
    /// </remarks>
    public virtual int TicketRelationTypeId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketRelation.html#Alvao_API_Common_Model_Database_TicketRelation_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
