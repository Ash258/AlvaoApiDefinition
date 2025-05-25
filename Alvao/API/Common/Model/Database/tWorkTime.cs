using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Employee attendance record created in the ALVAO Attendance module.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWorkTime.html"/>
[Table("dbo.tWorkTime")]
public class tWorkTime {
    /// <summary>Time at which the record for starting work was inserted</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWorkTime.html#Alvao_API_Common_Model_Database_tWorkTime_dCreated"/>
    public virtual DateTime dCreated { get; set; }
    /// <summary>Time at which the record was last updated</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWorkTime.html#Alvao_API_Common_Model_Database_tWorkTime_dModified"/>
    public virtual DateTime dModified { get; set; }
    /// <summary>Time at which the work started</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWorkTime.html#Alvao_API_Common_Model_Database_tWorkTime_dStart"/>
    public virtual DateTime dStart { get; set; }
    /// <summary>Time at which work started/finished</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWorkTime.html#Alvao_API_Common_Model_Database_tWorkTime_dStop"/>
    public virtual DateTime? dStop { get; set; }
    /// <summary>Time at which the record for finishing work was inserted</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWorkTime.html#Alvao_API_Common_Model_Database_tWorkTime_dStopped"/>
    public virtual DateTime? dStopped { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWorkTime.html#Alvao_API_Common_Model_Database_tWorkTime_iWorkTimeId"/>
    [Key]
    public virtual int iWorkTimeId { get; set; }
    /// <summary>ID of the person that entered the record for starting work</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWorkTime.html#Alvao_API_Common_Model_Database_tWorkTime_liCreatedPersonId"/>
    public virtual int? liCreatedPersonId { get; set; }
    /// <summary>ID of the last person to update the record</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWorkTime.html#Alvao_API_Common_Model_Database_tWorkTime_liModifiedPersonId"/>
    public virtual int? liModifiedPersonId { get; set; }
    /// <summary>User ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWorkTime.html#Alvao_API_Common_Model_Database_tWorkTime_liPersonId"/>
    public virtual int liPersonId { get; set; }
    /// <summary>ID of the person that entered the record for completing work</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWorkTime.html#Alvao_API_Common_Model_Database_tWorkTime_liStoppedPersonId"/>
    public virtual int? liStoppedPersonId { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tWorkTime.html#Alvao_API_Common_Model_Database_tWorkTime_mNotes"/>
    public virtual string mNotes { get; set; }
}
