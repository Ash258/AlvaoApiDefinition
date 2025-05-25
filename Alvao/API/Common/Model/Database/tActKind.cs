using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Record type tAct, e.g. &quot;e-mail&quot;, &quot;phone&quot;, &quot;note&quot;, &quot;process&quot;, â¦</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tActKind.html"/>
[Table("dbo.tActKind")]
public class tActKind {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tActKind.ActKind.html#fields"/>
    public enum ActKind {
        Email = 1,
        Empty = -1,
        Form = 7,
        Letter = 4,
        Meeting = 3,
        Note = 8,
        Notification = 11,
        Other = 10,
        PaperNote = 6,
        Phone = 2,
        Process = 9,
        VoiceMessage = 5,
    }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tActKind.html#Alvao_API_Common_Model_Database_tActKind_Removable"/>
    public virtual bool Removable { get; set; }
    /// <summary>Record ID: 1 = e-mail 2 = phone 3 = personal meeting 4 = letter 5 = voice message 6 = written message 7 = form 8 = note 9 = process 10 = other 11 = alert</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tActKind.html#Alvao_API_Common_Model_Database_tActKind_iActKindId"/>
    [ExplicitKey]
    public virtual int iActKindId { get; set; }
    /// <summary>Order in which records are displayed.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tActKind.html#Alvao_API_Common_Model_Database_tActKind_iActKindOrder"/>
    public virtual int? iActKindOrder { get; set; }
    /// <summary>Naming the type of event</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tActKind.html#Alvao_API_Common_Model_Database_tActKind_sActKind"/>
    public virtual string sActKind { get; set; }
}
