using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Types of links between objects in the AM from the viewpoint of system/custom links.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_NodeRelationTypeBehavior.htm"/>
[TableAttribute("dbo.NodeRelationTypeBehavior")]
public class NodeRelationTypeBehavior {
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeRelationTypeBehavior_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NodeRelationTypeBehavior_Name.htm"/>
    public virtual string Name { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_NodeRelationTypeBehavior__ctor.htm"/>
    public NodeRelationTypeBehavior() { }
}
