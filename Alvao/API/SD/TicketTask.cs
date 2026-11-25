namespace Alvao.API.SD;

/// <summary>Facade class grouping ticket tasks methods.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.TicketTask.html"/>
public static class TicketTask {
    /// <summary>Marks the specified ticket task as complete asynchronously.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.TicketTask.html#Alvao_API_SD_TicketTask_CompleteAsync_System_Int32_System_Threading_CancellationToken_"/>
    /// <param name="taskId">The identifier of the ticket task to complete.</param>
    /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public static Task CompleteAsync(int taskId, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
    /// <summary>Creates a new ticket task</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.TicketTask.html#Alvao_API_SD_TicketTask_CreateAsync_Alvao_API_Common_Model_Database_TicketTask_System_Threading_CancellationToken_"/>
    /// <param name="ticketTask">Ticket task to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <exception cref="ArgumentNullException">Throws when ticketTask is null.</exception>
    /// <exception cref="ArgumentException">Throws when Title is null or empty.</exception>
    /// <returns>Created ticket task ID (TicketTask.id)</returns>
    public static Task<int> CreateAsync(Alvao.API.Common.Model.Database.TicketTask ticketTask, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
    /// <summary>Gets all ticket tasks for ticket (synchronous wrapper)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.TicketTask.html#Alvao_API_SD_TicketTask_GetAllForTicket_System_Int32_"/>
    /// <param name="ticketId">Ticket ID (tHdTicket.iHdTicketId)</param>
    /// <returns>Collection of ticket tasks</returns>
    public static IEnumerable<Alvao.API.Common.Model.Database.TicketTask> GetAllForTicket(int ticketId) { throw new NotImplementedException(); }
    /// <summary>Gets all ticket tasks for ticket</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.TicketTask.html#Alvao_API_SD_TicketTask_GetAllForTicketAsync_System_Int32_System_Threading_CancellationToken_"/>
    /// <param name="ticketId">Ticket ID (tHdTicket.iHdTicketId)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Collection of ticket tasks</returns>
    public static Task<IEnumerable<Alvao.API.Common.Model.Database.TicketTask>> GetAllForTicketAsync(int ticketId, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
    /// <summary>Gets ticket task by ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.TicketTask.html#Alvao_API_SD_TicketTask_GetByIdAsync_System_Int32_System_Threading_CancellationToken_"/>
    /// <param name="id">Ticket task ID (TicketTask.id)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Ticket task object (TicketTask)</returns>
    public static Task<Alvao.API.Common.Model.Database.TicketTask> GetByIdAsync(int id, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
    /// <summary>Removes a ticket task by ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.TicketTask.html#Alvao_API_SD_TicketTask_RemoveAsync_System_Int32_System_Threading_CancellationToken_"/>
    /// <param name="id">Ticket task ID (TicketTask.id)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <exception cref="InvalidOperationException">Throws when ticket task does not exist.</exception>
    public static Task RemoveAsync(int id, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
    /// <summary>Asynchronously reopens a ticket task with the specified ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.TicketTask.html#Alvao_API_SD_TicketTask_ReopenAsync_System_Int32_System_Threading_CancellationToken_"/>
    /// <param name="taskId">The ID of the ticket task to reopen.</param>
    /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public static Task ReopenAsync(int taskId, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
    /// <summary>Sets the display order for a specified task asynchronously.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.TicketTask.html#Alvao_API_SD_TicketTask_SetDisplayOrder_System_Int32_System_Int32_System_Threading_CancellationToken_"/>
    /// <param name="taskId">The identifier of the task to update.</param>
    /// <param name="displayOrder">The new display order value to assign.</param>
    /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public static Task SetDisplayOrder(int taskId, int displayOrder, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
    /// <summary>Asynchronously sets the due date for a specified task.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.TicketTask.html#Alvao_API_SD_TicketTask_SetDueDateAsync_System_Int32_System_Nullable_System_DateTime__System_Threading_CancellationToken_"/>
    /// <param name="taskId">The identifier of the task to update.</param>
    /// <param name="dueDate">The new due date to assign to the task, or null to clear the due date.</param>
    /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public static Task SetDueDateAsync(int taskId, DateTime? dueDate, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
    /// <summary>Updates an existing ticket task</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.TicketTask.html#Alvao_API_SD_TicketTask_UpdateAsync_Alvao_API_Common_Model_Database_TicketTask_System_Threading_CancellationToken_"/>
    /// <param name="ticketTask">Ticket task to update</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <exception cref="ArgumentNullException">Throws when ticketTask is null.</exception>
    /// <exception cref="ArgumentException">Throws when Title is null or empty.</exception>
    /// <exception cref="InvalidOperationException">Throws when ticket task does not exist.</exception>
    public static Task UpdateAsync(Alvao.API.Common.Model.Database.TicketTask ticketTask, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
}
