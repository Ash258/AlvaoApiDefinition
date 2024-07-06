using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// List of approval step statuses.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tHdTicketApprovalItemResult.htm"/>
[TableAttribute("dbo.tHdTicketApprovalItemResult")]
public class tHdTicketApprovalItemResult
{
    [ExplicitKeyAttribute]
    public virtual int iHdTicketApprovalItemResultId { get; set; }
    public virtual string sHdTicketApprovalItemResult { get; set; }

    public tHdTicketApprovalItemResult() { }
}
