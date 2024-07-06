using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Common table for the text code lists of the system tables values.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblDict.htm"/>
[TableAttribute("dbo.tblDict")]
public class tblDict
{
    /// <summary>SW - license status - text</summary>
    public virtual int? iLicenseStatusId { get; set; }
    /// <summary>SW - error message for license on SW tab</summary>
    public virtual int? iLicErrMsgId { get; set; }
    /// <summary>SW - error message for profile on SW tab</summary>
    public virtual int? iSwProfErrMsgId { get; set; }
    /// <summary>Text for "all objects" - combo box</summary>
    public virtual int? lintAllClassObjId { get; set; }
    /// <summary>Property status</summary>
    public virtual int? lintAssetStateId { get; set; }
    /// <summary>object class - tblClass</summary>
    [ExplicitKeyAttribute]
    public virtual int? lintClassId { get; set; }
    public virtual int? lintDetectKindId { get; set; }
    public virtual int? lintDetectStatusId { get; set; }
    public virtual int? lintDiaryKindId { get; set; }
    public virtual int? lintDocumentKindId { get; set; }
    public virtual int? lintHistoryFlags { get; set; }
    public virtual int? lintIdSeqId { get; set; }
    /// <summary>installation/uninstallation reports</summary>
    public virtual int? lintInstallMsgId { get; set; }
    /// <summary>Asset check status</summary>
    public virtual int? lintInventoryStatusId { get; set; }
    /// <summary>Log - rental</summary>
    public virtual int? lintLendMsgId { get; set; }
    /// <summary>Log - rental</summary>
    public virtual int? lintLendSubjId { get; set; }
    /// <summary>Cal license</summary>
    public virtual int? lintLicHistCALId { get; set; }
    /// <summary>License mode</summary>
    public virtual int? lintLicModeId { get; set; }
    /// <summary>License kind</summary>
    public virtual int? lintLicTypeId { get; set; }
    public virtual int? lintMediaTypeId { get; set; }
    /// <summary>language name - tblLang</summary>
    public virtual int? lintNameLangId { get; set; }
    public virtual int? lintProductCategoryId { get; set; }
    public virtual int? lintProductTypeId { get; set; }
    /// <summary>Log - edit</summary>
    public virtual int? lintPropEditMsgId { get; set; }
    public virtual int? lintPropertyMapAssignId { get; set; }
    /// <summary>SW profiles - profile name</summary>
    public virtual int? liSwPresenceId { get; set; }
    /// <summary>Just one of the attributes lintClassId, lintNameLangId, ..., lintDiaryKindId must have a value different from null. The attribute txtText contains the name of the relevant item.</summary>
    public virtual string txtText { get; set; }

    public tblDict() { }
}
