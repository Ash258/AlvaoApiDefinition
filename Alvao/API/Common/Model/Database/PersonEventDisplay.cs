using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Events viewed by a person.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonEventDisplay.html"/>
[Table("dbo.PersonEventDisplay")]
public class PersonEventDisplay {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonEventDisplay.html#Alvao_API_Common_Model_Database_PersonEventDisplay_ActId"/>
    public virtual int? ActId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonEventDisplay.html#Alvao_API_Common_Model_Database_PersonEventDisplay_Id"/>
    [Key]
    public virtual int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonEventDisplay.html#Alvao_API_Common_Model_Database_PersonEventDisplay_PersonId"/>
    public virtual int? PersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonEventDisplay.html#Alvao_API_Common_Model_Database_PersonEventDisplay_TicketApprovalItemId"/>
    public virtual int? TicketApprovalItemId { get; set; }
}
