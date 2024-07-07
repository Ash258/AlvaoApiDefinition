using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Installed software, detected version and activation code.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vInstDetect.htm"/>
[TableAttribute("dbo.vInstDetect")]
public class vInstDetect
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vInstDetect_intDetectId.htm"/>
    public virtual int? intDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vInstDetect_lintComputerNodeId.htm"/>
    public virtual int lintComputerNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vInstDetect_lintProductId.htm"/>
    public virtual int? lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vInstDetect_txtDetCDKey.htm"/>
    public virtual string txtDetCDKey { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vInstDetect_txtProductVersion.htm"/>
    public virtual string txtProductVersion { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vInstDetect__ctor.htm"/>
    public vInstDetect() { }
}
