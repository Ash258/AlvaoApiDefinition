using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>"CAL/Licensing" list, i.e. per device, per user, etc.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_LicKind.htm"/>
[TableAttribute("dbo.LicKind")]
public class LicKind {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicKind__LicKind.htm"/>
    public virtual string _LicKind { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicKind_id.htm"/>
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_LicKind__ctor.htm"/>
    public LicKind() { }
}
