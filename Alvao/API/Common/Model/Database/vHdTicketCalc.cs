using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Information whether the ticket can indeed be reopened.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicketCalc.html"/>
[Table("dbo.vHdTicketCalc")]
public class vHdTicketCalc {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicketCalc.html#Alvao_API_Common_Model_Database_vHdTicketCalc_bHdTicketUserOpenProtected"/>
    public virtual int bHdTicketUserOpenProtected { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicketCalc.html#Alvao_API_Common_Model_Database_vHdTicketCalc_iHdTicketId"/>
    public virtual int iHdTicketId { get; set; }
}
