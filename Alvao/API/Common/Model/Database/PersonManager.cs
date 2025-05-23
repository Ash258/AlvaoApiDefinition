using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Pre-counted structure of managers and employees.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_PersonManager.htm"/>
[TableAttribute("dbo.PersonManager")]
public class PersonManager {
    /// <summary>Hierarchical distance of a user from his/her supervisor. Automatically calculated column. Direct manager = 1, manager of a direct manager = 2 etc.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_PersonManager_Distance.htm"/>
    public virtual int Distance { get; set; }
    /// <summary>Employee's ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_PersonManager_EmployeePersonId.htm"/>
    public virtual int EmployeePersonId { get; set; }
    /// <summary>Manager's ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_PersonManager_ManagerPersonId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int ManagerPersonId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_PersonManager__ctor.htm"/>
    public PersonManager() { }
}
