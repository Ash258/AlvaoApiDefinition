using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Detection profiles
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_DetectProfile.htm"/>
[TableAttribute("dbo.DetectProfile")]
public class DetectProfile
{
    /// <summary>Default profile</summary>
    public virtual bool DefaultProfile { get; set; }
    /// <summary>Period of automatic detection planning</summary>
    public virtual int? DetectPeriod { get; set; }
    /// <summary>HW detection method ID</summary>
    public virtual int? HwMethodId { get; set; }
    /// <summary>Path to the shared folder of HW detection</summary>
    public virtual string HwSharePath { get; set; }
    /// <summary>HW detection agent port number during detection by Agent over TCP/IP</summary>
    public virtual int? HwTcpIpPort { get; set; }
    /// <summary>Update objects in the tree automatically according to HW detection</summary>
    public virtual bool HwUpdateObjects { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Profile name</summary>
    public virtual string ProfileName { get; set; }
    /// <summary>Full SW detection, skip files</summary>
    public virtual string SwExcludeFiles { get; set; }
    /// <summary>Full SW detection, include files</summary>
    public virtual string SwIncludeFiles { get; set; }
    /// <summary>Full SW detection</summary>
    public virtual bool SwIsFull { get; set; }
    /// <summary>SW detection method ID</summary>
    public virtual int? SwMethodId { get; set; }
    /// <summary>Path to the shared folder of SW detection</summary>
    public virtual string SwSharePath { get; set; }
    /// <summary>SW detection agent port number during detection by Agent over TCP/IP</summary>
    public virtual int? SwTcpIpPort { get; set; }
    /// <summary>Update Installation Registry automatically according to SW detection</summary>
    public virtual bool SwUpdateInstHist { get; set; }

    public DetectProfile() { }
}
