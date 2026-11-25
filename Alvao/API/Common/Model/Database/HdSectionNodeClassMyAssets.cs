using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Property entrusted to me - services which should be displayed in the service offer on the pages of objects of a
/// certain type.
/// </summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionNodeClassMyAssets.html"/>
[Table("dbo.HdSectionNodeClassMyAssets")]
public class HdSectionNodeClassMyAssets {
    /// <summary>The service (tHdSection.iHdSectionId) which should be displayed on the object pages.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionNodeClassMyAssets.html#Alvao_API_Common_Model_Database_HdSectionNodeClassMyAssets_HdSectionId"/>
    /// <remarks>Column <c>HdSectionId</c>: int, not null. References <see cref="tHdSection"/>.</remarks>
    public virtual int HdSectionId { get; set; }
    /// <summary>The class of objects (tblClass.intClassId) whose website should display the service.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionNodeClassMyAssets.html#Alvao_API_Common_Model_Database_HdSectionNodeClassMyAssets_NodeClassId"/>
    /// <remarks>Column <c>NodeClassId</c>: int, not null. References <see cref="tblClass"/>.</remarks>
    public virtual int NodeClassId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionNodeClassMyAssets.html#Alvao_API_Common_Model_Database_HdSectionNodeClassMyAssets_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
