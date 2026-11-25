using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Rights in the object tree to groups / users.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblUserNodeRight.html"/>
[Table("dbo.tblUserNodeRight")]
public class tblUserNodeRight {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblUserNodeRight.html#Alvao_API_Common_Model_Database_tblUserNodeRight_CreateObj"/>
    /// <remarks>Column <c>CreateObj</c>: bit, null.</remarks>
    public virtual bool? CreateObj { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblUserNodeRight.html#Alvao_API_Common_Model_Database_tblUserNodeRight_bolDelete"/>
    /// <remarks>Column <c>bolDelete</c>: bit, null.</remarks>
    public virtual bool? bolDelete { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblUserNodeRight.html#Alvao_API_Common_Model_Database_tblUserNodeRight_bolMove"/>
    /// <remarks>Column <c>bolMove</c>: bit, null.</remarks>
    public virtual bool? bolMove { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblUserNodeRight.html#Alvao_API_Common_Model_Database_tblUserNodeRight_bolRead"/>
    /// <remarks>Column <c>bolRead</c>: bit, null.</remarks>
    public virtual bool? bolRead { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblUserNodeRight.html#Alvao_API_Common_Model_Database_tblUserNodeRight_bolRecursive"/>
    /// <remarks>Column <c>bolRecursive</c>: bit, not null.</remarks>
    public virtual bool bolRecursive { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblUserNodeRight.html#Alvao_API_Common_Model_Database_tblUserNodeRight_bolWrite"/>
    /// <remarks>Column <c>bolWrite</c>: bit, null.</remarks>
    public virtual bool? bolWrite { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblUserNodeRight.html#Alvao_API_Common_Model_Database_tblUserNodeRight_intUserNodeRightId"/>
    /// <remarks>Column <c>intUserNodeRightId</c>: int, not null.</remarks>
    [Key]
    public virtual int intUserNodeRightId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblUserNodeRight.html#Alvao_API_Common_Model_Database_tblUserNodeRight_liPersonId"/>
    /// <remarks>Column <c>liPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? liPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblUserNodeRight.html#Alvao_API_Common_Model_Database_tblUserNodeRight_liRoleId"/>
    /// <remarks>Column <c>liRoleId</c>: int, null. References <see cref="tRole"/>.</remarks>
    public virtual int? liRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblUserNodeRight.html#Alvao_API_Common_Model_Database_tblUserNodeRight_lintClassId"/>
    /// <remarks>Column <c>lintClassId</c>: int, null. References <see cref="tblClass"/>.</remarks>
    public virtual int? lintClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblUserNodeRight.html#Alvao_API_Common_Model_Database_tblUserNodeRight_lintNodeId"/>
    /// <remarks>Column <c>lintNodeId</c>: int, null. References <see cref="tblNode"/>.</remarks>
    public virtual int? lintNodeId { get; set; }
}
