using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Additional operation data in applications<br/><br/>!!!CAUTION: This class is not part of the API documentation. It
/// was generated from the database documentation
/// </summary>
/// <see href="https://doc.alvao.com/en/26/admin-guide/customization/alvao-database/tables/#U_Perf.AppOperationRecordData"/>
[Table("Perf.AppOperationRecordData")]
public class AppOperationRecordData {
    /// <summary>Data record identifier</summary>
    /// <remarks>Column <c>id</c>: bigint, not null.</remarks>
    public virtual long id { get; set; }
    /// <summary>
    /// Identifier of a record to which the data is related. A foreign key to the AppOperationRecord table.
    /// </summary>
    /// <remarks>
    /// Column <c>AppOperationRecordId</c>: bigint, not null. References <see cref="AppOperationRecord"/>.
    /// </remarks>
    public virtual long AppOperationRecordId { get; set; }
    /// <summary>Parameter name</summary>
    /// <remarks>Column <c>DataName</c>: nvarchar(255), null.</remarks>
    public virtual string DataName { get; set; }
    /// <summary>Parameter text value</summary>
    /// <remarks>Column <c>TextDataValue</c>: nvarchar(255), null.</remarks>
    public virtual string TextDataValue { get; set; }
    /// <summary>Integer parameter value</summary>
    /// <remarks>Column <c>IntDataValue</c>: int, null.</remarks>
    public virtual int? IntDataValue { get; set; }
    /// <summary>Real parameter value</summary>
    /// <remarks>Column <c>FloatDataValue</c>: float, null.</remarks>
    public virtual double? FloatDataValue { get; set; }
}
