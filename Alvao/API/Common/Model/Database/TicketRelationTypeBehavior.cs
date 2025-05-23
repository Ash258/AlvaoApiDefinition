using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>System types of links between tickets.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketRelationTypeBehavior.htm"/>
[TableAttribute("dbo.TicketRelationTypeBehavior")]
public class TicketRelationTypeBehavior {
    /// <summary>Link name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketRelationTypeBehavior__TicketRelationTypeBehavior.htm"/>
    public virtual string _TicketRelationTypeBehavior { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketRelationTypeBehavior_id.htm"/>
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_TicketRelationTypeBehavior__ctor.htm"/>
    public TicketRelationTypeBehavior() { }
}
