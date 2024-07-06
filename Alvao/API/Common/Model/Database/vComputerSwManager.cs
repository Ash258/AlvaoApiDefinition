using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// People and their superiors responsible for software installed on the computer
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vComputerSwManager.htm"/>
[TableAttribute("dbo.vComputerSwManager")]
public class vComputerSwManager
{
    public virtual int? ComputerId { get; set; }
    public virtual int? SwManagerPersonId { get; set; }
    public virtual int? SwManagerSuperiorId { get; set; }

    public vComputerSwManager() { }
}
