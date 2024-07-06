using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Employee attendance record created in the ALVAO Attendance module.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tWorkTime.htm"/>
[TableAttribute("dbo.tWorkTime")]
public class tWorkTime
{
    /// <summary>Time at which the record for starting work was inserted</summary>
    public virtual DateTime dCreated { get; set; }
    /// <summary>Time at which the record was last updated</summary>
    public virtual DateTime dModified { get; set; }
    /// <summary>Time at which the work started</summary>
    public virtual DateTime dStart { get; set; }
    /// <summary>Time at which work started/finished</summary>
    public virtual DateTime? dStop { get; set; }
    /// <summary>Time at which the record for finishing work was inserted</summary>
    public virtual DateTime? dStopped { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int iWorkTimeId { get; set; }
    /// <summary>ID of the person that entered the record for starting work</summary>
    public virtual int? liCreatedPersonId { get; set; }
    /// <summary>ID of the last person to update the record</summary>
    public virtual int? liModifiedPersonId { get; set; }
    /// <summary>User ID</summary>
    public virtual int liPersonId { get; set; }
    /// <summary>ID of the person that entered the record for completing work</summary>
    public virtual int? liStoppedPersonId { get; set; }
    /// <summary>Note</summary>
    public virtual string mNotes { get; set; }

    public tWorkTime() { }
}
