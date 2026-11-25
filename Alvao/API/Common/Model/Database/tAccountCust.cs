using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Organization custom fields values.<br/><br/>!!!CAUTION: This class is not part of the API documentation. It was
/// generated from the database documentation
/// </summary>
/// <see href="https://doc.alvao.com/en/26/admin-guide/customization/alvao-database/tables/#U_dbo.tAccountCust"/>
[Table("dbo.tAccountCust")]
public class tAccountCust {
    /// <remarks>Column <c>liAccountId</c>: int, null. References <see cref="tAccount"/>.</remarks>
    public virtual int? liAccountId { get; set; }
}
