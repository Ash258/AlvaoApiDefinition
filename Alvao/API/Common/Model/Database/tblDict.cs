using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Common table for the text code lists of the system tables values.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html"/>
[Table("dbo.tblDict")]
public class tblDict {
    /// <summary>SW - error message for license on SW tab</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_iLicErrMsgId"/>
    public virtual int? iLicErrMsgId { get; set; }
    /// <summary>SW - license status - text</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_iLicenseStatusId"/>
    public virtual int? iLicenseStatusId { get; set; }
    /// <summary>SW - error message for profile on SW tab</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_iSwProfErrMsgId"/>
    public virtual int? iSwProfErrMsgId { get; set; }
    /// <summary>SW profiles - profile name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_liSwPresenceId"/>
    public virtual int? liSwPresenceId { get; set; }
    /// <summary>Text for &quot;all objects&quot; - combo box</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintAllClassObjId"/>
    public virtual int? lintAllClassObjId { get; set; }
    /// <summary>Property status</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintAssetStateId"/>
    public virtual int? lintAssetStateId { get; set; }
    /// <summary>object class - tblClass</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintClassId"/>
    [ExplicitKey]
    public virtual int? lintClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintDetectKindId"/>
    public virtual int? lintDetectKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintDetectStatusId"/>
    public virtual int? lintDetectStatusId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintDiaryKindId"/>
    public virtual int? lintDiaryKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintDocumentKindId"/>
    public virtual int? lintDocumentKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintHistoryFlags"/>
    public virtual int? lintHistoryFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintIdSeqId"/>
    public virtual int? lintIdSeqId { get; set; }
    /// <summary>installation/uninstallation reports</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintInstallMsgId"/>
    public virtual int? lintInstallMsgId { get; set; }
    /// <summary>Asset check status</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintInventoryStatusId"/>
    public virtual int? lintInventoryStatusId { get; set; }
    /// <summary>Log - rental</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintLendMsgId"/>
    public virtual int? lintLendMsgId { get; set; }
    /// <summary>Log - rental</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintLendSubjId"/>
    public virtual int? lintLendSubjId { get; set; }
    /// <summary>Cal license</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintLicHistCALId"/>
    public virtual int? lintLicHistCALId { get; set; }
    /// <summary>License mode</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintLicModeId"/>
    public virtual int? lintLicModeId { get; set; }
    /// <summary>License kind</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintLicTypeId"/>
    public virtual int? lintLicTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintMediaTypeId"/>
    public virtual int? lintMediaTypeId { get; set; }
    /// <summary>language name - tblLang</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintNameLangId"/>
    public virtual int? lintNameLangId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintProductCategoryId"/>
    public virtual int? lintProductCategoryId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintProductTypeId"/>
    public virtual int? lintProductTypeId { get; set; }
    /// <summary>Log - edit</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintPropEditMsgId"/>
    public virtual int? lintPropEditMsgId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintPropertyMapAssignId"/>
    public virtual int? lintPropertyMapAssignId { get; set; }
    /// <summary>Just one of the attributes lintClassId, lintNameLangId, ..., lintDiaryKindId must have a value different from null. The attribute txtText contains the name of the relevant item.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_txtText"/>
    public virtual string txtText { get; set; }
}
