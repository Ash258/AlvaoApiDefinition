using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>External object types</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalObjectType.html"/>
[Table("dbo.ExternalObjectType")]
public class ExternalObjectType {
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalObjectType.html#Alvao_API_Common_Model_Database_ExternalObjectType_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int Id { get; set; }
    /// <summary>Name of the type</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalObjectType.html#Alvao_API_Common_Model_Database_ExternalObjectType_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(64), not null.</remarks>
    public virtual string Name { get; set; }
}
