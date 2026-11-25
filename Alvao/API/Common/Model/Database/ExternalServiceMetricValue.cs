using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Values of external service usages</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalServiceMetricValue.html"/>
[Table("dbo.ExternalServiceMetricValue")]
public class ExternalServiceMetricValue {
    /// <summary>Date of usage</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalServiceMetricValue.html#Alvao_API_Common_Model_Database_ExternalServiceMetricValue_Date"/>
    /// <remarks>Column <c>Date</c>: date, not null.</remarks>
    public virtual DateTime Date { get; set; }
    /// <summary>ID of external service metric</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalServiceMetricValue.html#Alvao_API_Common_Model_Database_ExternalServiceMetricValue_ExternalServiceMetricId"/>
    /// <remarks>
    /// Column <c>ExternalServiceMetricId</c>: int, not null. References <see cref="ExternalServiceMetric"/>.
    /// </remarks>
    public virtual int ExternalServiceMetricId { get; set; }
    /// <summary>ID of the usage</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalServiceMetricValue.html#Alvao_API_Common_Model_Database_ExternalServiceMetricValue_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Value of the usage for the date</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalServiceMetricValue.html#Alvao_API_Common_Model_Database_ExternalServiceMetricValue_IntValue"/>
    /// <remarks>Column <c>IntValue</c>: int, not null.</remarks>
    public virtual int IntValue { get; set; }
}
