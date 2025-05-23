using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Statuses of the software profile on the products installed on the computers.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSwProfileProduct_Node.htm"/>
[TableAttribute("dbo.vSwProfileProduct_Node")]
public class vSwProfileProduct_Node {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwProfileProduct_Node_liNodeId.htm"/>
    public virtual int? liNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwProfileProduct_Node_liProductId.htm"/>
    public virtual int? liProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwProfileProduct_Node_liSwPresenceId.htm"/>
    public virtual int? liSwPresenceId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vSwProfileProduct_Node__ctor.htm"/>
    public vSwProfileProduct_Node() { }
}
