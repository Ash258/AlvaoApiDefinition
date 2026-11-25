using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Log - changes in the properties values and information on the detection results.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLog.html"/>
[Table("dbo.tblLog")]
public class tblLog {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLog.html#Alvao_API_Common_Model_Database_tblLog_DetectKindId"/>
    /// <remarks>Column <c>DetectKindId</c>: int, null. References <see cref="tblDetectKind"/>.</remarks>
    public virtual int? DetectKindId { get; set; }
    /// <summary>ID of the property definition related to the change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLog.html#Alvao_API_Common_Model_Database_tblLog_KindId"/>
    /// <remarks>Column <c>KindId</c>: int, null. References <see cref="tblKind"/>.</remarks>
    public virtual int? KindId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLog.html#Alvao_API_Common_Model_Database_tblLog_RemovedByPersonId"/>
    /// <remarks>Column <c>RemovedByPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? RemovedByPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLog.html#Alvao_API_Common_Model_Database_tblLog_RemovedDate"/>
    /// <remarks>Column <c>RemovedDate</c>: datetime, null.</remarks>
    public virtual DateTime? RemovedDate { get; set; }
    /// <summary>date and time</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLog.html#Alvao_API_Common_Model_Database_tblLog_dteLog"/>
    /// <remarks>Column <c>dteLog</c>: datetime, null.</remarks>
    public virtual DateTime? dteLog { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLog.html#Alvao_API_Common_Model_Database_tblLog_intLogId"/>
    /// <remarks>Column <c>intLogId</c>: int, not null.</remarks>
    [Key]
    public virtual int intLogId { get; set; }
    /// <summary>author - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLog.html#Alvao_API_Common_Model_Database_tblLog_liLogPersonId"/>
    /// <remarks>Column <c>liLogPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? liLogPersonId { get; set; }
    /// <summary>detection - tblDetect</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLog.html#Alvao_API_Common_Model_Database_tblLog_lintDetectId"/>
    /// <remarks>Column <c>lintDetectId</c>: int, null. References <see cref="tblDetect"/>.</remarks>
    public virtual int? lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLog.html#Alvao_API_Common_Model_Database_tblLog_lintInventoryId"/>
    /// <remarks>Column <c>lintInventoryId</c>: int, null.</remarks>
    public virtual int? lintInventoryId { get; set; }
    /// <summary>
    /// record type: 0 = unclassified 1 = information 2 = warning 3 = error 4 = property value change 5 = computer is
    /// off 6 = detection file does not exist yet (this is a detection via a shared folder) 7 = data in detection
    /// differs from data in inventory 8 = object cannot be automatically updated according to the detection 9 = hw
    /// detection performed 10 = sw detection performed 11 = inventory performed 12 = duplicate computer name
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLog.html#Alvao_API_Common_Model_Database_tblLog_lintLogKindId"/>
    /// <remarks>Column <c>lintLogKindId</c>: int, null.</remarks>
    public virtual int? lintLogKindId { get; set; }
    /// <summary>object - tblNode</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLog.html#Alvao_API_Common_Model_Database_tblLog_lintNodeId"/>
    /// <remarks>Column <c>lintNodeId</c>: int, null. References <see cref="tblNode"/>.</remarks>
    public virtual int? lintNodeId { get; set; }
    /// <summary>record text</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblLog.html#Alvao_API_Common_Model_Database_tblLog_txtLog"/>
    /// <remarks>Column <c>txtLog</c>: nvarchar(max), null.</remarks>
    public virtual string txtLog { get; set; }
}
