using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Recognition rules for files (software product library).</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html"/>
[Table("dbo.tblFileImage")]
public class tblFileImage {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_bolProductKey"/>
    public virtual bool bolProductKey { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_bolValid"/>
    public virtual bool bolValid { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_dteTimeStamp"/>
    public virtual DateTime dteTimeStamp { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intCodePage"/>
    public virtual int? intCodePage { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intFileImageId"/>
    [Key]
    public virtual int intFileImageId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intFileImageUID"/>
    public virtual int intFileImageUID { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intFileVersionLSHi"/>
    public virtual int? intFileVersionLSHi { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intFileVersionLSLo"/>
    public virtual int? intFileVersionLSLo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intFileVersionMSHi"/>
    public virtual int? intFileVersionMSHi { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intFileVersionMSLo"/>
    public virtual int? intFileVersionMSLo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intFlags"/>
    public virtual int? intFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intLanguage"/>
    public virtual int? intLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intOrder"/>
    public virtual int? intOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intProductVersionLSHi"/>
    public virtual int? intProductVersionLSHi { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intProductVersionLSLo"/>
    public virtual int? intProductVersionLSLo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intProductVersionMSHi"/>
    public virtual int? intProductVersionMSHi { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intProductVersionMSLo"/>
    public virtual int? intProductVersionMSLo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_intSize"/>
    public virtual int? intSize { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_lintProductId"/>
    public virtual int lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtCertifiedBy"/>
    public virtual string txtCertifiedBy { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtComments"/>
    public virtual string txtComments { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtCompanyName"/>
    public virtual string txtCompanyName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtExt"/>
    public virtual string txtExt { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtFileDescription"/>
    public virtual string txtFileDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtFileVersion"/>
    public virtual string txtFileVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtInternalName"/>
    public virtual string txtInternalName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtLegalCopyright"/>
    public virtual string txtLegalCopyright { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtLegalTrademarks"/>
    public virtual string txtLegalTrademarks { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtName"/>
    public virtual string txtName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtOriginalFilename"/>
    public virtual string txtOriginalFilename { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtPrivateBuild"/>
    public virtual string txtPrivateBuild { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtProductName"/>
    public virtual string txtProductName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtProductVersion"/>
    public virtual string txtProductVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileImage.html#Alvao_API_Common_Model_Database_tblFileImage_txtSpecialBuild"/>
    public virtual string txtSpecialBuild { get; set; }
}
