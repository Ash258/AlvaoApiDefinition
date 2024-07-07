using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Stocktaking - assets in a specific stocktaking.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblInventoryAsset.htm"/>
[TableAttribute("dbo.tblInventoryAsset")]
public class tblInventoryAsset
{
    /// <summary>ID of the reason for not finding an asset during web asset check (AssetCheckReason.id)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_AssetCheckReasonId.htm"/>
    public virtual int? AssetCheckReasonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_bolLocked.htm"/>
    public virtual bool bolLocked { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_bolProcessed.htm"/>
    public virtual bool bolProcessed { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_bolTransfered.htm"/>
    public virtual bool bolTransfered { get; set; }
    /// <summary>The user name of a user who confirmed the asset over web.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_ConfirmedBy.htm"/>
    public virtual string ConfirmedBy { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_dRead_Date.htm"/>
    public virtual DateTime? dRead_Date { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_dteCreated.htm"/>
    public virtual DateTime? dteCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_intInventoryAssetId.htm"/>
    [KeyAttribute]
    public virtual int intInventoryAssetId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_intSelectionNum.htm"/>
    public virtual int? intSelectionNum { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_lintInventoryId.htm"/>
    public virtual int? lintInventoryId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_lintNodeId.htm"/>
    public virtual int? lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_lintUserNodeId.htm"/>
    public virtual int? lintUserNodeId { get; set; }
    /// <summary>A message from a person performing asset check over web.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_NoteForAdmin.htm"/>
    public virtual string NoteForAdmin { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_txtAsset_Centre.htm"/>
    public virtual string txtAsset_Centre { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_txtAsset_EvidentaryNum.htm"/>
    public virtual string txtAsset_EvidentaryNum { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_txtAsset_InventoryNum.htm"/>
    public virtual string txtAsset_InventoryNum { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_txtAsset_Name.htm"/>
    public virtual string txtAsset_Name { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_txtAsset_Place.htm"/>
    public virtual string txtAsset_Place { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_txtAsset_SerialNum.htm"/>
    public virtual string txtAsset_SerialNum { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_txtAsset_User.htm"/>
    public virtual string txtAsset_User { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_txtAsset_User_PersonalId.htm"/>
    public virtual string txtAsset_User_PersonalId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_txtDesc.htm"/>
    public virtual string txtDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_txtRead_Asset_Centre.htm"/>
    public virtual string txtRead_Asset_Centre { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_txtRead_Asset_Class.htm"/>
    public virtual string txtRead_Asset_Class { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_txtRead_Asset_EvidentaryNum.htm"/>
    public virtual string txtRead_Asset_EvidentaryNum { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_txtRead_Asset_InventoryNum.htm"/>
    public virtual string txtRead_Asset_InventoryNum { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_txtRead_Asset_Name.htm"/>
    public virtual string txtRead_Asset_Name { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_txtRead_Asset_Place.htm"/>
    public virtual string txtRead_Asset_Place { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_txtRead_Asset_SerialNum.htm"/>
    public virtual string txtRead_Asset_SerialNum { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_txtRead_Asset_User.htm"/>
    public virtual string txtRead_Asset_User { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_txtRead_Asset_User_PersonalId.htm"/>
    public virtual string txtRead_Asset_User_PersonalId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInventoryAsset_txtRead_State.htm"/>
    public virtual string txtRead_State { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblInventoryAsset__ctor.htm"/>
    public tblInventoryAsset() { }
}
