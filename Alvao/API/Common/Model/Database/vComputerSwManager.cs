using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>People and their superiors responsible for software installed on the computer</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputerSwManager.html"/>
[Table("dbo.vComputerSwManager")]
public class vComputerSwManager {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputerSwManager.html#Alvao_API_Common_Model_Database_vComputerSwManager_ComputerId"/>
    public virtual int? ComputerId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputerSwManager.html#Alvao_API_Common_Model_Database_vComputerSwManager_SwManagerPersonId"/>
    public virtual int? SwManagerPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputerSwManager.html#Alvao_API_Common_Model_Database_vComputerSwManager_SwManagerSuperiorId"/>
    public virtual int? SwManagerSuperiorId { get; set; }
}
