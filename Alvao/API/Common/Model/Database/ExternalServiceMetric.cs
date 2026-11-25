using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>External services metrics</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalServiceMetric.html"/>
[Table("dbo.ExternalServiceMetric")]
public class ExternalServiceMetric {
    /// <summary>ID of external service</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalServiceMetric.html#Alvao_API_Common_Model_Database_ExternalServiceMetric_ExternalServiceId"/>
    /// <remarks>Column <c>ExternalServiceId</c>: int, not null. References <see cref="ExternalService"/>.</remarks>
    public virtual int ExternalServiceId { get; set; }
    /// <summary>Name of the feature</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalServiceMetric.html#Alvao_API_Common_Model_Database_ExternalServiceMetric_Feature"/>
    /// <remarks>Column <c>Feature</c>: nvarchar(255), null.</remarks>
    public virtual string Feature { get; set; }
    /// <summary>Name of the group</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalServiceMetric.html#Alvao_API_Common_Model_Database_ExternalServiceMetric_GroupName"/>
    /// <remarks>Column <c>GroupName</c>: nvarchar(255), null.</remarks>
    public virtual string GroupName { get; set; }
    /// <summary>ID of external service metric</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalServiceMetric.html#Alvao_API_Common_Model_Database_ExternalServiceMetric_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Name of the metric</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalServiceMetric.html#Alvao_API_Common_Model_Database_ExternalServiceMetric_MetricName"/>
    /// <remarks>Column <c>MetricName</c>: nvarchar(255), null.</remarks>
    public virtual string MetricName { get; set; }
}
