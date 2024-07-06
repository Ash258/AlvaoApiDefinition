using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Mapping attributes from AD to AM properties. This configuration is used by ImportAD.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblADMap.htm"/>
[TableAttribute("dbo.tblADMap")]
public class tblADMap
{
    public virtual bool bolKey { get; set; }
    [ExplicitKeyAttribute]
    public virtual int? lintClassId { get; set; }
    public virtual int? lintKindId { get; set; }
    public virtual string txtADAttr { get; set; }
    public virtual string txtADClass { get; set; }

    public tblADMap() { }
}
