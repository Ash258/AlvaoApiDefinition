using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>List of child tickets that person should see.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vChildTicketPersonRead.html"/>
[Table("dbo.vChildTicketPersonRead")]
public class vChildTicketPersonRead {
    /// <summary>Ticket ID of child ticket (tHdTicket.iHdTicketId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vChildTicketPersonRead.html#Alvao_API_Common_Model_Database_vChildTicketPersonRead_ChildTicketId"/>
    public virtual int ChildTicketId { get; set; }
    /// <summary>Ticket ID of parent ticket (tHdTicket.iHdTicketId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vChildTicketPersonRead.html#Alvao_API_Common_Model_Database_vChildTicketPersonRead_ParentTicketId"/>
    public virtual int ParentTicketId { get; set; }
    /// <summary>User ID (tPerson.iPersonId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vChildTicketPersonRead.html#Alvao_API_Common_Model_Database_vChildTicketPersonRead_PersonId"/>
    public virtual int? PersonId { get; set; }
}
