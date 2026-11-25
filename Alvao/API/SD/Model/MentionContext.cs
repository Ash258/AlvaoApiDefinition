namespace Alvao.API.SD.Model;

/// <summary>
/// Defines the operation context in which a @mention was made. Used to select operation-specific notification text for
/// email and Teams.
/// </summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.MentionContext.html"/>
public enum MentionContext {
    AssignToSolver = 5,
    MoveToService = 4,
    NewTicketDescription = 0,
    Note = 2,
    Reopen = 7,
    Resolve = 1,
    SendMessage = 6,
    SetDueDate = 3,
}
