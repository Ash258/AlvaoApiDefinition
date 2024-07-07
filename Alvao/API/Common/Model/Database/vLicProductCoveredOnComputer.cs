using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Which products on the computer have license coverage (per device or per user).
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vLicProductCoveredOnComputer.htm"/>
[TableAttribute("dbo.vLicProductCoveredOnComputer")]
public class vLicProductCoveredOnComputer
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicProductCoveredOnComputer_ComputerId.htm"/>
    public virtual int? ComputerId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicProductCoveredOnComputer_LicHistId.htm"/>
    public virtual int LicHistId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicProductCoveredOnComputer_ProductId.htm"/>
    public virtual int ProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicProductCoveredOnComputer_ProductPackId.htm"/>
    public virtual int? ProductPackId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLicProductCoveredOnComputer_UserId.htm"/>
    public virtual int? UserId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vLicProductCoveredOnComputer__ctor.htm"/>
    public vLicProductCoveredOnComputer() { }
}
