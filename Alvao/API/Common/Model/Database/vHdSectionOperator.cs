using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Effective service operators.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vHdSectionOperator.htm"/>
[TableAttribute("dbo.vHdSectionOperator")]
public class vHdSectionOperator
{
    /// <summary>Service ID.</summary>
    public virtual int HdSectionId { get; set; }
    /// <summary>User ID.</summary>
    public virtual int PersonId { get; set; }
    /// <summary>ID of the group of requesters associated with the permissions (mapping of requesters to the solver team).</summary>
    public virtual int RequesterRoleId { get; set; }

    public vHdSectionOperator() { }
}
