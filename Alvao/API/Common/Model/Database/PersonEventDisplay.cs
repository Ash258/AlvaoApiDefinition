using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Events viewed by a person.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_PersonEventDisplay.htm"/>
[TableAttribute("dbo.PersonEventDisplay")]
public class PersonEventDisplay
{
    public virtual int? ActId { get; set; }
    [KeyAttribute]
    public virtual int Id { get; set; }
    public virtual int? PersonId { get; set; }
    public virtual int? TicketApprovalItemId { get; set; }

    public PersonEventDisplay() { }
}
