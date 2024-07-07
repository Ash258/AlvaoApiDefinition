using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Table with list of paid overtime hours
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_WorkOvertimeDisposal.htm"/>
[TableAttribute("dbo.WorkOvertimeDisposal")]
public class WorkOvertimeDisposal
{
    /// <summary>ID of the person who paid for overtime hours</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_WorkOvertimeDisposal_CreatedByPersonId.htm"/>
    public virtual int CreatedByPersonId { get; set; }
    /// <summary>Date of overtime hour payment</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_WorkOvertimeDisposal_Date.htm"/>
    public virtual DateTime Date { get; set; }
    /// <summary>Number of paid overtime hours</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_WorkOvertimeDisposal_Hours.htm"/>
    public virtual double Hours { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_WorkOvertimeDisposal_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Notes</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_WorkOvertimeDisposal_Notes.htm"/>
    public virtual string Notes { get; set; }
    /// <summary>ID of the person who received payment for overtime hours</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_WorkOvertimeDisposal_PersonId.htm"/>
    public virtual int PersonId { get; set; }
    /// <summary>ID of the person that deleted the record</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_WorkOvertimeDisposal_RemovedByPersonId.htm"/>
    public virtual int? RemovedByPersonId { get; set; }
    /// <summary>Date on which the record was deleted.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_WorkOvertimeDisposal_RemovedDate.htm"/>
    public virtual DateTime? RemovedDate { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_WorkOvertimeDisposal__ctor.htm"/>
    public WorkOvertimeDisposal() { }
}
