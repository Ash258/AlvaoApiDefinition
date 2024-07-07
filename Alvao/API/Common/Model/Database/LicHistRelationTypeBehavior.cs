using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Types of links between licenses in the AM from the viewpoint of system/custom links.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_LicHistRelationTypeBehavior.htm"/>
[TableAttribute("dbo.LicHistRelationTypeBehavior")]
public class LicHistRelationTypeBehavior
{
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistRelationTypeBehavior_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistRelationTypeBehavior_Name.htm"/>
    public virtual string Name { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_LicHistRelationTypeBehavior__ctor.htm"/>
    public LicHistRelationTypeBehavior() { }
}
