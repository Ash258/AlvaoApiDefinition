using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Tasks for tickets</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTask.html"/>
[Table("dbo.TicketTask")]
public class TicketTask {
    /// <summary>ID of the person who completed the task (tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTask.html#Alvao_API_Common_Model_Database_TicketTask_CompletedByPersonId"/>
    /// <remarks>Column <c>CompletedByPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? CompletedByPersonId { get; set; }
    /// <summary>Date and time when the task was completed (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTask.html#Alvao_API_Common_Model_Database_TicketTask_CompletedDate"/>
    /// <remarks>Column <c>CompletedDate</c>: datetime, null.</remarks>
    public virtual DateTime? CompletedDate { get; set; }
    /// <summary>ID of the person who created the task (tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTask.html#Alvao_API_Common_Model_Database_TicketTask_CreatedByPersonId"/>
    /// <remarks>Column <c>CreatedByPersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int CreatedByPersonId { get; set; }
    /// <summary>Date and time when the task was created (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTask.html#Alvao_API_Common_Model_Database_TicketTask_CreatedDate"/>
    /// <remarks>Column <c>CreatedDate</c>: datetime, not null.</remarks>
    public virtual DateTime CreatedDate { get; set; }
    /// <summary>Display order of the task</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTask.html#Alvao_API_Common_Model_Database_TicketTask_DisplayOrder"/>
    /// <remarks>Column <c>DisplayOrder</c>: int, null.</remarks>
    public virtual int? DisplayOrder { get; set; }
    /// <summary>The date and time of the deadline (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTask.html#Alvao_API_Common_Model_Database_TicketTask_DueDate"/>
    /// <remarks>Column <c>DueDate</c>: datetime, null.</remarks>
    public virtual DateTime? DueDate { get; set; }
    /// <summary>Indicates if the task has the closest deadline</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTask.html#Alvao_API_Common_Model_Database_TicketTask_IsCurrent"/>
    /// <remarks>Column <c>IsCurrent</c>: bit, not null.</remarks>
    public virtual bool IsCurrent { get; set; }
    /// <summary>ID of the person who removed the task (tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTask.html#Alvao_API_Common_Model_Database_TicketTask_RemovedByPersonId"/>
    /// <remarks>Column <c>RemovedByPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? RemovedByPersonId { get; set; }
    /// <summary>Date and time when the task was removed (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTask.html#Alvao_API_Common_Model_Database_TicketTask_RemovedDate"/>
    /// <remarks>Column <c>RemovedDate</c>: datetime, null.</remarks>
    public virtual DateTime? RemovedDate { get; set; }
    /// <summary>ID of the person assigned to solve the task (tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTask.html#Alvao_API_Common_Model_Database_TicketTask_SolverPersonId"/>
    /// <remarks>Column <c>SolverPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? SolverPersonId { get; set; }
    /// <summary>Ticket ID (tHdTicket.iHdTicketId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTask.html#Alvao_API_Common_Model_Database_TicketTask_TicketId"/>
    /// <remarks>Column <c>TicketId</c>: int, not null. References <see cref="tHdTicket"/>.</remarks>
    public virtual int TicketId { get; set; }
    /// <summary>Task title</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTask.html#Alvao_API_Common_Model_Database_TicketTask_Title"/>
    /// <remarks>Column <c>Title</c>: nvarchar(1024), not null.</remarks>
    public virtual string Title { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTask.html#Alvao_API_Common_Model_Database_TicketTask_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
