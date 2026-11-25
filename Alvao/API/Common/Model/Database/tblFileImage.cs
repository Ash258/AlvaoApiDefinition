using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Recognition rules for files (software product library).</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html"/>
[Table("dbo.tblFileImage")]
public class tblFileImage {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_bolProductKey"/>
    /// <remarks>Column <c>bolProductKey</c>: bit, not null.</remarks>
    public virtual bool bolProductKey { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_bolValid"/>
    /// <remarks>Column <c>bolValid</c>: bit, not null.</remarks>
    public virtual bool bolValid { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_dteTimeStamp"/>
    /// <remarks>Column <c>dteTimeStamp</c>: datetime, not null.</remarks>
    public virtual DateTime dteTimeStamp { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intCodePage"/>
    /// <remarks>Column <c>intCodePage</c>: int, null.</remarks>
    public virtual int? intCodePage { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intFileImageId"/>
    /// <remarks>Column <c>intFileImageId</c>: int, not null.</remarks>
    [Key]
    public virtual int intFileImageId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intFileImageUID"/>
    /// <remarks>Column <c>intFileImageUID</c>: int, not null.</remarks>
    public virtual int intFileImageUID { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intFileVersionLSHi"/>
    /// <remarks>Column <c>intFileVersionLSHi</c>: int, null.</remarks>
    public virtual int? intFileVersionLSHi { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intFileVersionLSLo"/>
    /// <remarks>Column <c>intFileVersionLSLo</c>: int, null.</remarks>
    public virtual int? intFileVersionLSLo { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intFileVersionMSHi"/>
    /// <remarks>Column <c>intFileVersionMSHi</c>: int, null.</remarks>
    public virtual int? intFileVersionMSHi { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intFileVersionMSLo"/>
    /// <remarks>Column <c>intFileVersionMSLo</c>: int, null.</remarks>
    public virtual int? intFileVersionMSLo { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intFlags"/>
    /// <remarks>Column <c>intFlags</c>: int, null.</remarks>
    public virtual int? intFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intLanguage"/>
    /// <remarks>Column <c>intLanguage</c>: int, null.</remarks>
    public virtual int? intLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intOrder"/>
    /// <remarks>Column <c>intOrder</c>: int, null.</remarks>
    public virtual int? intOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intProductVersionLSHi"/>
    /// <remarks>Column <c>intProductVersionLSHi</c>: int, null.</remarks>
    public virtual int? intProductVersionLSHi { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intProductVersionLSLo"/>
    /// <remarks>Column <c>intProductVersionLSLo</c>: int, null.</remarks>
    public virtual int? intProductVersionLSLo { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intProductVersionMSHi"/>
    /// <remarks>Column <c>intProductVersionMSHi</c>: int, null.</remarks>
    public virtual int? intProductVersionMSHi { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intProductVersionMSLo"/>
    /// <remarks>Column <c>intProductVersionMSLo</c>: int, null.</remarks>
    public virtual int? intProductVersionMSLo { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intSize"/>
    /// <remarks>Column <c>intSize</c>: int, null.</remarks>
    public virtual int? intSize { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_lintProductId"/>
    /// <remarks>Column <c>lintProductId</c>: int, not null. References <see cref="tblProduct"/>.</remarks>
    public virtual int lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtCertifiedBy"/>
    /// <remarks>Column <c>txtCertifiedBy</c>: nvarchar(255), null.</remarks>
    public virtual string txtCertifiedBy { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtComments"/>
    /// <remarks>Column <c>txtComments</c>: nvarchar(255), null.</remarks>
    public virtual string txtComments { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtCompanyName"/>
    /// <remarks>Column <c>txtCompanyName</c>: nvarchar(255), null.</remarks>
    public virtual string txtCompanyName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtExt"/>
    /// <remarks>Column <c>txtExt</c>: nvarchar(255), null.</remarks>
    public virtual string txtExt { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtFileDescription"/>
    /// <remarks>Column <c>txtFileDescription</c>: nvarchar(255), null.</remarks>
    public virtual string txtFileDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtFileVersion"/>
    /// <remarks>Column <c>txtFileVersion</c>: nvarchar(255), null.</remarks>
    public virtual string txtFileVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtInternalName"/>
    /// <remarks>Column <c>txtInternalName</c>: nvarchar(255), null.</remarks>
    public virtual string txtInternalName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtLegalCopyright"/>
    /// <remarks>Column <c>txtLegalCopyright</c>: nvarchar(255), null.</remarks>
    public virtual string txtLegalCopyright { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtLegalTrademarks"/>
    /// <remarks>Column <c>txtLegalTrademarks</c>: nvarchar(255), null.</remarks>
    public virtual string txtLegalTrademarks { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtName"/>
    /// <remarks>Column <c>txtName</c>: nvarchar(255), null.</remarks>
    public virtual string txtName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtOriginalFilename"/>
    /// <remarks>Column <c>txtOriginalFilename</c>: nvarchar(255), null.</remarks>
    public virtual string txtOriginalFilename { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtPrivateBuild"/>
    /// <remarks>Column <c>txtPrivateBuild</c>: nvarchar(255), null.</remarks>
    public virtual string txtPrivateBuild { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtProductName"/>
    /// <remarks>Column <c>txtProductName</c>: nvarchar(255), null.</remarks>
    public virtual string txtProductName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtProductVersion"/>
    /// <remarks>Column <c>txtProductVersion</c>: nvarchar(255), null.</remarks>
    public virtual string txtProductVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtSpecialBuild"/>
    /// <remarks>Column <c>txtSpecialBuild</c>: nvarchar(255), null.</remarks>
    public virtual string txtSpecialBuild { get; set; }
}
