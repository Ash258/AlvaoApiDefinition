using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Emails for processing received from change notifications.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphMailInfo.html"/>
[Table("dbo.GraphMailInfo")]
public class GraphMailInfo {
    /// <summary>Record creation date.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphMailInfo.html#Alvao_API_Common_Model_Database_GraphMailInfo_DateCreated"/>
    public virtual DateTime DateCreated { get; set; }
    /// <summary>The timestamp when the record was successfully processed.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphMailInfo.html#Alvao_API_Common_Model_Database_GraphMailInfo_DateProcessed"/>
    public virtual DateTime? DateProcessed { get; set; }
    /// <summary>Number of retries for email processing.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphMailInfo.html#Alvao_API_Common_Model_Database_GraphMailInfo_ErrorCount"/>
    public virtual int? ErrorCount { get; set; }
    /// <summary>Unique identifier for the subscription (GraphSubscription.Id).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphMailInfo.html#Alvao_API_Common_Model_Database_GraphMailInfo_GraphSubscriptionId"/>
    public virtual int? GraphSubscriptionId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphMailInfo.html#Alvao_API_Common_Model_Database_GraphMailInfo_Id"/>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Last error message.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphMailInfo.html#Alvao_API_Common_Model_Database_GraphMailInfo_LastErrorMessage"/>
    public virtual string LastErrorMessage { get; set; }
    /// <summary>Unique email Graph message ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphMailInfo.html#Alvao_API_Common_Model_Database_GraphMailInfo_MessageId"/>
    public virtual string MessageId { get; set; }
    /// <summary>Resource (mailbox and message).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphMailInfo.html#Alvao_API_Common_Model_Database_GraphMailInfo_Resource"/>
    public virtual string Resource { get; set; }
    /// <summary>Tenant ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphMailInfo.html#Alvao_API_Common_Model_Database_GraphMailInfo_TenantId"/>
    public virtual string TenantId { get; set; }
}
