using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Send method types for emails</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SendEmailMethodType.html"/>
[Table("dbo.SendEmailMethodType")]
public class SendEmailMethodType {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SendEmailMethodType.SendEmailMethodTypeId.html#fields"/>
    public enum SendEmailMethodTypeId {
        ExchangeOnlineGraphApi = 1,
        ExchangeOnlineSmtp = 2,
        SmtpUserPass = 3,
        SmtpIntegrated = 4,
    }

    /// <summary>Method type ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SendEmailMethodType.html#Alvao_API_Common_Model_Database_SendEmailMethodType_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int Id { get; set; }
    /// <summary>Method type</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SendEmailMethodType.html#Alvao_API_Common_Model_Database_SendEmailMethodType_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(100), not null.</remarks>
    public virtual string Name { get; set; }
}
