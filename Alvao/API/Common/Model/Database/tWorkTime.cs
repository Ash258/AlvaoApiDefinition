using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Employee attendance record created in the ALVAO Attendance module.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tWorkTime.htm"/>
[TableAttribute("dbo.tWorkTime")]
public class tWorkTime
{
    /// <summary>Time at which the record for starting work was inserted</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWorkTime_dCreated.htm"/>
    public virtual DateTime dCreated { get; set; }
    /// <summary>Time at which the record was last updated</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWorkTime_dModified.htm"/>
    public virtual DateTime dModified { get; set; }
    /// <summary>Time at which the work started</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWorkTime_dStart.htm"/>
    public virtual DateTime dStart { get; set; }
    /// <summary>Time at which work started/finished</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWorkTime_dStop.htm"/>
    public virtual DateTime? dStop { get; set; }
    /// <summary>Time at which the record for finishing work was inserted</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWorkTime_dStopped.htm"/>
    public virtual DateTime? dStopped { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWorkTime_iWorkTimeId.htm"/>
    [KeyAttribute]
    public virtual int iWorkTimeId { get; set; }
    /// <summary>ID of the person that entered the record for starting work</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWorkTime_liCreatedPersonId.htm"/>
    public virtual int? liCreatedPersonId { get; set; }
    /// <summary>ID of the last person to update the record</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWorkTime_liModifiedPersonId.htm"/>
    public virtual int? liModifiedPersonId { get; set; }
    /// <summary>User ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWorkTime_liPersonId.htm"/>
    public virtual int liPersonId { get; set; }
    /// <summary>ID of the person that entered the record for completing work</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWorkTime_liStoppedPersonId.htm"/>
    public virtual int? liStoppedPersonId { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWorkTime_mNotes.htm"/>
    public virtual string mNotes { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tWorkTime__ctor.htm"/>
    public tWorkTime() { }
}
