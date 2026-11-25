using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Events viewed by a person.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PersonEventDisplay.html"/>
[Table("dbo.PersonEventDisplay")]
public class PersonEventDisplay {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PersonEventDisplay.html#Alvao_API_Common_Model_Database_PersonEventDisplay_ActId"/>
    /// <remarks>Column <c>ActId</c>: int, null. References <see cref="tAct"/>.</remarks>
    public virtual int? ActId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PersonEventDisplay.html#Alvao_API_Common_Model_Database_PersonEventDisplay_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [Key]
    public virtual int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PersonEventDisplay.html#Alvao_API_Common_Model_Database_PersonEventDisplay_PersonId"/>
    /// <remarks>Column <c>PersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? PersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PersonEventDisplay.html#Alvao_API_Common_Model_Database_PersonEventDisplay_TicketApprovalItemId"/>
    /// <remarks>
    /// Column <c>TicketApprovalItemId</c>: int, null. References <see cref="tHdTicketApprovalItem"/>.
    /// </remarks>
    public virtual int? TicketApprovalItemId { get; set; }
}
