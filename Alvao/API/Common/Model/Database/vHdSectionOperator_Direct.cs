using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Effective main solvers without absentee stand-ins.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionOperator_Direct.html"/>
[Table("dbo.vHdSectionOperator_Direct")]
public class vHdSectionOperator_Direct {
    /// <summary>Link to the group of requesters for which the permission for the given person is valid.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionOperator_Direct.html#Alvao_API_Common_Model_Database_vHdSectionOperator_Direct_RequesterRoleId"/>
    public virtual int RequesterRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionOperator_Direct.html#Alvao_API_Common_Model_Database_vHdSectionOperator_Direct_liHdSectionOperatorHdSectionId"/>
    public virtual int liHdSectionOperatorHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionOperator_Direct.html#Alvao_API_Common_Model_Database_vHdSectionOperator_Direct_liHdSectionOperatorPersonId"/>
    public virtual int? liHdSectionOperatorPersonId { get; set; }
}
