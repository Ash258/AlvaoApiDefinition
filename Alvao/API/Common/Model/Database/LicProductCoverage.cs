using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Which of all products have license coverage.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicProductCoverage.html"/>
[Table("dbo.LicProductCoverage")]
public class LicProductCoverage {
    /// <summary>License ID - tblListHist</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicProductCoverage.html#Alvao_API_Common_Model_Database_LicProductCoverage_LicHistId"/>
    /// <remarks>Column <c>LicHistId</c>: int, not null. References <see cref="tblLicHist"/>.</remarks>
    [ExplicitKey]
    public virtual int LicHistId { get; set; }
    /// <summary>Product ID - tblProduct</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicProductCoverage.html#Alvao_API_Common_Model_Database_LicProductCoverage_ProductId"/>
    /// <remarks>Column <c>ProductId</c>: int, not null. References <see cref="tblProduct"/>.</remarks>
    [ExplicitKey]
    public virtual int ProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicProductCoverage.html#Alvao_API_Common_Model_Database_LicProductCoverage_ProductPackId"/>
    /// <remarks>Column <c>ProductPackId</c>: int, null. References <see cref="tblProduct"/>.</remarks>
    public virtual int? ProductPackId { get; set; }
}
