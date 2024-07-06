using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// SLA alert type
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketAlertType.htm"/>
[TableAttribute("dbo.TicketAlertType")]
public class TicketAlertType
{
    public enum TicketAlertTypeId
    {
        Inactive = 0,
        FirstReaction = 1,
        Deadline = 2,
        InternalTarget = 3,
    }


    [ExplicitKeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Alert text without parameter</summary>
    public virtual string MsgTemplateNoParams { get; set; }
    /// <summary>Alert text with parameter</summary>
    public virtual string MsgTemplateParam1 { get; set; }
    /// <summary>Alert name</summary>
    public virtual string Name { get; set; }

    public TicketAlertType() { }
}
