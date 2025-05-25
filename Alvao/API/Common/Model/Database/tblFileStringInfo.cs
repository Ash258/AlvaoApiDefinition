using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Information on detected files - texts.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html"/>
[Table("dbo.tblFileStringInfo")]
public class tblFileStringInfo {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_intCodePage"/>
    public virtual int? intCodePage { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_intLanguage"/>
    public virtual int? intLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_lintFileId"/>
    [ExplicitKey]
    public virtual int lintFileId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_txtComments"/>
    public virtual string txtComments { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_txtCompanyName"/>
    public virtual string txtCompanyName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_txtFileDescription"/>
    public virtual string txtFileDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_txtFileVersion"/>
    public virtual string txtFileVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_txtInternalName"/>
    public virtual string txtInternalName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_txtLegalCopyright"/>
    public virtual string txtLegalCopyright { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_txtLegalTrademarks"/>
    public virtual string txtLegalTrademarks { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_txtOriginalFilename"/>
    public virtual string txtOriginalFilename { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_txtPrivateBuild"/>
    public virtual string txtPrivateBuild { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_txtProductName"/>
    public virtual string txtProductName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_txtProductVersion"/>
    public virtual string txtProductVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_txtSpecialBuild"/>
    public virtual string txtSpecialBuild { get; set; }
}
