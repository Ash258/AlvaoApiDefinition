using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Rights in the object tree to groups / users.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblUserNodeRight.html"/>
[Table("dbo.tblUserNodeRight")]
public class tblUserNodeRight {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblUserNodeRight.html#Alvao_API_Common_Model_Database_tblUserNodeRight_CreateObj"/>
    public virtual bool? CreateObj { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblUserNodeRight.html#Alvao_API_Common_Model_Database_tblUserNodeRight_bolDelete"/>
    public virtual bool? bolDelete { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblUserNodeRight.html#Alvao_API_Common_Model_Database_tblUserNodeRight_bolMove"/>
    public virtual bool? bolMove { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblUserNodeRight.html#Alvao_API_Common_Model_Database_tblUserNodeRight_bolRead"/>
    public virtual bool? bolRead { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblUserNodeRight.html#Alvao_API_Common_Model_Database_tblUserNodeRight_bolRecursive"/>
    public virtual bool bolRecursive { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblUserNodeRight.html#Alvao_API_Common_Model_Database_tblUserNodeRight_bolWrite"/>
    public virtual bool? bolWrite { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblUserNodeRight.html#Alvao_API_Common_Model_Database_tblUserNodeRight_intUserNodeRightId"/>
    [Key]
    public virtual int intUserNodeRightId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblUserNodeRight.html#Alvao_API_Common_Model_Database_tblUserNodeRight_liPersonId"/>
    public virtual int? liPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblUserNodeRight.html#Alvao_API_Common_Model_Database_tblUserNodeRight_liRoleId"/>
    public virtual int? liRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblUserNodeRight.html#Alvao_API_Common_Model_Database_tblUserNodeRight_lintClassId"/>
    public virtual int? lintClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblUserNodeRight.html#Alvao_API_Common_Model_Database_tblUserNodeRight_lintNodeId"/>
    public virtual int? lintNodeId { get; set; }
}
