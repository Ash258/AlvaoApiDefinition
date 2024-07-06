using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// License types.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_LicType.htm"/>
[TableAttribute("dbo.LicType")]
public class LicType
{
    /// <summary>Type name.</summary>
    public virtual string _LicType { get; set; }
    /// <summary>Item ID.</summary>
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }

    public LicType() { }
}
