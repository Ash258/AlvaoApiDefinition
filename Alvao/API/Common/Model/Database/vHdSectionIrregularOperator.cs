using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Effective exceptional operators in services.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionIrregularOperator.html"/>
[Table("dbo.vHdSectionIrregularOperator")]
public class vHdSectionIrregularOperator {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionIrregularOperator.html#Alvao_API_Common_Model_Database_vHdSectionIrregularOperator_PersonId"/>
    public virtual int? PersonId { get; set; }
    /// <summary>Link to the group of requesters for which the permission for the given person is valid.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionIrregularOperator.html#Alvao_API_Common_Model_Database_vHdSectionIrregularOperator_RequesterRoleId"/>
    public virtual int RequesterRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionIrregularOperator.html#Alvao_API_Common_Model_Database_vHdSectionIrregularOperator_SectionId"/>
    public virtual int SectionId { get; set; }
}
