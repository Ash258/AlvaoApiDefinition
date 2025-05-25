using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Property of the custom theme.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.CustomThemeProperty.html"/>
[Table("dbo.CustomThemeProperty")]
public class CustomThemeProperty {
    /// <summary>Name of the theme property.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.CustomThemeProperty.html#Alvao_API_Common_Model_Database_CustomThemeProperty_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Value of the theme property.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.CustomThemeProperty.html#Alvao_API_Common_Model_Database_CustomThemeProperty_Value"/>
    public virtual string Value { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.CustomThemeProperty.html#Alvao_API_Common_Model_Database_CustomThemeProperty_id"/>
    [Key]
    public virtual int id { get; set; }
}
