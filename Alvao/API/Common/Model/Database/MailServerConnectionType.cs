using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Connection type for loading messages on services</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.MailServerConnectionType.html"/>
[Table("dbo.MailServerConnectionType")]
public class MailServerConnectionType {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.MailServerConnectionType.MailServerConnectionTypeId.html#fields"/>
    public enum MailServerConnectionTypeId {
        None = 1,
        MicrosoftGraphApi = 2,
        ExchangeServerBasic = 3,
        Imap = 4,
        ExchangeOnlineOauth = 5,
    }

    /// <summary>Connection type ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.MailServerConnectionType.html#Alvao_API_Common_Model_Database_MailServerConnectionType_Id"/>
    [ExplicitKey]
    public virtual int Id { get; set; }
    /// <summary>Connection type</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.MailServerConnectionType.html#Alvao_API_Common_Model_Database_MailServerConnectionType_Name"/>
    public virtual string Name { get; set; }
}
