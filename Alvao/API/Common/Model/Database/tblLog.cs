using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Log - changes in the properties values and information on the detection results.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblLog.htm"/>
[TableAttribute("dbo.tblLog")]
public class tblLog
{
    /// <summary>date and time</summary>
    public virtual DateTime? dteLog { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int intLogId { get; set; }
    /// <summary>ID of the property definition related to the change.</summary>
    public virtual int? KindId { get; set; }
    /// <summary>author - tPerson</summary>
    public virtual int? liLogPersonId { get; set; }
    /// <summary>detection - tblDetect</summary>
    public virtual int? lintDetectId { get; set; }
    /// <summary>inventory - tblInventory</summary>
    public virtual int? lintInventoryId { get; set; }
    /// <summary>record type:0 = unclassified1 = information2 = warning3 = error4 = property value change5 = computer is off6 = detection file does not exist yet (this is a detection via a shared folder)7 = data in detection differs from data in inventory8 = object cannot be automatically updated according to the detection9 = hw detection performed10 = sw detection performed11 = inventory performed12 = duplicate computer name</summary>
    public virtual int? lintLogKindId { get; set; }
    /// <summary>object - tblNode</summary>
    public virtual int? lintNodeId { get; set; }
    public virtual int? RemovedByPersonId { get; set; }
    public virtual DateTime? RemovedDate { get; set; }
    /// <summary>record text</summary>
    public virtual string txtLog { get; set; }

    public tblLog() { }
}
