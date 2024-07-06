using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Stocktaking - list of reader's files.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblInventoryAssetPack.htm"/>
[TableAttribute("dbo.tblInventoryAssetPack")]
public class tblInventoryAssetPack
{
    public virtual DateTime? dteCreated { get; set; }
    public virtual DateTime? dteExported { get; set; }
    public virtual DateTime? dteImported { get; set; }
    [KeyAttribute]
    public virtual int intInventoryAssetPackId { get; set; }
    public virtual int? lintInventoryId { get; set; }
    public virtual int? liPersonId { get; set; }
    public virtual string txtDesc { get; set; }
    public virtual string txtName { get; set; }
    /// <summary>If the reader file is intended for web asset check. 1 = Yes, 0 = No.</summary>
    public virtual bool Web { get; set; }

    public tblInventoryAssetPack() { }
}
