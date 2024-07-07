namespace Alvao.API.Common.Model;

/// <summary>
/// Audit system block model
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_AuditSystemBlockModel.htm"/>
public class AuditSystemBlockModel
{
    /// <summary>Application name which creates log record.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_AuditSystemBlockModel_Application.htm"/>
    public string Application { get; set; }
    /// <summary>Name of the computer where the application is running.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_AuditSystemBlockModel_ComputerName.htm"/>
    public string ComputerName { get; set; }
    /// <summary>Logged in user (audited operation author) login.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_AuditSystemBlockModel_CurrentUserLogin.htm"/>
    public string CurrentUserLogin { get; set; }
    /// <summary>Name of database with which the application is working.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_AuditSystemBlockModel_DatabaseName.htm"/>
    public string DatabaseName { get; set; }
    /// <summary>Name of database server with which the application is working.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_AuditSystemBlockModel_DatabaseServer.htm"/>
    public string DatabaseServer { get; set; }
    /// <summary>The IP address of the client from where the change came.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_AuditSystemBlockModel_IPaddress.htm"/>
    public string IPaddress { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_AuditSystemBlockModel__ctor.htm"/>
    public AuditSystemBlockModel() { }
}
