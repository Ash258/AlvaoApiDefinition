using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detection profiles</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_DetectProfile.htm"/>
[TableAttribute("dbo.DetectProfile")]
public class DetectProfile {
    /// <summary>Default profile</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetectProfile_DefaultProfile.htm"/>
    public virtual bool DefaultProfile { get; set; }
    /// <summary>Period of automatic detection planning</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetectProfile_DetectPeriod.htm"/>
    public virtual int? DetectPeriod { get; set; }
    /// <summary>HW detection method ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetectProfile_HwMethodId.htm"/>
    public virtual int? HwMethodId { get; set; }
    /// <summary>Path to the shared folder of HW detection</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetectProfile_HwSharePath.htm"/>
    public virtual string HwSharePath { get; set; }
    /// <summary>HW detection agent port number during detection by Agent over TCP/IP</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetectProfile_HwTcpIpPort.htm"/>
    public virtual int? HwTcpIpPort { get; set; }
    /// <summary>Update objects in the tree automatically according to HW detection</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetectProfile_HwUpdateObjects.htm"/>
    public virtual bool HwUpdateObjects { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetectProfile_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Profile name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetectProfile_ProfileName.htm"/>
    public virtual string ProfileName { get; set; }
    /// <summary>Full SW detection, skip files</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetectProfile_SwExcludeFiles.htm"/>
    public virtual string SwExcludeFiles { get; set; }
    /// <summary>Full SW detection, include files</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetectProfile_SwIncludeFiles.htm"/>
    public virtual string SwIncludeFiles { get; set; }
    /// <summary>Full SW detection</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetectProfile_SwIsFull.htm"/>
    public virtual bool SwIsFull { get; set; }
    /// <summary>SW detection method ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetectProfile_SwMethodId.htm"/>
    public virtual int? SwMethodId { get; set; }
    /// <summary>Path to the shared folder of SW detection</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetectProfile_SwSharePath.htm"/>
    public virtual string SwSharePath { get; set; }
    /// <summary>SW detection agent port number during detection by Agent over TCP/IP</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetectProfile_SwTcpIpPort.htm"/>
    public virtual int? SwTcpIpPort { get; set; }
    /// <summary>Update Installation Registry automatically according to SW detection</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetectProfile_SwUpdateInstHist.htm"/>
    public virtual bool SwUpdateInstHist { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_DetectProfile__ctor.htm"/>
    public DetectProfile() { }
}
