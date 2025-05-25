using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Table with list of paid overtime hours</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.WorkOvertimeDisposal.html"/>
[Table("dbo.WorkOvertimeDisposal")]
public class WorkOvertimeDisposal {
    /// <summary>ID of the person who paid for overtime hours</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.WorkOvertimeDisposal.html#Alvao_API_Common_Model_Database_WorkOvertimeDisposal_CreatedByPersonId"/>
    public virtual int CreatedByPersonId { get; set; }
    /// <summary>Date of overtime hour payment</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.WorkOvertimeDisposal.html#Alvao_API_Common_Model_Database_WorkOvertimeDisposal_Date"/>
    public virtual DateTime Date { get; set; }
    /// <summary>Number of paid overtime hours</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.WorkOvertimeDisposal.html#Alvao_API_Common_Model_Database_WorkOvertimeDisposal_Hours"/>
    public virtual double Hours { get; set; }
    /// <summary>Notes</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.WorkOvertimeDisposal.html#Alvao_API_Common_Model_Database_WorkOvertimeDisposal_Notes"/>
    public virtual string Notes { get; set; }
    /// <summary>ID of the person who received payment for overtime hours</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.WorkOvertimeDisposal.html#Alvao_API_Common_Model_Database_WorkOvertimeDisposal_PersonId"/>
    public virtual int PersonId { get; set; }
    /// <summary>ID of the person that deleted the record</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.WorkOvertimeDisposal.html#Alvao_API_Common_Model_Database_WorkOvertimeDisposal_RemovedByPersonId"/>
    public virtual int? RemovedByPersonId { get; set; }
    /// <summary>Date on which the record was deleted.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.WorkOvertimeDisposal.html#Alvao_API_Common_Model_Database_WorkOvertimeDisposal_RemovedDate"/>
    public virtual DateTime? RemovedDate { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.WorkOvertimeDisposal.html#Alvao_API_Common_Model_Database_WorkOvertimeDisposal_id"/>
    [Key]
    public virtual int id { get; set; }
}
