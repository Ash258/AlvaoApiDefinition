using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Configuration of the SMTP server for ALVAO.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tSmtp.htm"/>
[TableAttribute("dbo.tSmtp")]
public class tSmtp
{
    public enum AuthTypeEnum
    {
        OAuth = 0,
        Basic = 1,
        Integrated = 2,
    }

    /// <summary>Authentication type: 0 = OAuth, 1 = Basic, 2 = Integrated</summary>
    public virtual int AuthType { get; set; }
    /// <summary>1, should SSL be used for connecting to the SMTP server.</summary>
    public virtual bool bSmtpSsl { get; set; }
    /// <summary>OAuth - Application (client) ID</summary>
    public virtual string ClientId { get; set; }
    /// <summary>OAuth - Client secret</summary>
    public virtual string ClientSecret { get; set; }
    /// <summary>SMTP Server port.</summary>
    public virtual int? nSmtpPort { get; set; }
    /// <summary>SMTP server address.</summary>
    [ExplicitKeyAttribute]
    public virtual string sSmtpAddress { get; set; }
    /// <summary>Username for SMTP server access.</summary>
    public virtual string sSmtpLogin { get; set; }
    /// <summary>Password for SMTP server access.</summary>
    public virtual string sSmtpPswd { get; set; }
    /// <summary>OAuth - Directory (tenant) ID</summary>
    public virtual string TenantId { get; set; }

    public tSmtp() { }
}
