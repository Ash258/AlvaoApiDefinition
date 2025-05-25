using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Rights in the object tree - users (including the rights allowed / prohibited by membership in roles).</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vUserNodeRight.html"/>
[Table("dbo.vUserNodeRight")]
public class vUserNodeRight {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vUserNodeRight.html#Alvao_API_Common_Model_Database_vUserNodeRight_CreateObj"/>
    public virtual bool? CreateObj { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vUserNodeRight.html#Alvao_API_Common_Model_Database_vUserNodeRight_bolDelete"/>
    public virtual bool? bolDelete { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vUserNodeRight.html#Alvao_API_Common_Model_Database_vUserNodeRight_bolMove"/>
    public virtual bool? bolMove { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vUserNodeRight.html#Alvao_API_Common_Model_Database_vUserNodeRight_bolRead"/>
    public virtual bool? bolRead { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vUserNodeRight.html#Alvao_API_Common_Model_Database_vUserNodeRight_bolRecursive"/>
    public virtual bool bolRecursive { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vUserNodeRight.html#Alvao_API_Common_Model_Database_vUserNodeRight_bolWrite"/>
    public virtual bool? bolWrite { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vUserNodeRight.html#Alvao_API_Common_Model_Database_vUserNodeRight_liPersonId"/>
    public virtual int? liPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vUserNodeRight.html#Alvao_API_Common_Model_Database_vUserNodeRight_lintClassId"/>
    public virtual int? lintClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vUserNodeRight.html#Alvao_API_Common_Model_Database_vUserNodeRight_lintNodeId"/>
    public virtual int? lintNodeId { get; set; }
}
