using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Notes.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblNotice.htm"/>
[TableAttribute("dbo.tblNotice")]
public class tblNotice
{
    /// <summary>date and time the note was created</summary>
    public virtual DateTime? dteDateTime { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int intNoticeId { get; set; }
    /// <summary>object - tblNodeId</summary>
    public virtual int lintNodeId { get; set; }
    /// <summary>author - tPerson</summary>
    public virtual int? liPersonId { get; set; }
    public virtual int? RemovedByPersonId { get; set; }
    public virtual DateTime? RemovedDate { get; set; }
    /// <summary>text</summary>
    public virtual string txtDesc { get; set; }
    /// <summary>subject</summary>
    public virtual string txtSubject { get; set; }

    public tblNotice() { }
}
