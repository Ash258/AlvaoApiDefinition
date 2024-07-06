using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Stocktaking - assignment of assets to readers.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblInventoryAssetPackRel.htm"/>
[TableAttribute("dbo.tblInventoryAssetPackRel")]
public class tblInventoryAssetPackRel
{
    public virtual int? lintInventoryAssetId { get; set; }
    [ExplicitKeyAttribute]
    public virtual int? lintInventoryAssetPackId { get; set; }

    public tblInventoryAssetPackRel() { }
}
