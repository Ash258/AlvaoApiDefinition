using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Recognition rules for files (software products library).
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblFileImage.htm"/>
[TableAttribute("dbo.tblFileImage")]
public class tblFileImage
{
    public virtual bool bolProductKey { get; set; }
    public virtual bool bolValid { get; set; }
    public virtual DateTime dteTimeStamp { get; set; }
    public virtual int? intCodePage { get; set; }
    [KeyAttribute]
    public virtual int intFileImageId { get; set; }
    public virtual int intFileImageUID { get; set; }
    public virtual int? intFileVersionLSHi { get; set; }
    public virtual int? intFileVersionLSLo { get; set; }
    public virtual int? intFileVersionMSHi { get; set; }
    public virtual int? intFileVersionMSLo { get; set; }
    public virtual int? intFlags { get; set; }
    public virtual int? intLanguage { get; set; }
    public virtual int? intOrder { get; set; }
    public virtual int? intProductVersionLSHi { get; set; }
    public virtual int? intProductVersionLSLo { get; set; }
    public virtual int? intProductVersionMSHi { get; set; }
    public virtual int? intProductVersionMSLo { get; set; }
    public virtual int? intSize { get; set; }
    public virtual int lintProductId { get; set; }
    public virtual string txtCertifiedBy { get; set; }
    public virtual string txtComments { get; set; }
    public virtual string txtCompanyName { get; set; }
    public virtual string txtExt { get; set; }
    public virtual string txtFileDescription { get; set; }
    public virtual string txtFileVersion { get; set; }
    public virtual string txtInternalName { get; set; }
    public virtual string txtLegalCopyright { get; set; }
    public virtual string txtLegalTrademarks { get; set; }
    public virtual string txtName { get; set; }
    public virtual string txtOriginalFilename { get; set; }
    public virtual string txtPrivateBuild { get; set; }
    public virtual string txtProductName { get; set; }
    public virtual string txtProductVersion { get; set; }
    public virtual string txtSpecialBuild { get; set; }

    public tblFileImage() { }
}
