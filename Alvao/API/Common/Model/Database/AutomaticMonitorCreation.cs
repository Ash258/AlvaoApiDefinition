using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Settings for tracking computer monitors.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticMonitorCreation.html"/>
[Table("dbo.AutomaticMonitorCreation")]
public class AutomaticMonitorCreation {
    /// <summary>If enabled, monitors can be created anywhere.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticMonitorCreation.html#Alvao_API_Common_Model_Database_AutomaticMonitorCreation_CreateAnywhere"/>
    /// <remarks>Column <c>CreateAnywhere</c>: bit, not null.</remarks>
    public virtual bool CreateAnywhere { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticMonitorCreation.html#Alvao_API_Common_Model_Database_AutomaticMonitorCreation_Id"/>
    /// <remarks>Column <c>Id</c>: tinyint, not null.</remarks>
    [ExplicitKey]
    public virtual byte Id { get; set; }
    /// <summary>Settings is enabled or disabled.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticMonitorCreation.html#Alvao_API_Common_Model_Database_AutomaticMonitorCreation_IsEnabled"/>
    /// <remarks>Column <c>IsEnabled</c>: bit, not null.</remarks>
    public virtual bool IsEnabled { get; set; }
    /// <summary>If enabled, monitors are created alongside a computer, otherwise under a computer.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticMonitorCreation.html#Alvao_API_Common_Model_Database_AutomaticMonitorCreation_PlaceAlongside"/>
    /// <remarks>Column <c>PlaceAlongside</c>: bit, not null.</remarks>
    public virtual bool PlaceAlongside { get; set; }
}
