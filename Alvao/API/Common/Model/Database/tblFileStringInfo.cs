using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Information on detected files - texts.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblFileStringInfo.htm"/>
[TableAttribute("dbo.tblFileStringInfo")]
public class tblFileStringInfo
{
    public virtual int? intCodePage { get; set; }
    public virtual int? intLanguage { get; set; }
    [ExplicitKeyAttribute]
    public virtual int lintFileId { get; set; }
    public virtual string txtComments { get; set; }
    public virtual string txtCompanyName { get; set; }
    public virtual string txtFileDescription { get; set; }
    public virtual string txtFileVersion { get; set; }
    public virtual string txtInternalName { get; set; }
    public virtual string txtLegalCopyright { get; set; }
    public virtual string txtLegalTrademarks { get; set; }
    public virtual string txtOriginalFilename { get; set; }
    public virtual string txtPrivateBuild { get; set; }
    public virtual string txtProductName { get; set; }
    public virtual string txtProductVersion { get; set; }
    public virtual string txtSpecialBuild { get; set; }

    public tblFileStringInfo() { }
}
