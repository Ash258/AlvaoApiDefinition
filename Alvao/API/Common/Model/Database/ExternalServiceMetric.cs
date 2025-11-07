using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>External services metrics</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ExternalServiceMetric.html"/>
[Table("dbo.ExternalServiceMetric")]
public class ExternalServiceMetric {
    /// <summary>ID of external service</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ExternalServiceMetric.html#Alvao_API_Common_Model_Database_ExternalServiceMetric_ExternalServiceId"/>
    public virtual int ExternalServiceId { get; set; }
    /// <summary>Name of the feature</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ExternalServiceMetric.html#Alvao_API_Common_Model_Database_ExternalServiceMetric_Feature"/>
    public virtual string Feature { get; set; }
    /// <summary>Name of the group</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ExternalServiceMetric.html#Alvao_API_Common_Model_Database_ExternalServiceMetric_GroupName"/>
    public virtual string GroupName { get; set; }
    /// <summary>ID of external service metric</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ExternalServiceMetric.html#Alvao_API_Common_Model_Database_ExternalServiceMetric_Id"/>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Name of the metric</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ExternalServiceMetric.html#Alvao_API_Common_Model_Database_ExternalServiceMetric_MetricName"/>
    public virtual string MetricName { get; set; }
}
