using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Objects from external systems</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalObject.html"/>
[Table("dbo.ExternalObject")]
public class ExternalObject {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalObject.Type.html#fields"/>
    public enum Type {
        User = 1,
    }

    /// <summary>ID of the object in the external system</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalObject.html#Alvao_API_Common_Model_Database_ExternalObject_ExternalId"/>
    public virtual string ExternalId { get; set; }
    /// <summary>External object type ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalObject.html#Alvao_API_Common_Model_Database_ExternalObject_ExternalObjectTypeId"/>
    public virtual int? ExternalObjectTypeId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalObject.html#Alvao_API_Common_Model_Database_ExternalObject_Id"/>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Object name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalObject.html#Alvao_API_Common_Model_Database_ExternalObject_Name"/>
    public virtual string Name { get; set; }
}
