using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Notes.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNotice.html"/>
[Table("dbo.tblNotice")]
public class tblNotice {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNotice.html#Alvao_API_Common_Model_Database_tblNotice_RemovedByPersonId"/>
    public virtual int? RemovedByPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNotice.html#Alvao_API_Common_Model_Database_tblNotice_RemovedDate"/>
    public virtual DateTime? RemovedDate { get; set; }
    /// <summary>date and time the note was created</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNotice.html#Alvao_API_Common_Model_Database_tblNotice_dteDateTime"/>
    public virtual DateTime? dteDateTime { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNotice.html#Alvao_API_Common_Model_Database_tblNotice_intNoticeId"/>
    [Key]
    public virtual int intNoticeId { get; set; }
    /// <summary>author - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNotice.html#Alvao_API_Common_Model_Database_tblNotice_liPersonId"/>
    public virtual int? liPersonId { get; set; }
    /// <summary>object - tblNodeId</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNotice.html#Alvao_API_Common_Model_Database_tblNotice_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <summary>text</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNotice.html#Alvao_API_Common_Model_Database_tblNotice_txtDesc"/>
    public virtual string txtDesc { get; set; }
    /// <summary>subject</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNotice.html#Alvao_API_Common_Model_Database_tblNotice_txtSubject"/>
    public virtual string txtSubject { get; set; }
}
