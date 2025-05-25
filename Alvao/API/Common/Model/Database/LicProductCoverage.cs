using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Which of all products have license coverage.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicProductCoverage.html"/>
[Table("dbo.LicProductCoverage")]
public class LicProductCoverage {
    /// <summary>License ID - tblListHist</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicProductCoverage.html#Alvao_API_Common_Model_Database_LicProductCoverage_LicHistId"/>
    [ExplicitKey]
    public virtual int LicHistId { get; set; }
    /// <summary>Product ID - tblProduct</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicProductCoverage.html#Alvao_API_Common_Model_Database_LicProductCoverage_ProductId"/>
    public virtual int ProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicProductCoverage.html#Alvao_API_Common_Model_Database_LicProductCoverage_ProductPackId"/>
    public virtual int? ProductPackId { get; set; }
}
