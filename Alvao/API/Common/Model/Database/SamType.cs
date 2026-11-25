using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>SAM notification type - Audit: yes, no, via email.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SamType.html"/>
[Table("dbo.SamType")]
public class SamType {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SamType.html#Alvao_API_Common_Model_Database_SamType_Desc"/>
    /// <remarks>Column <c>Desc</c>: nvarchar(256), null.</remarks>
    public virtual string Desc { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SamType.html#Alvao_API_Common_Model_Database_SamType_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(32), not null.</remarks>
    public virtual string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SamType.html#Alvao_API_Common_Model_Database_SamType_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int id { get; set; }
}
