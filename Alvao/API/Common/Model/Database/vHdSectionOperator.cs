using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Effective service operators.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionOperator.html"/>
[Table("dbo.vHdSectionOperator")]
public class vHdSectionOperator {
    /// <summary>Service ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionOperator.html#Alvao_API_Common_Model_Database_vHdSectionOperator_HdSectionId"/>
    public virtual int HdSectionId { get; set; }
    /// <summary>User ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionOperator.html#Alvao_API_Common_Model_Database_vHdSectionOperator_PersonId"/>
    public virtual int PersonId { get; set; }
    /// <summary>ID of the group of requesters associated with the permissions (mapping of requesters to the solver team).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionOperator.html#Alvao_API_Common_Model_Database_vHdSectionOperator_RequesterRoleId"/>
    public virtual int RequesterRoleId { get; set; }
}
