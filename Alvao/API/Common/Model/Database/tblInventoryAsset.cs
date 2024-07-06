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
    public virtual int? AssetCheckReasonId { get; set; }
    public virtual bool bolLocked { get; set; }
    public virtual bool bolProcessed { get; set; }
    public virtual bool bolTransfered { get; set; }
    /// <summary>The user name of a user who confirmed the asset over web.</summary>
    public virtual string ConfirmedBy { get; set; }
    public virtual DateTime? dRead_Date { get; set; }
    public virtual DateTime? dteCreated { get; set; }
    [KeyAttribute]
    public virtual int intInventoryAssetId { get; set; }
    public virtual int? intSelectionNum { get; set; }
    public virtual int? lintInventoryId { get; set; }
    public virtual int? lintNodeId { get; set; }
    public virtual int? lintUserNodeId { get; set; }
    /// <summary>A message from a person performing asset check over web.</summary>
    public virtual string NoteForAdmin { get; set; }
    public virtual string txtAsset_Centre { get; set; }
    public virtual string txtAsset_EvidentaryNum { get; set; }
    public virtual string txtAsset_InventoryNum { get; set; }
    public virtual string txtAsset_Name { get; set; }
    public virtual string txtAsset_Place { get; set; }
    public virtual string txtAsset_SerialNum { get; set; }
    public virtual string txtAsset_User { get; set; }
    public virtual string txtAsset_User_PersonalId { get; set; }
    public virtual string txtDesc { get; set; }
    public virtual string txtRead_Asset_Centre { get; set; }
    public virtual string txtRead_Asset_Class { get; set; }
    public virtual string txtRead_Asset_EvidentaryNum { get; set; }
    public virtual string txtRead_Asset_InventoryNum { get; set; }
    public virtual string txtRead_Asset_Name { get; set; }
    public virtual string txtRead_Asset_Place { get; set; }
    public virtual string txtRead_Asset_SerialNum { get; set; }
    public virtual string txtRead_Asset_User { get; set; }
    public virtual string txtRead_Asset_User_PersonalId { get; set; }
    public virtual string txtRead_State { get; set; }

    public tblInventoryAsset() { }
}
