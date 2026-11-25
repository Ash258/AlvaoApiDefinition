using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// SLA custom fields values.<br/><br/>!!!CAUTION: This class is not part of the API documentation. It was generated
/// from the database documentation
/// </summary>
/// <see href="https://doc.alvao.com/en/26/admin-guide/customization/alvao-database/tables/#U_dbo.tSlaCust"/>
[Table("dbo.tSlaCust")]
public class tSlaCust {
    /// <remarks>Column <c>liSlaId</c>: int, null. References <see cref="tSla"/>.</remarks>
    public virtual int? liSlaId { get; set; }
}
