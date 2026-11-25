using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Measured operations in applications<br/><br/>!!!CAUTION: This class is not part of the API documentation. It was
/// generated from the database documentation
/// </summary>
/// <see href="https://doc.alvao.com/en/26/admin-guide/customization/alvao-database/tables/#U_Perf.AppOperation"/>
[Table("Perf.AppOperation")]
public class AppOperation {
    /// <summary>Operation identifier</summary>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    public virtual int id { get; set; }
    /// <summary>Operation name</summary>
    /// <remarks>Column <c>AppOperation</c>: nvarchar(255), null.</remarks>
    public virtual string AppOperationValue { get; set; }
}
