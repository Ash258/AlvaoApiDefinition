using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Which of all products have license coverage.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_LicProductCoverage.htm"/>
[TableAttribute("dbo.LicProductCoverage")]
public class LicProductCoverage {
    /// <summary>License ID - tblListHist</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicProductCoverage_LicHistId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int LicHistId { get; set; }
    /// <summary>Product ID - tblProduct</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicProductCoverage_ProductId.htm"/>
    public virtual int ProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicProductCoverage_ProductPackId.htm"/>
    public virtual int? ProductPackId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_LicProductCoverage__ctor.htm"/>
    public LicProductCoverage() { }
}
