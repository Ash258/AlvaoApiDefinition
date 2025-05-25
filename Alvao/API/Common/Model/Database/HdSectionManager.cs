using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Effective service managers.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionManager.html"/>
[Table("dbo.HdSectionManager")]
public class HdSectionManager {
    /// <summary>ID of the service where the user is a manager.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionManager.html#Alvao_API_Common_Model_Database_HdSectionManager_HdSectionId"/>
    public virtual int HdSectionId { get; set; }
    /// <summary>User ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionManager.html#Alvao_API_Common_Model_Database_HdSectionManager_PersonId"/>
    public virtual int PersonId { get; set; }
    /// <summary>ID of the group of requesters associated with the permissions (mapping of requesters to the solver team).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionManager.html#Alvao_API_Common_Model_Database_HdSectionManager_RequesterRoleId"/>
    public virtual int RequesterRoleId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionManager.html#Alvao_API_Common_Model_Database_HdSectionManager_id"/>
    [Key]
    public virtual int id { get; set; }
}
