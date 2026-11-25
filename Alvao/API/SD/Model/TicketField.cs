namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.TicketField.html"/>
[Flags]
public enum TicketField {
    Account = 64,
    AllFields = GeneralFields | UserFields | DetailFields,
    Created = 8192,
    Deadline = 4,
    DetailFields = Section | Sla | Priority | Created | DeviceNumber,
    DeviceNumber = 16384,
    GeneralFields = MessageTag | Name | Deadline | SolverGroup | Solver,
    MessageTag = 1,
    Name = 2,
    None = 0,
    Priority = 4096,
    Section = 1024,
    Sla = 2048,
    Solver = 16,
    SolverGroup = 8,
    User = 32,
    UserEmail = 128,
    UserFields = User | Account | UserEmail | UserPhone | UserMobile,
    UserMobile = 512,
    UserPhone = 256,
}
