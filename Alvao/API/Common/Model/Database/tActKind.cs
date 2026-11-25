using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Record type tAct, e.g. &quot;email&quot;, &quot;phone&quot;, &quot;note&quot;, &quot;process&quot;, â¦
/// </summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tActKind.html"/>
[Table("dbo.tActKind")]
public class tActKind {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tActKind.ActKind.html#fields"/>
    public enum ActKind {
        Empty = -1,
        Email = 1,
        Phone = 2,
        Meeting = 3,
        Letter = 4,
        VoiceMessage = 5,
        PaperNote = 6,
        Form = 7,
        Note = 8,
        Process = 9,
        Other = 10,
        Notification = 11,
    }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tActKind.html#Alvao_API_Common_Model_Database_tActKind_Removable"/>
    /// <remarks>Column <c>Removable</c>: bit, not null.</remarks>
    public virtual bool Removable { get; set; }
    /// <summary>
    /// Record ID: 1 = email 2 = phone 3 = personal meeting 4 = letter 5 = voice message 6 = written message 7 = form 8
    /// = note 9 = process 10 = other 11 = alert
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tActKind.html#Alvao_API_Common_Model_Database_tActKind_iActKindId"/>
    /// <remarks>Column <c>iActKindId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int iActKindId { get; set; }
    /// <summary>Order in which records are displayed.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tActKind.html#Alvao_API_Common_Model_Database_tActKind_iActKindOrder"/>
    /// <remarks>Column <c>iActKindOrder</c>: int, null.</remarks>
    public virtual int? iActKindOrder { get; set; }
    /// <summary>Naming the type of event</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tActKind.html#Alvao_API_Common_Model_Database_tActKind_sActKind"/>
    /// <remarks>Column <c>sActKind</c>: nvarchar(255), null.</remarks>
    public virtual string sActKind { get; set; }
}
