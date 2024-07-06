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
    public virtual bool? _Update { get; set; }
    /// <summary>Period of automatic detection planning</summary>
    public virtual int? DetectPeriod { get; set; }
    /// <summary>Full SW detection.</summary>
    public virtual bool? IsSwFull { get; set; }
    /// <summary>Type of detection. 1=HW, 2=SW.</summary>
    public virtual int? KindId { get; set; }
    /// <summary>Detection method ID.</summary>
    public virtual int? MethodId { get; set; }
    /// <summary>Computer ID.</summary>
    public virtual int NodeId { get; set; }
    /// <summary>Path to the shared folder</summary>
    public virtual string SharePath { get; set; }
    /// <summary>Full SW detection, skip files.</summary>
    public virtual string SwExclude { get; set; }
    /// <summary>Full SW detection, include files.</summary>
    public virtual string SwInclude { get; set; }
    /// <summary>Agent port number during detection by Agent over TCP/IP.</summary>
    public virtual int? TcpIpPort { get; set; }

    public vDetectSettings() { }
}
