using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Common table for the text code lists of the system tables values.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblDict.htm"/>
[TableAttribute("dbo.tblDict")]
public class tblDict {
    /// <summary>SW - license status - text</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_iLicenseStatusId.htm"/>
    public virtual int? iLicenseStatusId { get; set; }
    /// <summary>SW - error message for license on SW tab</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_iLicErrMsgId.htm"/>
    public virtual int? iLicErrMsgId { get; set; }
    /// <summary>SW - error message for profile on SW tab</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_iSwProfErrMsgId.htm"/>
    public virtual int? iSwProfErrMsgId { get; set; }
    /// <summary>Text for "all objects" - combo box</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_lintAllClassObjId.htm"/>
    public virtual int? lintAllClassObjId { get; set; }
    /// <summary>Property status</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_lintAssetStateId.htm"/>
    public virtual int? lintAssetStateId { get; set; }
    /// <summary>object class - tblClass</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_lintClassId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int? lintClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_lintDetectKindId.htm"/>
    public virtual int? lintDetectKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_lintDetectStatusId.htm"/>
    public virtual int? lintDetectStatusId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_lintDiaryKindId.htm"/>
    public virtual int? lintDiaryKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_lintDocumentKindId.htm"/>
    public virtual int? lintDocumentKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_lintHistoryFlags.htm"/>
    public virtual int? lintHistoryFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_lintIdSeqId.htm"/>
    public virtual int? lintIdSeqId { get; set; }
    /// <summary>installation/uninstallation reports</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_lintInstallMsgId.htm"/>
    public virtual int? lintInstallMsgId { get; set; }
    /// <summary>Asset check status</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_lintInventoryStatusId.htm"/>
    public virtual int? lintInventoryStatusId { get; set; }
    /// <summary>Log - rental</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_lintLendMsgId.htm"/>
    public virtual int? lintLendMsgId { get; set; }
    /// <summary>Log - rental</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_lintLendSubjId.htm"/>
    public virtual int? lintLendSubjId { get; set; }
    /// <summary>Cal license</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_lintLicHistCALId.htm"/>
    public virtual int? lintLicHistCALId { get; set; }
    /// <summary>License mode</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_lintLicModeId.htm"/>
    public virtual int? lintLicModeId { get; set; }
    /// <summary>License kind</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_lintLicTypeId.htm"/>
    public virtual int? lintLicTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_lintMediaTypeId.htm"/>
    public virtual int? lintMediaTypeId { get; set; }
    /// <summary>language name - tblLang</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_lintNameLangId.htm"/>
    public virtual int? lintNameLangId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_lintProductCategoryId.htm"/>
    public virtual int? lintProductCategoryId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_lintProductTypeId.htm"/>
    public virtual int? lintProductTypeId { get; set; }
    /// <summary>Log - edit</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_lintPropEditMsgId.htm"/>
    public virtual int? lintPropEditMsgId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_lintPropertyMapAssignId.htm"/>
    public virtual int? lintPropertyMapAssignId { get; set; }
    /// <summary>SW profiles - profile name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_liSwPresenceId.htm"/>
    public virtual int? liSwPresenceId { get; set; }
    /// <summary>Just one of the attributes lintClassId, lintNameLangId, ..., lintDiaryKindId must have a value different from null. The attribute txtText contains the name of the relevant item.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDict_txtText.htm"/>
    public virtual string txtText { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblDict__ctor.htm"/>
    public tblDict() { }
}
