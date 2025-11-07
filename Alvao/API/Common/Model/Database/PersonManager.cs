using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Pre-counted structure of managers and employees.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonManager.html"/>
[Table("dbo.PersonManager")]
public class PersonManager {
    /// <summary>Hierarchical distance of a user from his/her manager. Automatically calculated column. Direct manager = 1, manager of a direct manager = 2 etc.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonManager.html#Alvao_API_Common_Model_Database_PersonManager_Distance"/>
    public virtual int Distance { get; set; }
    /// <summary>Employee's ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonManager.html#Alvao_API_Common_Model_Database_PersonManager_EmployeePersonId"/>
    public virtual int EmployeePersonId { get; set; }
    /// <summary>Manager's ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonManager.html#Alvao_API_Common_Model_Database_PersonManager_ManagerPersonId"/>
    [ExplicitKey]
    public virtual int ManagerPersonId { get; set; }
}
