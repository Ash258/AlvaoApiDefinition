using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Property of the custom theme.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_CustomThemeProperty.htm"/>
[TableAttribute("dbo.CustomThemeProperty")]
public class CustomThemeProperty
{
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_CustomThemeProperty_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Name of the theme property.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_CustomThemeProperty_Name.htm"/>
    public virtual string Name { get; set; }
    /// <summary>Value of the theme property.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_CustomThemeProperty_Value.htm"/>
    public virtual string Value { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_CustomThemeProperty__ctor.htm"/>
    public CustomThemeProperty() { }
}
