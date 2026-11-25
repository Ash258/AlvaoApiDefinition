using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Definition of custom JavaScript for forms.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FormScriptExtension.html"/>
[Table("dbo.FormScriptExtension")]
public class FormScriptExtension {
    /// <summary>JavaScript inserted into the page.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FormScriptExtension.html#Alvao_API_Common_Model_Database_FormScriptExtension_Javascript"/>
    /// <remarks>Column <c>Javascript</c>: nvarchar(max), null.</remarks>
    public virtual string Javascript { get; set; }
    /// <summary>Link to service (tHdSection.iHdSectionId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FormScriptExtension.html#Alvao_API_Common_Model_Database_FormScriptExtension_SectionId"/>
    /// <remarks>Column <c>SectionId</c>: int, null. References <see cref="tHdSection"/>.</remarks>
    public virtual int? SectionId { get; set; }
    /// <summary>Link to status (TicketState.id)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FormScriptExtension.html#Alvao_API_Common_Model_Database_FormScriptExtension_StatusId"/>
    /// <remarks>Column <c>StatusId</c>: int, null. References <see cref="TicketState"/>.</remarks>
    public virtual int? StatusId { get; set; }
    /// <summary>Entity ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FormScriptExtension.html#Alvao_API_Common_Model_Database_FormScriptExtension_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
