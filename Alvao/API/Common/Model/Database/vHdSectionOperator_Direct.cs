using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Effective main solvers without absentee stand-ins.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vHdSectionOperator_Direct.htm"/>
[TableAttribute("dbo.vHdSectionOperator_Direct")]
public class vHdSectionOperator_Direct
{
    public virtual int liHdSectionOperatorHdSectionId { get; set; }
    public virtual int? liHdSectionOperatorPersonId { get; set; }
    /// <summary>Link to the group of requesters for which the permission for the given person is valid.</summary>
    public virtual int RequesterRoleId { get; set; }

    public vHdSectionOperator_Direct() { }
}
