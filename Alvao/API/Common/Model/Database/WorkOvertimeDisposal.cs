using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Table with list of paid overtime hours</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.WorkOvertimeDisposal.html"/>
[Table("dbo.WorkOvertimeDisposal")]
public class WorkOvertimeDisposal {
    /// <summary>ID of the person who paid for overtime hours</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.WorkOvertimeDisposal.html#Alvao_API_Common_Model_Database_WorkOvertimeDisposal_CreatedByPersonId"/>
    /// <remarks>Column <c>CreatedByPersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int CreatedByPersonId { get; set; }
    /// <summary>Date of overtime hour payment</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.WorkOvertimeDisposal.html#Alvao_API_Common_Model_Database_WorkOvertimeDisposal_Date"/>
    /// <remarks>Column <c>Date</c>: datetime, not null.</remarks>
    public virtual DateTime Date { get; set; }
    /// <summary>Number of paid overtime hours</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.WorkOvertimeDisposal.html#Alvao_API_Common_Model_Database_WorkOvertimeDisposal_Hours"/>
    /// <remarks>Column <c>Hours</c>: float, not null.</remarks>
    public virtual double Hours { get; set; }
    /// <summary>Notes</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.WorkOvertimeDisposal.html#Alvao_API_Common_Model_Database_WorkOvertimeDisposal_Notes"/>
    /// <remarks>Column <c>Notes</c>: nvarchar(max), null.</remarks>
    public virtual string Notes { get; set; }
    /// <summary>ID of the person who received payment for overtime hours</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.WorkOvertimeDisposal.html#Alvao_API_Common_Model_Database_WorkOvertimeDisposal_PersonId"/>
    /// <remarks>Column <c>PersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int PersonId { get; set; }
    /// <summary>ID of the person that deleted the record</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.WorkOvertimeDisposal.html#Alvao_API_Common_Model_Database_WorkOvertimeDisposal_RemovedByPersonId"/>
    /// <remarks>Column <c>RemovedByPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? RemovedByPersonId { get; set; }
    /// <summary>Date on which the record was deleted.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.WorkOvertimeDisposal.html#Alvao_API_Common_Model_Database_WorkOvertimeDisposal_RemovedDate"/>
    /// <remarks>Column <c>RemovedDate</c>: datetime, null.</remarks>
    public virtual DateTime? RemovedDate { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.WorkOvertimeDisposal.html#Alvao_API_Common_Model_Database_WorkOvertimeDisposal_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
