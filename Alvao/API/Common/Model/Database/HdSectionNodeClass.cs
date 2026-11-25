using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Object types assigned to services.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionNodeClass.html"/>
[Table("dbo.HdSectionNodeClass")]
public class HdSectionNodeClass {
    /// <summary>A service (tHdSection.iHdSectionId) to which the object type is linked.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionNodeClass.html#Alvao_API_Common_Model_Database_HdSectionNodeClass_HdSectionId"/>
    /// <remarks>Column <c>HdSectionId</c>: int, not null. References <see cref="tHdSection"/>.</remarks>
    public virtual int HdSectionId { get; set; }
    /// <summary>The object type (tblClass.intClassId) which is linked to the service.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionNodeClass.html#Alvao_API_Common_Model_Database_HdSectionNodeClass_NodeClassId"/>
    /// <remarks>Column <c>NodeClassId</c>: int, not null. References <see cref="tblClass"/>.</remarks>
    public virtual int NodeClassId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionNodeClass.html#Alvao_API_Common_Model_Database_HdSectionNodeClass_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
