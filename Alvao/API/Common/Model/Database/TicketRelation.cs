using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Links Between Tickets.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketRelation.htm"/>
[TableAttribute("dbo.TicketRelation")]
public class TicketRelation {
    /// <summary>The ticket ID at the beginning of the link, see tHdTicket.iHdTicket.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketRelation_BeginHdTicketId.htm"/>
    public virtual int BeginHdTicketId { get; set; }
    /// <summary>Link creation date and time</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketRelation_Created.htm"/>
    public virtual DateTime? Created { get; set; }
    /// <summary>Link author ID, see tPerson.iPersonId.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketRelation_CreatedByPersonId.htm"/>
    public virtual int? CreatedByPersonId { get; set; }
    /// <summary>The ticket ID at the end of the link, see tHdTicket.iHdTicket.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketRelation_EndHdTicketId.htm"/>
    public virtual int EndHdTicketId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketRelation_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Link removal date and time</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketRelation_Removed.htm"/>
    public virtual DateTime? Removed { get; set; }
    /// <summary>User ID of a person who deleted the link - see tPerson.iPersonId.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketRelation_RemovedByPersonId.htm"/>
    public virtual int? RemovedByPersonId { get; set; }
    /// <summary>Link kind ID, see TicketRelationType.id.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketRelation_TicketRelationTypeId.htm"/>
    public virtual int TicketRelationTypeId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_TicketRelation__ctor.htm"/>
    public TicketRelation() { }
}
