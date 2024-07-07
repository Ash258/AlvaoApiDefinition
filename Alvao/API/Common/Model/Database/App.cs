using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Application.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_App.htm"/>
[TableAttribute("Apps.App")]
public class App
{
    /// <summary>Application description.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_App_Description.htm"/>
    public virtual string Description { get; set; }
    /// <summary>Application ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_App_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>If the application is enabled. 1 = enabled, 0 = disabled.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_App_IsEnabled.htm"/>
    public virtual bool IsEnabled { get; set; }
    /// <summary>Application name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_App_Name.htm"/>
    public virtual string Name { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_App__ctor.htm"/>
    public App() { }
}
