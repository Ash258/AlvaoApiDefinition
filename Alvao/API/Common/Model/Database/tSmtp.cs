using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Configuration of the SMTP server for ALVAO.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSmtp.html"/>
[Table("dbo.tSmtp")]
public class tSmtp {
    /// <summary>OAuth - Application (client) ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSmtp.html#Alvao_API_Common_Model_Database_tSmtp_ClientId"/>
    /// <remarks>Column <c>ClientId</c>: nvarchar(255), null.</remarks>
    public virtual string ClientId { get; set; }
    /// <summary>OAuth - Client secret</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSmtp.html#Alvao_API_Common_Model_Database_tSmtp_ClientSecret"/>
    /// <remarks>Column <c>ClientSecret</c>: nvarchar(255), null.</remarks>
    public virtual string ClientSecret { get; set; }
    /// <summary>ID of the send email method type (SendEmailMethodType.Id)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSmtp.html#Alvao_API_Common_Model_Database_tSmtp_SendEmailMethodTypeId"/>
    /// <remarks>
    /// Column <c>SendEmailMethodTypeId</c>: int, not null. References <see cref="SendEmailMethodType"/>.
    /// </remarks>
    public virtual int SendEmailMethodTypeId { get; set; }
    /// <summary>OAuth - Directory (tenant) ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSmtp.html#Alvao_API_Common_Model_Database_tSmtp_TenantId"/>
    /// <remarks>Column <c>TenantId</c>: nvarchar(255), null.</remarks>
    public virtual string TenantId { get; set; }
    /// <summary>1, should SSL be used for connecting to the SMTP server.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSmtp.html#Alvao_API_Common_Model_Database_tSmtp_bSmtpSsl"/>
    /// <remarks>Column <c>bSmtpSsl</c>: bit, not null.</remarks>
    public virtual bool bSmtpSsl { get; set; }
    /// <summary>SMTP Server port.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSmtp.html#Alvao_API_Common_Model_Database_tSmtp_nSmtpPort"/>
    /// <remarks>Column <c>nSmtpPort</c>: int, null.</remarks>
    public virtual int? nSmtpPort { get; set; }
    /// <summary>SMTP server address.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSmtp.html#Alvao_API_Common_Model_Database_tSmtp_sSmtpAddress"/>
    /// <remarks>Column <c>sSmtpAddress</c>: nvarchar(255), null.</remarks>
    [ExplicitKey]
    public virtual string sSmtpAddress { get; set; }
    /// <summary>Username for SMTP server access.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSmtp.html#Alvao_API_Common_Model_Database_tSmtp_sSmtpLogin"/>
    /// <remarks>Column <c>sSmtpLogin</c>: nvarchar(255), null.</remarks>
    public virtual string sSmtpLogin { get; set; }
    /// <summary>Password for SMTP server access.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSmtp.html#Alvao_API_Common_Model_Database_tSmtp_sSmtpPswd"/>
    /// <remarks>Column <c>sSmtpPswd</c>: nvarchar(255), null.</remarks>
    public virtual string sSmtpPswd { get; set; }
}
