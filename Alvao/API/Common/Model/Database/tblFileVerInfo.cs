using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Information on detected files - versions.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html"/>
[Table("dbo.tblFileVerInfo")]
public class tblFileVerInfo {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html#Alvao_API_Common_Model_Database_tblFileVerInfo_intFileDateLS"/>
    public virtual int? intFileDateLS { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html#Alvao_API_Common_Model_Database_tblFileVerInfo_intFileDateMS"/>
    public virtual int? intFileDateMS { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html#Alvao_API_Common_Model_Database_tblFileVerInfo_intFileFlags"/>
    public virtual int? intFileFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html#Alvao_API_Common_Model_Database_tblFileVerInfo_intFileFlagsMask"/>
    public virtual int? intFileFlagsMask { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html#Alvao_API_Common_Model_Database_tblFileVerInfo_intFileOS"/>
    public virtual int? intFileOS { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html#Alvao_API_Common_Model_Database_tblFileVerInfo_intFileSubtype"/>
    public virtual int? intFileSubtype { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html#Alvao_API_Common_Model_Database_tblFileVerInfo_intFileType"/>
    public virtual int? intFileType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html#Alvao_API_Common_Model_Database_tblFileVerInfo_intFileVersionLS"/>
    public virtual int? intFileVersionLS { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html#Alvao_API_Common_Model_Database_tblFileVerInfo_intFileVersionMS"/>
    public virtual int? intFileVersionMS { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html#Alvao_API_Common_Model_Database_tblFileVerInfo_intProductVersionLS"/>
    public virtual int? intProductVersionLS { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html#Alvao_API_Common_Model_Database_tblFileVerInfo_intProductVersionMS"/>
    public virtual int? intProductVersionMS { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblFileVerInfo.html#Alvao_API_Common_Model_Database_tblFileVerInfo_lintFileId"/>
    [ExplicitKey]
    public virtual int lintFileId { get; set; }
}
