namespace Alvao.API.Common.Model;

/// <summary>Audit system block model</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.AuditSystemBlockModel.html"/>
public class AuditSystemBlockModel {
    /// <summary>Application name which creates log record.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.AuditSystemBlockModel.html#Alvao_API_Common_Model_AuditSystemBlockModel_Application"/>
    public string Application { get; set; }
    /// <summary>Name of the computer where the application is running.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.AuditSystemBlockModel.html#Alvao_API_Common_Model_AuditSystemBlockModel_ComputerName"/>
    public string ComputerName { get; set; }
    /// <summary>Logged in user (audited operation author) login.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.AuditSystemBlockModel.html#Alvao_API_Common_Model_AuditSystemBlockModel_CurrentUserLogin"/>
    public string CurrentUserLogin { get; set; }
    /// <summary>Name of database with which the application is working.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.AuditSystemBlockModel.html#Alvao_API_Common_Model_AuditSystemBlockModel_DatabaseName"/>
    public string DatabaseName { get; set; }
    /// <summary>Name of database server with which the application is working.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.AuditSystemBlockModel.html#Alvao_API_Common_Model_AuditSystemBlockModel_DatabaseServer"/>
    public string DatabaseServer { get; set; }
    /// <summary>The IP address of the client from where the change came.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.AuditSystemBlockModel.html#Alvao_API_Common_Model_AuditSystemBlockModel_IPaddress"/>
    public string IPaddress { get; set; }
}
