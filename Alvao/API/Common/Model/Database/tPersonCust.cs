using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Persons in the ALVAO system - own items.<br/><br/>!!!CAUTION: This class is not part of the API documentation. It
/// was generated from the database documentation
/// </summary>
/// <see href="https://doc.alvao.com/en/26/admin-guide/customization/alvao-database/tables/#U_dbo.tPersonCust"/>
[Table("dbo.tPersonCust")]
public class tPersonCust {
    /// <remarks>Column <c>liPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? liPersonId { get; set; }
}
