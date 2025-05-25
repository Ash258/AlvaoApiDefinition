using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detection profiles</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetectProfile.html"/>
[Table("dbo.DetectProfile")]
public class DetectProfile {
    /// <summary>Default profile</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetectProfile.html#Alvao_API_Common_Model_Database_DetectProfile_DefaultProfile"/>
    public virtual bool DefaultProfile { get; set; }
    /// <summary>Period of automatic detection planning</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetectProfile.html#Alvao_API_Common_Model_Database_DetectProfile_DetectPeriod"/>
    public virtual int? DetectPeriod { get; set; }
    /// <summary>HW detection method ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetectProfile.html#Alvao_API_Common_Model_Database_DetectProfile_HwMethodId"/>
    public virtual int? HwMethodId { get; set; }
    /// <summary>HW detection agent port number during detection by Agent over TCP/IP</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetectProfile.html#Alvao_API_Common_Model_Database_DetectProfile_HwTcpIpPort"/>
    public virtual int? HwTcpIpPort { get; set; }
    /// <summary>Profile name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetectProfile.html#Alvao_API_Common_Model_Database_DetectProfile_ProfileName"/>
    public virtual string ProfileName { get; set; }
    /// <summary>Full SW detection, skip files</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetectProfile.html#Alvao_API_Common_Model_Database_DetectProfile_SwExcludeFiles"/>
    public virtual string SwExcludeFiles { get; set; }
    /// <summary>Full SW detection, include files</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetectProfile.html#Alvao_API_Common_Model_Database_DetectProfile_SwIncludeFiles"/>
    public virtual string SwIncludeFiles { get; set; }
    /// <summary>Full SW detection</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetectProfile.html#Alvao_API_Common_Model_Database_DetectProfile_SwIsFull"/>
    public virtual bool SwIsFull { get; set; }
    /// <summary>SW detection method ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetectProfile.html#Alvao_API_Common_Model_Database_DetectProfile_SwMethodId"/>
    public virtual int? SwMethodId { get; set; }
    /// <summary>SW detection agent port number during detection by Agent over TCP/IP</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetectProfile.html#Alvao_API_Common_Model_Database_DetectProfile_SwTcpIpPort"/>
    public virtual int? SwTcpIpPort { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetectProfile.html#Alvao_API_Common_Model_Database_DetectProfile_id"/>
    [Key]
    public virtual int id { get; set; }
}
