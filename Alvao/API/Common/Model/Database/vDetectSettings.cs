using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Computer detection settings.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vDetectSettings.htm"/>
[TableAttribute("dbo.vDetectSettings")]
public class vDetectSettings
{
    /// <summary>Update the registry automatically by detection.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetectSettings__Update.htm"/>
    public virtual bool? _Update { get; set; }
    /// <summary>Period of automatic detection planning</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetectSettings_DetectPeriod.htm"/>
    public virtual int? DetectPeriod { get; set; }
    /// <summary>Full SW detection.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetectSettings_IsSwFull.htm"/>
    public virtual bool? IsSwFull { get; set; }
    /// <summary>Type of detection. 1=HW, 2=SW.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetectSettings_KindId.htm"/>
    public virtual int? KindId { get; set; }
    /// <summary>Detection method ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetectSettings_MethodId.htm"/>
    public virtual int? MethodId { get; set; }
    /// <summary>Computer ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetectSettings_NodeId.htm"/>
    public virtual int NodeId { get; set; }
    /// <summary>Path to the shared folder</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetectSettings_SharePath.htm"/>
    public virtual string SharePath { get; set; }
    /// <summary>Full SW detection, skip files.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetectSettings_SwExclude.htm"/>
    public virtual string SwExclude { get; set; }
    /// <summary>Full SW detection, include files.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetectSettings_SwInclude.htm"/>
    public virtual string SwInclude { get; set; }
    /// <summary>Agent port number during detection by Agent over TCP/IP.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetectSettings_TcpIpPort.htm"/>
    public virtual int? TcpIpPort { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vDetectSettings__ctor.htm"/>
    public vDetectSettings() { }
}
