using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// License custom fields values.<br/><br/>!!!CAUTION: This class is not part of the API documentation. It was generated
/// from the database documentation
/// </summary>
/// <see href="https://doc.alvao.com/en/26/admin-guide/customization/alvao-database/tables/#U_dbo.LicHistCust"/>
[Table("dbo.LicHistCust")]
public class LicHistCust {
    /// <remarks>Column <c>LicHistId</c>: int, null. References <see cref="tblLicHist"/>.</remarks>
    public virtual int? LicHistId { get; set; }
}
