using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Information on detected files - texts.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html"/>
[Table("dbo.tblFileStringInfo")]
public class tblFileStringInfo {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_intCodePage"/>
    /// <remarks>Column <c>intCodePage</c>: int, null.</remarks>
    public virtual int? intCodePage { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_intLanguage"/>
    /// <remarks>Column <c>intLanguage</c>: int, null.</remarks>
    public virtual int? intLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_lintFileId"/>
    /// <remarks>Column <c>lintFileId</c>: int, not null. References <see cref="tblFile"/>.</remarks>
    [ExplicitKey]
    public virtual int lintFileId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_txtComments"/>
    /// <remarks>Column <c>txtComments</c>: nvarchar(255), null.</remarks>
    public virtual string txtComments { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_txtCompanyName"/>
    /// <remarks>Column <c>txtCompanyName</c>: nvarchar(255), null.</remarks>
    public virtual string txtCompanyName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_txtFileDescription"/>
    /// <remarks>Column <c>txtFileDescription</c>: nvarchar(255), null.</remarks>
    public virtual string txtFileDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_txtFileVersion"/>
    /// <remarks>Column <c>txtFileVersion</c>: nvarchar(255), null.</remarks>
    public virtual string txtFileVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_txtInternalName"/>
    /// <remarks>Column <c>txtInternalName</c>: nvarchar(255), null.</remarks>
    public virtual string txtInternalName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_txtLegalCopyright"/>
    /// <remarks>Column <c>txtLegalCopyright</c>: nvarchar(255), null.</remarks>
    public virtual string txtLegalCopyright { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_txtLegalTrademarks"/>
    /// <remarks>Column <c>txtLegalTrademarks</c>: nvarchar(255), null.</remarks>
    public virtual string txtLegalTrademarks { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_txtOriginalFilename"/>
    /// <remarks>Column <c>txtOriginalFilename</c>: nvarchar(255), null.</remarks>
    public virtual string txtOriginalFilename { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_txtPrivateBuild"/>
    /// <remarks>Column <c>txtPrivateBuild</c>: nvarchar(255), null.</remarks>
    public virtual string txtPrivateBuild { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_txtProductName"/>
    /// <remarks>Column <c>txtProductName</c>: nvarchar(255), null.</remarks>
    public virtual string txtProductName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_txtProductVersion"/>
    /// <remarks>Column <c>txtProductVersion</c>: nvarchar(255), null.</remarks>
    public virtual string txtProductVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileStringInfo.html#Alvao_API_Common_Model_Database_tblFileStringInfo_txtSpecialBuild"/>
    /// <remarks>Column <c>txtSpecialBuild</c>: nvarchar(255), null.</remarks>
    public virtual string txtSpecialBuild { get; set; }
}
