using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Automatic replies settings for MS Entra ID users.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticRepliesSettings.html"/>
[Table("dbo.AutomaticRepliesSettings")]
public class AutomaticRepliesSettings {
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticRepliesSettings.html#Alvao_API_Common_Model_Database_AutomaticRepliesSettings_Id"/>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Internal reply message</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticRepliesSettings.html#Alvao_API_Common_Model_Database_AutomaticRepliesSettings_InternalReplyMessageHtml"/>
    public virtual string InternalReplyMessageHtml { get; set; }
    /// <summary>Last synchronization timestamp</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticRepliesSettings.html#Alvao_API_Common_Model_Database_AutomaticRepliesSettings_LastUpdate"/>
    public virtual DateTime? LastUpdate { get; set; }
    /// <summary>Person ID (tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticRepliesSettings.html#Alvao_API_Common_Model_Database_AutomaticRepliesSettings_PersonId"/>
    public virtual int PersonId { get; set; }
    /// <summary>Scheduled end (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticRepliesSettings.html#Alvao_API_Common_Model_Database_AutomaticRepliesSettings_ScheduledEnd"/>
    public virtual DateTime? ScheduledEnd { get; set; }
    /// <summary>Scheduled start (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticRepliesSettings.html#Alvao_API_Common_Model_Database_AutomaticRepliesSettings_ScheduledStart"/>
    public virtual DateTime? ScheduledStart { get; set; }
    /// <summary>Status ID (AutomaticRepliesStatus.Id)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticRepliesSettings.html#Alvao_API_Common_Model_Database_AutomaticRepliesSettings_StatusId"/>
    public virtual int StatusId { get; set; }
}
