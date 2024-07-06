using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Record type tAct, e.g. "e-mail", "phone", "note", "process", …
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tActKind.htm"/>
[TableAttribute("dbo.tActKind")]
public class tActKind
{
    public enum ActKind
    {
        Email = 1,
        Phone = 2,
        Meeting = 3,
        Letter = 4,
        VoiceMessage = 5,
        PaperNote = 6,
        Form = 7,
        Note = 8,
        Process = 9,
        Empty = -1,
        Other = 10,
        Notification = 11,
    }


    /// <summary>Record ID: 1 = e-mail, 2 = phone, 3 = personal meeting, 4 = letter, 5 = voice message, 6 = written message, 7 = form, 8 = note, 9 = process, 10 = other, 11 = alert.</summary>
    [ExplicitKeyAttribute]
    public virtual int iActKindId { get; set; }
    /// <summary>Order in which records are displayed.</summary>
    public virtual int? iActKindOrder { get; set; }
    public virtual bool Removable { get; set; }
    /// <summary>Naming the type of event</summary>
    public virtual string sActKind { get; set; }

    public tActKind() { }
}
