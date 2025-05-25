using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>License - downgrade.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicDowngrade.html"/>
[Table("dbo.LicDowngrade")]
public class LicDowngrade {
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicDowngrade.html#Alvao_API_Common_Model_Database_LicDowngrade_Desc"/>
    public virtual string Desc { get; set; }
    /// <summary>License ID - tblListHist</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicDowngrade.html#Alvao_API_Common_Model_Database_LicDowngrade_LicHistId"/>
    [ExplicitKey]
    public virtual int LicHistId { get; set; }
    /// <summary>Product ID - tblProduct</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicDowngrade.html#Alvao_API_Common_Model_Database_LicDowngrade_ProductId"/>
    public virtual int ProductId { get; set; }
}
