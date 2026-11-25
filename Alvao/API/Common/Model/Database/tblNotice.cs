using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Notes.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNotice.html"/>
[Table("dbo.tblNotice")]
public class tblNotice {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNotice.html#Alvao_API_Common_Model_Database_tblNotice_RemovedByPersonId"/>
    /// <remarks>Column <c>RemovedByPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? RemovedByPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNotice.html#Alvao_API_Common_Model_Database_tblNotice_RemovedDate"/>
    /// <remarks>Column <c>RemovedDate</c>: datetime, null.</remarks>
    public virtual DateTime? RemovedDate { get; set; }
    /// <summary>date and time the note was created</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNotice.html#Alvao_API_Common_Model_Database_tblNotice_dteDateTime"/>
    /// <remarks>Column <c>dteDateTime</c>: datetime, null.</remarks>
    public virtual DateTime? dteDateTime { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNotice.html#Alvao_API_Common_Model_Database_tblNotice_intNoticeId"/>
    /// <remarks>Column <c>intNoticeId</c>: int, not null.</remarks>
    [Key]
    public virtual int intNoticeId { get; set; }
    /// <summary>author - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNotice.html#Alvao_API_Common_Model_Database_tblNotice_liPersonId"/>
    /// <remarks>Column <c>liPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? liPersonId { get; set; }
    /// <summary>object - tblNodeId</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNotice.html#Alvao_API_Common_Model_Database_tblNotice_lintNodeId"/>
    /// <remarks>Column <c>lintNodeId</c>: int, not null. References <see cref="tblNode"/>.</remarks>
    public virtual int lintNodeId { get; set; }
    /// <summary>text</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNotice.html#Alvao_API_Common_Model_Database_tblNotice_txtDesc"/>
    /// <remarks>Column <c>txtDesc</c>: nvarchar(max), null.</remarks>
    public virtual string txtDesc { get; set; }
    /// <summary>subject</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblNotice.html#Alvao_API_Common_Model_Database_tblNotice_txtSubject"/>
    /// <remarks>Column <c>txtSubject</c>: nvarchar(255), null.</remarks>
    public virtual string txtSubject { get; set; }
}
