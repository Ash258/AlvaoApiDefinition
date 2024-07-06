using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Value lists for the properties of objects.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblKindValue.htm"/>
[TableAttribute("dbo.tblKindValue")]
public class tblKindValue
{
    /// <summary>System item identification</summary>
    public virtual int? KindValueBehaviorId { get; set; }
    /// <summary>definition of property - tblKind</summary>
    [ExplicitKeyAttribute]
    public virtual int lintKindId { get; set; }
    /// <summary>Value</summary>
    public virtual string txtValue { get; set; }

    public tblKindValue() { }
}
