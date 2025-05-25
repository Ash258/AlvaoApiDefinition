using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Configuration of the SMTP server for ALVAO.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSmtp.html"/>
[Table("dbo.tSmtp")]
public class tSmtp {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSmtp.AuthTypeEnum.html#fields"/>
    public enum AuthTypeEnum {
        OAuth = 0,
        Basic = 1,
        Integrated = 2,
    }
    /// <summary>Authentication type: 0 = OAuth, 1 = Basic, 2 = Integrated</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSmtp.html#Alvao_API_Common_Model_Database_tSmtp_AuthType"/>
    public virtual int AuthType { get; set; }
    /// <summary>OAuth - Application (client) ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSmtp.html#Alvao_API_Common_Model_Database_tSmtp_ClientId"/>
    public virtual string ClientId { get; set; }
    /// <summary>OAuth - Client secret</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSmtp.html#Alvao_API_Common_Model_Database_tSmtp_ClientSecret"/>
    public virtual string ClientSecret { get; set; }
    /// <summary>OAuth - Directory (tenant) ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSmtp.html#Alvao_API_Common_Model_Database_tSmtp_TenantId"/>
    public virtual string TenantId { get; set; }
    /// <summary>1, should SSL be used for connecting to the SMTP server.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSmtp.html#Alvao_API_Common_Model_Database_tSmtp_bSmtpSsl"/>
    public virtual bool bSmtpSsl { get; set; }
    /// <summary>SMTP Server port.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSmtp.html#Alvao_API_Common_Model_Database_tSmtp_nSmtpPort"/>
    public virtual int? nSmtpPort { get; set; }
    /// <summary>SMTP server address.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSmtp.html#Alvao_API_Common_Model_Database_tSmtp_sSmtpAddress"/>
    [ExplicitKey]
    public virtual string sSmtpAddress { get; set; }
    /// <summary>Username for SMTP server access.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSmtp.html#Alvao_API_Common_Model_Database_tSmtp_sSmtpLogin"/>
    public virtual string sSmtpLogin { get; set; }
    /// <summary>Password for SMTP server access.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSmtp.html#Alvao_API_Common_Model_Database_tSmtp_sSmtpPswd"/>
    public virtual string sSmtpPswd { get; set; }
}
