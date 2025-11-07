using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Computer detection settings.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetectSettings.html"/>
[Table("dbo.vDetectSettings")]
public class vDetectSettings {
    /// <summary>Period of automatic detection planning</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetectSettings.html#Alvao_API_Common_Model_Database_vDetectSettings_DetectPeriod"/>
    public virtual int? DetectPeriod { get; set; }
    /// <summary>Full SW detection.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetectSettings.html#Alvao_API_Common_Model_Database_vDetectSettings_IsSwFull"/>
    public virtual bool? IsSwFull { get; set; }
    /// <summary>Type of detection. 1=HW, 2=SW.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetectSettings.html#Alvao_API_Common_Model_Database_vDetectSettings_KindId"/>
    public virtual int? KindId { get; set; }
    /// <summary>Detection method ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetectSettings.html#Alvao_API_Common_Model_Database_vDetectSettings_MethodId"/>
    public virtual int? MethodId { get; set; }
    /// <summary>Computer ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetectSettings.html#Alvao_API_Common_Model_Database_vDetectSettings_NodeId"/>
    public virtual int NodeId { get; set; }
    /// <summary>Full SW detection, skip files.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetectSettings.html#Alvao_API_Common_Model_Database_vDetectSettings_SwExclude"/>
    public virtual string SwExclude { get; set; }
    /// <summary>Full SW detection, include files.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetectSettings.html#Alvao_API_Common_Model_Database_vDetectSettings_SwInclude"/>
    public virtual string SwInclude { get; set; }
}
