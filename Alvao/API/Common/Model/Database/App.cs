using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Application.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.App.html"/>
[Table("Apps.App")]
public class App {
    /// <summary>Application advanced settings.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.App.html#Alvao_API_Common_Model_Database_App_AdvancedSettings"/>
    /// <remarks>Column <c>AdvancedSettings</c>: nvarchar(max), null.</remarks>
    public virtual string AdvancedSettings { get; set; }
    /// <summary>Application description.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.App.html#Alvao_API_Common_Model_Database_App_Description"/>
    /// <remarks>Column <c>Description</c>: nvarchar(max), null.</remarks>
    public virtual string Description { get; set; }
    /// <summary>If the application is enabled. 1 = enabled, 0 = disabled.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.App.html#Alvao_API_Common_Model_Database_App_IsEnabled"/>
    /// <remarks>Column <c>IsEnabled</c>: bit, not null.</remarks>
    public virtual bool IsEnabled { get; set; }
    /// <summary>Application name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.App.html#Alvao_API_Common_Model_Database_App_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(255), not null.</remarks>
    public virtual string Name { get; set; }
    /// <summary>Application global identification (GUID).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.App.html#Alvao_API_Common_Model_Database_App_UniqueId"/>
    /// <remarks>Column <c>UniqueId</c>: uniqueidentifier, null.</remarks>
    public virtual Guid? UniqueId { get; set; }
    /// <summary>Application version.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.App.html#Alvao_API_Common_Model_Database_App_Version"/>
    /// <remarks>Column <c>Version</c>: int, not null.</remarks>
    public virtual int Version { get; set; }
    /// <summary>Application ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.App.html#Alvao_API_Common_Model_Database_App_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
