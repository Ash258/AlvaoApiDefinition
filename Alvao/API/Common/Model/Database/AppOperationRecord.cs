using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Operation responses in applications<br/><br/>!!!CAUTION: This class is not part of the API documentation. It was
/// generated from the database documentation
/// </summary>
/// <see href="https://doc.alvao.com/en/26/admin-guide/customization/alvao-database/tables/#U_Perf.AppOperationRecord"/>
[Table("Perf.AppOperationRecord")]
public class AppOperationRecord {
    /// <summary>Record identifier</summary>
    /// <remarks>Column <c>id</c>: bigint, not null.</remarks>
    public virtual long id { get; set; }
    /// <summary>Measured operation identifier. A foreign key to the AppOperation table.</summary>
    /// <remarks>Column <c>AppOperationId</c>: int, not null. References <see cref="AppOperation"/>.</remarks>
    public virtual int AppOperationId { get; set; }
    /// <summary>Operation start time</summary>
    /// <remarks>Column <c>OperationStart</c>: datetime, not null.</remarks>
    public virtual DateTime OperationStart { get; set; }
    /// <summary>Duration of the operation on the server in seconds</summary>
    /// <remarks>Column <c>ServerDurationSeconds</c>: float, null.</remarks>
    public virtual double? ServerDurationSeconds { get; set; }
    /// <summary>Duration of the operation in the client in seconds</summary>
    /// <remarks>Column <c>ClientDurationSeconds</c>: float, null.</remarks>
    public virtual double? ClientDurationSeconds { get; set; }
    /// <summary>User identifier of a person who performed the operation</summary>
    /// <remarks>Column <c>UserPersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int UserPersonId { get; set; }
}
