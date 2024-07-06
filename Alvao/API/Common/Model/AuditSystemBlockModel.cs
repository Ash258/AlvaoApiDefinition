namespace Alvao.API.Common.Model;

/// <summary>
/// Audit system block model
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_AuditSystemBlockModel.htm"/>
public class AuditSystemBlockModel
{
    /// <summary>Application name which creates log record.</summary>
    public string Application { get; set; }
    /// <summary>Name of the computer where the application is running.</summary>
    public string ComputerName { get; set; }
    /// <summary>Logged in user (audited operation author) login.</summary>
    public string CurrentUserLogin { get; set; }
    /// <summary>Name of database with which the application is working.</summary>
    public string DatabaseName { get; set; }
    /// <summary>Name of database server with which the application is working.</summary>
    public string DatabaseServer { get; set; }
    /// <summary>The IP address of the client from where the change came.</summary>
    public string IPaddress { get; set; }

    public AuditSystemBlockModel() { }
}
