using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Rights in the object tree - users (including the rights allowed / prohibited by membership in roles).</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vUserNodeRight.htm"/>
[TableAttribute("dbo.vUserNodeRight")]
public class vUserNodeRight
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vUserNodeRight_bolDelete.htm"/>
    public virtual bool? bolDelete { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vUserNodeRight_bolMove.htm"/>
    public virtual bool? bolMove { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vUserNodeRight_bolRead.htm"/>
    public virtual bool? bolRead { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vUserNodeRight_bolRecursive.htm"/>
    public virtual bool bolRecursive { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vUserNodeRight_bolWrite.htm"/>
    public virtual bool? bolWrite { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vUserNodeRight_CreateObj.htm"/>
    public virtual bool? CreateObj { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vUserNodeRight_lintClassId.htm"/>
    public virtual int? lintClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vUserNodeRight_lintNodeId.htm"/>
    public virtual int? lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vUserNodeRight_liPersonId.htm"/>
    public virtual int? liPersonId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vUserNodeRight__ctor.htm"/>
    public vUserNodeRight() { }
}
