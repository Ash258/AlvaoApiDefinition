using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Application.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.App.html"/>
[Table("Apps.App")]
public class App {
    /// <summary>Application description.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.App.html#Alvao_API_Common_Model_Database_App_Description"/>
    public virtual string Description { get; set; }
    /// <summary>If the application is enabled. 1 = enabled, 0 = disabled.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.App.html#Alvao_API_Common_Model_Database_App_IsEnabled"/>
    public virtual bool IsEnabled { get; set; }
    /// <summary>Application name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.App.html#Alvao_API_Common_Model_Database_App_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Application ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.App.html#Alvao_API_Common_Model_Database_App_id"/>
    [Key]
    public virtual int id { get; set; }
}
