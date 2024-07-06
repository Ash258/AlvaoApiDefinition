using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Information whether the ticket can indeed be reopened.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vHdTicketCalc.htm"/>
[TableAttribute("dbo.vHdTicketCalc")]
public class vHdTicketCalc
{
    public virtual int bHdTicketUserOpenProtected { get; set; }
    public virtual int iHdTicketId { get; set; }

    public vHdTicketCalc() { }
}
