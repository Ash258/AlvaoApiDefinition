using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Events viewed by a person.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_PersonEventDisplay.htm"/>
[TableAttribute("dbo.PersonEventDisplay")]
public class PersonEventDisplay
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_PersonEventDisplay_ActId.htm"/>
    public virtual int? ActId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_PersonEventDisplay_Id.htm"/>
    [KeyAttribute]
    public virtual int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_PersonEventDisplay_PersonId.htm"/>
    public virtual int? PersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_PersonEventDisplay_TicketApprovalItemId.htm"/>
    public virtual int? TicketApprovalItemId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_PersonEventDisplay__ctor.htm"/>
    public PersonEventDisplay() { }
}
