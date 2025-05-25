using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detection method (e.g. without Agent, autonomous Agent, ...)</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetectMethod.html"/>
[Table("dbo.DetectMethod")]
public class DetectMethod {
    /// <summary>Behavior from the system perspective: 0=Custom detection method, 1=Automatically, 2=Autonomous Agent, 3=Without Agent, 4=Agent over TCP/IP, 6=MS SCCM, 7=Manually</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetectMethod.html#Alvao_API_Common_Model_Database_DetectMethod_BehaviorId"/>
    public virtual int BehaviorId { get; set; }
    /// <summary>Field for user data, usually identifier of the custom detection method.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetectMethod.html#Alvao_API_Common_Model_Database_DetectMethod_Custom1"/>
    public virtual string Custom1 { get; set; }
    /// <summary>Name of the detection method.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetectMethod.html#Alvao_API_Common_Model_Database_DetectMethod_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetectMethod.html#Alvao_API_Common_Model_Database_DetectMethod_id"/>
    [ExplicitKey]
    public virtual int id { get; set; }
}
