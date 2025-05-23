using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Recognition rules for files (software products library).</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblFileImage.htm"/>
[TableAttribute("dbo.tblFileImage")]
public class tblFileImage
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_bolProductKey.htm"/>
    public virtual bool bolProductKey { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_bolValid.htm"/>
    public virtual bool bolValid { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_dteTimeStamp.htm"/>
    public virtual DateTime dteTimeStamp { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_intCodePage.htm"/>
    public virtual int? intCodePage { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_intFileImageId.htm"/>
    [KeyAttribute]
    public virtual int intFileImageId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_intFileImageUID.htm"/>
    public virtual int intFileImageUID { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_intFileVersionLSHi.htm"/>
    public virtual int? intFileVersionLSHi { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_intFileVersionLSLo.htm"/>
    public virtual int? intFileVersionLSLo { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_intFileVersionMSHi.htm"/>
    public virtual int? intFileVersionMSHi { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_intFileVersionMSLo.htm"/>
    public virtual int? intFileVersionMSLo { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_intFlags.htm"/>
    public virtual int? intFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_intLanguage.htm"/>
    public virtual int? intLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_intOrder.htm"/>
    public virtual int? intOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_intProductVersionLSHi.htm"/>
    public virtual int? intProductVersionLSHi { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_intProductVersionLSLo.htm"/>
    public virtual int? intProductVersionLSLo { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_intProductVersionMSHi.htm"/>
    public virtual int? intProductVersionMSHi { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_intProductVersionMSLo.htm"/>
    public virtual int? intProductVersionMSLo { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_intSize.htm"/>
    public virtual int? intSize { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_lintProductId.htm"/>
    public virtual int lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_txtCertifiedBy.htm"/>
    public virtual string txtCertifiedBy { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_txtComments.htm"/>
    public virtual string txtComments { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_txtCompanyName.htm"/>
    public virtual string txtCompanyName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_txtExt.htm"/>
    public virtual string txtExt { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_txtFileDescription.htm"/>
    public virtual string txtFileDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_txtFileVersion.htm"/>
    public virtual string txtFileVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_txtInternalName.htm"/>
    public virtual string txtInternalName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_txtLegalCopyright.htm"/>
    public virtual string txtLegalCopyright { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_txtLegalTrademarks.htm"/>
    public virtual string txtLegalTrademarks { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_txtName.htm"/>
    public virtual string txtName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_txtOriginalFilename.htm"/>
    public virtual string txtOriginalFilename { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_txtPrivateBuild.htm"/>
    public virtual string txtPrivateBuild { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_txtProductName.htm"/>
    public virtual string txtProductName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_txtProductVersion.htm"/>
    public virtual string txtProductVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblFileImage_txtSpecialBuild.htm"/>
    public virtual string txtSpecialBuild { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblFileImage__ctor.htm"/>
    public tblFileImage() { }
}
