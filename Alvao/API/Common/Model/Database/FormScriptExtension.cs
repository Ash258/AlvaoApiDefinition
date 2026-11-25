using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Definition of custom JavaScript for forms.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FormScriptExtension.html"/>
[Table("dbo.FormScriptExtension")]
public class FormScriptExtension {
    /// <summary>JavaScript inserted into the page.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FormScriptExtension.html#Alvao_API_Common_Model_Database_FormScriptExtension_Javascript"/>
    public virtual string Javascript { get; set; }
    /// <summary>Link to service (tHdSection.iHdSectionId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FormScriptExtension.html#Alvao_API_Common_Model_Database_FormScriptExtension_SectionId"/>
    public virtual int? SectionId { get; set; }
    /// <summary>Link to status (TicketState.id)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FormScriptExtension.html#Alvao_API_Common_Model_Database_FormScriptExtension_StatusId"/>
    public virtual int? StatusId { get; set; }
    /// <summary>Entity ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FormScriptExtension.html#Alvao_API_Common_Model_Database_FormScriptExtension_id"/>
    [Key]
    public virtual int id { get; set; }
}
