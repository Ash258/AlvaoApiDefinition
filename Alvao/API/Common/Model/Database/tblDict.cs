using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Common table for the text code lists of the system tables values.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html"/>
[Table("dbo.tblDict")]
public class tblDict {
    /// <summary>SW - error message for license on SW tab</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_iLicErrMsgId"/>
    /// <remarks>Column <c>iLicErrMsgId</c>: int, null.</remarks>
    public virtual int? iLicErrMsgId { get; set; }
    /// <summary>SW - license status - text</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_iLicenseStatusId"/>
    /// <remarks>Column <c>iLicenseStatusId</c>: int, null.</remarks>
    public virtual int? iLicenseStatusId { get; set; }
    /// <summary>SW - error message for profile on SW tab</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_iSwProfErrMsgId"/>
    /// <remarks>Column <c>iSwProfErrMsgId</c>: int, null.</remarks>
    public virtual int? iSwProfErrMsgId { get; set; }
    /// <summary>SW profiles - profile name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_liSwPresenceId"/>
    /// <remarks>Column <c>liSwPresenceId</c>: int, null.</remarks>
    public virtual int? liSwPresenceId { get; set; }
    /// <summary>Text for &quot;all objects&quot; - combo box</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintAllClassObjId"/>
    /// <remarks>Column <c>lintAllClassObjId</c>: int, null.</remarks>
    public virtual int? lintAllClassObjId { get; set; }
    /// <summary>Property status</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintAssetStateId"/>
    /// <remarks>Column <c>lintAssetStateId</c>: int, null.</remarks>
    public virtual int? lintAssetStateId { get; set; }
    /// <summary>object class - tblClass</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintClassId"/>
    /// <remarks>Column <c>lintClassId</c>: int, null. References <see cref="tblClass"/>.</remarks>
    [ExplicitKey]
    public virtual int? lintClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintDetectKindId"/>
    /// <remarks>Column <c>lintDetectKindId</c>: int, null. References <see cref="tblDetectKind"/>.</remarks>
    public virtual int? lintDetectKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintDetectStatusId"/>
    /// <remarks>Column <c>lintDetectStatusId</c>: int, null. References <see cref="tblDetectStatus"/>.</remarks>
    public virtual int? lintDetectStatusId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintDiaryKindId"/>
    /// <remarks>Column <c>lintDiaryKindId</c>: int, null.</remarks>
    public virtual int? lintDiaryKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintDocumentKindId"/>
    /// <remarks>Column <c>lintDocumentKindId</c>: int, null. References <see cref="tblDocumentKind"/>.</remarks>
    public virtual int? lintDocumentKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintHistoryFlags"/>
    /// <remarks>Column <c>lintHistoryFlags</c>: int, null.</remarks>
    public virtual int? lintHistoryFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintIdSeqId"/>
    /// <remarks>Column <c>lintIdSeqId</c>: int, null. References <see cref="tblIdSeq"/>.</remarks>
    public virtual int? lintIdSeqId { get; set; }
    /// <summary>installation/uninstallation reports</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintInstallMsgId"/>
    /// <remarks>Column <c>lintInstallMsgId</c>: int, null.</remarks>
    public virtual int? lintInstallMsgId { get; set; }
    /// <summary>Asset check status</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintInventoryStatusId"/>
    /// <remarks>Column <c>lintInventoryStatusId</c>: int, null.</remarks>
    public virtual int? lintInventoryStatusId { get; set; }
    /// <summary>Log - rental</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintLendMsgId"/>
    /// <remarks>Column <c>lintLendMsgId</c>: int, null.</remarks>
    public virtual int? lintLendMsgId { get; set; }
    /// <summary>Log - rental</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintLendSubjId"/>
    /// <remarks>Column <c>lintLendSubjId</c>: int, null.</remarks>
    public virtual int? lintLendSubjId { get; set; }
    /// <summary>Cal license</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintLicHistCALId"/>
    /// <remarks>Column <c>lintLicHistCALId</c>: int, null.</remarks>
    public virtual int? lintLicHistCALId { get; set; }
    /// <summary>License mode</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintLicModeId"/>
    /// <remarks>Column <c>lintLicModeId</c>: int, null.</remarks>
    public virtual int? lintLicModeId { get; set; }
    /// <summary>License kind</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintLicTypeId"/>
    /// <remarks>Column <c>lintLicTypeId</c>: int, null.</remarks>
    public virtual int? lintLicTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintMediaTypeId"/>
    /// <remarks>Column <c>lintMediaTypeId</c>: int, null. References <see cref="tblMediaType"/>.</remarks>
    public virtual int? lintMediaTypeId { get; set; }
    /// <summary>language name - tblLang</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintNameLangId"/>
    /// <remarks>Column <c>lintNameLangId</c>: int, null. References <see cref="tblLang"/>.</remarks>
    public virtual int? lintNameLangId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintProductCategoryId"/>
    /// <remarks>Column <c>lintProductCategoryId</c>: int, null. References <see cref="tblProductCategory"/>.</remarks>
    public virtual int? lintProductCategoryId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintProductTypeId"/>
    /// <remarks>Column <c>lintProductTypeId</c>: int, null. References <see cref="tblProductType"/>.</remarks>
    public virtual int? lintProductTypeId { get; set; }
    /// <summary>Log - edit</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintPropEditMsgId"/>
    /// <remarks>Column <c>lintPropEditMsgId</c>: int, null.</remarks>
    public virtual int? lintPropEditMsgId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_lintPropertyMapAssignId"/>
    /// <remarks>Column <c>lintPropertyMapAssignId</c>: int, null.</remarks>
    public virtual int? lintPropertyMapAssignId { get; set; }
    /// <summary>
    /// Just one of the attributes lintClassId, lintNameLangId, ..., lintDiaryKindId must have a value different from
    /// null. The attribute txtText contains the name of the relevant item.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDict.html#Alvao_API_Common_Model_Database_tblDict_txtText"/>
    /// <remarks>Column <c>txtText</c>: nvarchar(255), null.</remarks>
    public virtual string txtText { get; set; }
}
