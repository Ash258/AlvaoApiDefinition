using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>ID of the products types (commercial, freeware, ...) (software products library).</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblProductType.htm"/>
[TableAttribute("dbo.tblProductType")]
public class tblProductType
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProductType_intProductTypeId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int intProductTypeId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblProductType__ctor.htm"/>
    public tblProductType() { }
}
