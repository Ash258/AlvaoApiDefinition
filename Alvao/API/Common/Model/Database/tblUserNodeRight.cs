using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Rights in the object tree to groups / users.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblUserNodeRight.htm"/>
[TableAttribute("dbo.tblUserNodeRight")]
public class tblUserNodeRight {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblUserNodeRight_bolDelete.htm"/>
    public virtual bool? bolDelete { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblUserNodeRight_bolMove.htm"/>
    public virtual bool? bolMove { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblUserNodeRight_bolRead.htm"/>
    public virtual bool? bolRead { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblUserNodeRight_bolRecursive.htm"/>
    public virtual bool bolRecursive { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblUserNodeRight_bolWrite.htm"/>
    public virtual bool? bolWrite { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblUserNodeRight_CreateObj.htm"/>
    public virtual bool? CreateObj { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblUserNodeRight_intUserNodeRightId.htm"/>
    [KeyAttribute]
    public virtual int intUserNodeRightId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblUserNodeRight_lintClassId.htm"/>
    public virtual int? lintClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblUserNodeRight_lintNodeId.htm"/>
    public virtual int? lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblUserNodeRight_liPersonId.htm"/>
    public virtual int? liPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblUserNodeRight_liRoleId.htm"/>
    public virtual int? liRoleId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblUserNodeRight__ctor.htm"/>
    public tblUserNodeRight() { }
}
