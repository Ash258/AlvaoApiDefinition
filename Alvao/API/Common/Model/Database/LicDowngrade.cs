using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>License - downgrade.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_LicDowngrade.htm"/>
[TableAttribute("dbo.LicDowngrade")]
public class LicDowngrade {
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicDowngrade_Desc.htm"/>
    public virtual string Desc { get; set; }
    /// <summary>License ID - tblListHist</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicDowngrade_LicHistId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int LicHistId { get; set; }
    /// <summary>Product ID - tblProduct</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicDowngrade_ProductId.htm"/>
    public virtual int ProductId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_LicDowngrade__ctor.htm"/>
    public LicDowngrade() { }
}
