using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detection profiles</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetectProfile.html"/>
[Table("dbo.DetectProfile")]
public class DetectProfile {
    /// <summary>Default profile</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetectProfile.html#Alvao_API_Common_Model_Database_DetectProfile_DefaultProfile"/>
    /// <remarks>Column <c>DefaultProfile</c>: bit, not null.</remarks>
    public virtual bool DefaultProfile { get; set; }
    /// <summary>Period of automatic detection planning</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetectProfile.html#Alvao_API_Common_Model_Database_DetectProfile_DetectPeriod"/>
    /// <remarks>Column <c>DetectPeriod</c>: int, null.</remarks>
    public virtual int? DetectPeriod { get; set; }
    /// <summary>HW detection method ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetectProfile.html#Alvao_API_Common_Model_Database_DetectProfile_HwMethodId"/>
    /// <remarks>Column <c>HwMethodId</c>: int, null. References <see cref="DetectMethod"/>.</remarks>
    public virtual int? HwMethodId { get; set; }
    /// <summary>Profile name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetectProfile.html#Alvao_API_Common_Model_Database_DetectProfile_ProfileName"/>
    /// <remarks>Column <c>ProfileName</c>: nvarchar(64), not null.</remarks>
    public virtual string ProfileName { get; set; }
    /// <summary>Full SW detection, skip files</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetectProfile.html#Alvao_API_Common_Model_Database_DetectProfile_SwExcludeFiles"/>
    /// <remarks>Column <c>SwExcludeFiles</c>: nvarchar(255), null.</remarks>
    public virtual string SwExcludeFiles { get; set; }
    /// <summary>Full SW detection, include files</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetectProfile.html#Alvao_API_Common_Model_Database_DetectProfile_SwIncludeFiles"/>
    /// <remarks>Column <c>SwIncludeFiles</c>: nvarchar(255), null.</remarks>
    public virtual string SwIncludeFiles { get; set; }
    /// <summary>Full SW detection</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetectProfile.html#Alvao_API_Common_Model_Database_DetectProfile_SwIsFull"/>
    /// <remarks>Column <c>SwIsFull</c>: bit, not null.</remarks>
    public virtual bool SwIsFull { get; set; }
    /// <summary>SW detection method ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetectProfile.html#Alvao_API_Common_Model_Database_DetectProfile_SwMethodId"/>
    /// <remarks>Column <c>SwMethodId</c>: int, null. References <see cref="DetectMethod"/>.</remarks>
    public virtual int? SwMethodId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetectProfile.html#Alvao_API_Common_Model_Database_DetectProfile_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
