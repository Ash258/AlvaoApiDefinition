using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Object types assigned to services.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionNodeClass.html"/>
[Table("dbo.HdSectionNodeClass")]
public class HdSectionNodeClass {
    /// <summary>A service (tHdSection.iHdSectionId) to which the object type is linked.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionNodeClass.html#Alvao_API_Common_Model_Database_HdSectionNodeClass_HdSectionId"/>
    public virtual int HdSectionId { get; set; }
    /// <summary>The object type (tblClass.intClassId) which is linked to the service.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionNodeClass.html#Alvao_API_Common_Model_Database_HdSectionNodeClass_NodeClassId"/>
    public virtual int NodeClassId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionNodeClass.html#Alvao_API_Common_Model_Database_HdSectionNodeClass_id"/>
    [Key]
    public virtual int id { get; set; }
}
