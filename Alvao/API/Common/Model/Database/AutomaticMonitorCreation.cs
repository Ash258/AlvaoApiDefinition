using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Settings for tracking computer monitors.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticMonitorCreation.html"/>
[Table("dbo.AutomaticMonitorCreation")]
public class AutomaticMonitorCreation {
    /// <summary>If enabled, monitors can be created anywhere.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticMonitorCreation.html#Alvao_API_Common_Model_Database_AutomaticMonitorCreation_CreateAnywhere"/>
    public virtual bool CreateAnywhere { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticMonitorCreation.html#Alvao_API_Common_Model_Database_AutomaticMonitorCreation_Id"/>
    [ExplicitKey]
    public virtual byte Id { get; set; }
    /// <summary>Settings is enabled or disabled.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticMonitorCreation.html#Alvao_API_Common_Model_Database_AutomaticMonitorCreation_IsEnabled"/>
    public virtual bool IsEnabled { get; set; }
    /// <summary>If enabled, monitors are created alongside a computer, otherwise under a computer.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticMonitorCreation.html#Alvao_API_Common_Model_Database_AutomaticMonitorCreation_PlaceAlongside"/>
    public virtual bool PlaceAlongside { get; set; }
}
