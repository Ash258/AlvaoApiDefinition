using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Rights in the object tree to groups / users.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblUserNodeRight.htm"/>
[TableAttribute("dbo.tblUserNodeRight")]
public class tblUserNodeRight
{
    public virtual bool? bolDelete { get; set; }
    public virtual bool? bolMove { get; set; }
    public virtual bool? bolRead { get; set; }
    public virtual bool bolRecursive { get; set; }
    public virtual bool? bolWrite { get; set; }
    public virtual bool? CreateObj { get; set; }
    [KeyAttribute]
    public virtual int intUserNodeRightId { get; set; }
    public virtual int? lintClassId { get; set; }
    public virtual int? lintNodeId { get; set; }
    public virtual int? liPersonId { get; set; }
    public virtual int? liRoleId { get; set; }

    public tblUserNodeRight() { }
}
