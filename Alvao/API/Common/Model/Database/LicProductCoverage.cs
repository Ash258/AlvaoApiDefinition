using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Which of all products have license coverage.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_LicProductCoverage.htm"/>
[TableAttribute("dbo.LicProductCoverage")]
public class LicProductCoverage
{
    /// <summary>License ID - tblListHist</summary>
    [ExplicitKeyAttribute]
    public virtual int LicHistId { get; set; }
    /// <summary>Product ID - tblProduct</summary>
    public virtual int ProductId { get; set; }
    public virtual int? ProductPackId { get; set; }

    public LicProductCoverage() { }
}
