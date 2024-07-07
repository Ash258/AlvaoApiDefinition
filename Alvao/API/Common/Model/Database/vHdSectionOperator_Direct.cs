using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Effective main solvers without absentee stand-ins.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vHdSectionOperator_Direct.htm"/>
[TableAttribute("dbo.vHdSectionOperator_Direct")]
public class vHdSectionOperator_Direct
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionOperator_Direct_liHdSectionOperatorHdSectionId.htm"/>
    public virtual int liHdSectionOperatorHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionOperator_Direct_liHdSectionOperatorPersonId.htm"/>
    public virtual int? liHdSectionOperatorPersonId { get; set; }
    /// <summary>Link to the group of requesters for which the permission for the given person is valid.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionOperator_Direct_RequesterRoleId.htm"/>
    public virtual int RequesterRoleId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vHdSectionOperator_Direct__ctor.htm"/>
    public vHdSectionOperator_Direct() { }
}
