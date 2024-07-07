using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// People and their superiors responsible for software installed on the computer
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vComputerSwManager.htm"/>
[TableAttribute("dbo.vComputerSwManager")]
public class vComputerSwManager
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputerSwManager_ComputerId.htm"/>
    public virtual int? ComputerId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputerSwManager_SwManagerPersonId.htm"/>
    public virtual int? SwManagerPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputerSwManager_SwManagerSuperiorId.htm"/>
    public virtual int? SwManagerSuperiorId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vComputerSwManager__ctor.htm"/>
    public vComputerSwManager() { }
}
