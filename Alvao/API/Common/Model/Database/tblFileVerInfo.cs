using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Information on detected files - versions.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html"/>
[Table("dbo.tblFileVerInfo")]
public class tblFileVerInfo {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html#Alvao_API_Common_Model_Database_tblFileVerInfo_intFileDateLS"/>
    /// <remarks>Column <c>intFileDateLS</c>: int, null.</remarks>
    public virtual int? intFileDateLS { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html#Alvao_API_Common_Model_Database_tblFileVerInfo_intFileDateMS"/>
    /// <remarks>Column <c>intFileDateMS</c>: int, null.</remarks>
    public virtual int? intFileDateMS { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html#Alvao_API_Common_Model_Database_tblFileVerInfo_intFileFlags"/>
    /// <remarks>Column <c>intFileFlags</c>: int, null.</remarks>
    public virtual int? intFileFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html#Alvao_API_Common_Model_Database_tblFileVerInfo_intFileFlagsMask"/>
    /// <remarks>Column <c>intFileFlagsMask</c>: int, null.</remarks>
    public virtual int? intFileFlagsMask { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html#Alvao_API_Common_Model_Database_tblFileVerInfo_intFileOS"/>
    /// <remarks>Column <c>intFileOS</c>: int, null.</remarks>
    public virtual int? intFileOS { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html#Alvao_API_Common_Model_Database_tblFileVerInfo_intFileSubtype"/>
    /// <remarks>Column <c>intFileSubtype</c>: int, null.</remarks>
    public virtual int? intFileSubtype { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html#Alvao_API_Common_Model_Database_tblFileVerInfo_intFileType"/>
    /// <remarks>Column <c>intFileType</c>: int, null.</remarks>
    public virtual int? intFileType { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html#Alvao_API_Common_Model_Database_tblFileVerInfo_intFileVersionLS"/>
    /// <remarks>Column <c>intFileVersionLS</c>: int, null.</remarks>
    public virtual int? intFileVersionLS { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html#Alvao_API_Common_Model_Database_tblFileVerInfo_intFileVersionMS"/>
    /// <remarks>Column <c>intFileVersionMS</c>: int, null.</remarks>
    public virtual int? intFileVersionMS { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html#Alvao_API_Common_Model_Database_tblFileVerInfo_intProductVersionLS"/>
    /// <remarks>Column <c>intProductVersionLS</c>: int, null.</remarks>
    public virtual int? intProductVersionLS { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html#Alvao_API_Common_Model_Database_tblFileVerInfo_intProductVersionMS"/>
    /// <remarks>Column <c>intProductVersionMS</c>: int, null.</remarks>
    public virtual int? intProductVersionMS { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html#Alvao_API_Common_Model_Database_tblFileVerInfo_lintFileId"/>
    /// <remarks>Column <c>lintFileId</c>: int, not null. References <see cref="tblFile"/>.</remarks>
    [ExplicitKey]
    public virtual int lintFileId { get; set; }
}
