using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Definition of custom JavaScript for forms.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_FormScriptExtension.htm"/>
[TableAttribute("dbo.FormScriptExtension")]
public class FormScriptExtension {
    /// <summary>Entity ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_FormScriptExtension_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>JavaScript inserted into the page.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_FormScriptExtension_Javascript.htm"/>
    public virtual string Javascript { get; set; }
    /// <summary>Link to service.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_FormScriptExtension_SectionId.htm"/>
    public virtual int SectionId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_FormScriptExtension__ctor.htm"/>
    public FormScriptExtension() { }
}
