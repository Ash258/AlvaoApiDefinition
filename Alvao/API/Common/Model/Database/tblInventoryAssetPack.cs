using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Stocktaking - list of reader's files.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblInventoryAssetPack.htm"/>
[TableAttribute("dbo.tblInventoryAssetPack")]
public class tblInventoryAssetPack {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAssetPack_dteCreated.htm"/>
    public virtual DateTime? dteCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAssetPack_dteExported.htm"/>
    public virtual DateTime? dteExported { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAssetPack_dteImported.htm"/>
    public virtual DateTime? dteImported { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAssetPack_intInventoryAssetPackId.htm"/>
    [KeyAttribute]
    public virtual int intInventoryAssetPackId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAssetPack_lintInventoryId.htm"/>
    public virtual int? lintInventoryId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAssetPack_liPersonId.htm"/>
    public virtual int? liPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAssetPack_txtDesc.htm"/>
    public virtual string txtDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAssetPack_txtName.htm"/>
    public virtual string txtName { get; set; }
    /// <summary>If the reader file is intended for web asset check. 1 = Yes, 0 = No.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAssetPack_Web.htm"/>
    public virtual bool Web { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblInventoryAssetPack__ctor.htm"/>
    public tblInventoryAssetPack() { }
}
