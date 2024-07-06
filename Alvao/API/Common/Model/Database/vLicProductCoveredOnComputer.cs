using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Which products on the computer have license coverage (per device or per user).
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vLicProductCoveredOnComputer.htm"/>
[TableAttribute("dbo.vLicProductCoveredOnComputer")]
public class vLicProductCoveredOnComputer
{
    public virtual int? ComputerId { get; set; }
    public virtual int LicHistId { get; set; }
    public virtual int ProductId { get; set; }
    public virtual int? ProductPackId { get; set; }
    public virtual int? UserId { get; set; }

    public vLicProductCoveredOnComputer() { }
}
