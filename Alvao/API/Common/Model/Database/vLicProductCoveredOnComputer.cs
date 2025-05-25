using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Which products on the computer have license coverage (per device or per user).</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicProductCoveredOnComputer.html"/>
[Table("dbo.vLicProductCoveredOnComputer")]
public class vLicProductCoveredOnComputer {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicProductCoveredOnComputer.html#Alvao_API_Common_Model_Database_vLicProductCoveredOnComputer_ComputerId"/>
    public virtual int? ComputerId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicProductCoveredOnComputer.html#Alvao_API_Common_Model_Database_vLicProductCoveredOnComputer_LicHistId"/>
    public virtual int LicHistId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicProductCoveredOnComputer.html#Alvao_API_Common_Model_Database_vLicProductCoveredOnComputer_ProductId"/>
    public virtual int ProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicProductCoveredOnComputer.html#Alvao_API_Common_Model_Database_vLicProductCoveredOnComputer_ProductPackId"/>
    public virtual int? ProductPackId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLicProductCoveredOnComputer.html#Alvao_API_Common_Model_Database_vLicProductCoveredOnComputer_UserId"/>
    public virtual int? UserId { get; set; }
}
