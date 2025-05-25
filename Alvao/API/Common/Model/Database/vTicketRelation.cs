using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Links Between Tickets.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketRelation.html"/>
[Table("dbo.vTicketRelation")]
public class vTicketRelation {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketRelation.html#Alvao_API_Common_Model_Database_vTicketRelation_BeginHdTicketId"/>
    public virtual int BeginHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketRelation.html#Alvao_API_Common_Model_Database_vTicketRelation_EndHdTicketId"/>
    public virtual int EndHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketRelation.html#Alvao_API_Common_Model_Database_vTicketRelation_TicketRelationTypeId"/>
    public virtual int TicketRelationTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketRelation.html#Alvao_API_Common_Model_Database_vTicketRelation_id"/>
    public virtual int id { get; set; }
}
