using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Reasons for not finding an asset during web asset check.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_AssetCheckReason.htm"/>
[TableAttribute("dbo.AssetCheckReason")]
public class AssetCheckReason
{
    /// <summary>Record ID</summary>
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Name of the reason</summary>
    public virtual string Name { get; set; }

    public AssetCheckReason() { }
}
