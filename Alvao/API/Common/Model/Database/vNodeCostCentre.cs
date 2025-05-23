using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cost center of the objects in the tree.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vNodeCostCentre.htm"/>
[TableAttribute("dbo.vNodeCostCentre")]
public class vNodeCostCentre {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNodeCostCentre_Centre.htm"/>
    public virtual string Centre { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNodeCostCentre_ClassId.htm"/>
    public virtual int? ClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNodeCostCentre_NodeId.htm"/>
    public virtual int NodeId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vNodeCostCentre__ctor.htm"/>
    public vNodeCostCentre() { }
}
