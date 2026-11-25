using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Emails for processing received from change notifications.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphMailInfo.html"/>
[Table("dbo.GraphMailInfo")]
public class GraphMailInfo {
    /// <summary>Record creation date.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphMailInfo.html#Alvao_API_Common_Model_Database_GraphMailInfo_DateCreated"/>
    /// <remarks>Column <c>DateCreated</c>: datetime, not null.</remarks>
    public virtual DateTime DateCreated { get; set; }
    /// <summary>The timestamp when the record was successfully processed.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphMailInfo.html#Alvao_API_Common_Model_Database_GraphMailInfo_DateProcessed"/>
    /// <remarks>Column <c>DateProcessed</c>: datetime, null.</remarks>
    public virtual DateTime? DateProcessed { get; set; }
    /// <summary>Number of retries for email processing.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphMailInfo.html#Alvao_API_Common_Model_Database_GraphMailInfo_ErrorCount"/>
    /// <remarks>Column <c>ErrorCount</c>: int, null.</remarks>
    public virtual int? ErrorCount { get; set; }
    /// <summary>Unique identifier for the subscription (GraphSubscription.Id).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphMailInfo.html#Alvao_API_Common_Model_Database_GraphMailInfo_GraphSubscriptionId"/>
    /// <remarks>Column <c>GraphSubscriptionId</c>: int, null. References <see cref="GraphSubscription"/>.</remarks>
    public virtual int? GraphSubscriptionId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphMailInfo.html#Alvao_API_Common_Model_Database_GraphMailInfo_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Last error message.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphMailInfo.html#Alvao_API_Common_Model_Database_GraphMailInfo_LastErrorMessage"/>
    /// <remarks>Column <c>LastErrorMessage</c>: nvarchar(max), null.</remarks>
    public virtual string LastErrorMessage { get; set; }
    /// <summary>Unique email Graph message ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphMailInfo.html#Alvao_API_Common_Model_Database_GraphMailInfo_MessageId"/>
    /// <remarks>Column <c>MessageId</c>: nvarchar(max), not null.</remarks>
    public virtual string MessageId { get; set; }
    /// <summary>Resource (mailbox and message).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphMailInfo.html#Alvao_API_Common_Model_Database_GraphMailInfo_Resource"/>
    /// <remarks>Column <c>Resource</c>: nvarchar(max), null.</remarks>
    public virtual string Resource { get; set; }
    /// <summary>Tenant ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphMailInfo.html#Alvao_API_Common_Model_Database_GraphMailInfo_TenantId"/>
    /// <remarks>Column <c>TenantId</c>: nvarchar(40), null.</remarks>
    public virtual string TenantId { get; set; }
}
