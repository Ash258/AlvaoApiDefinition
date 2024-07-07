using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Information on which computer is executing the software products library update.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblSwLibUpdate.htm"/>
[TableAttribute("dbo.tblSwLibUpdate")]
public class tblSwLibUpdate
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblSwLibUpdate_dteUpdateStart.htm"/>
    public virtual DateTime? dteUpdateStart { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblSwLibUpdate_txtCollector.htm"/>
    [ExplicitKeyAttribute]
    public virtual string txtCollector { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblSwLibUpdate__ctor.htm"/>
    public tblSwLibUpdate() { }
}
