using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>SLA alert type</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketAlertType.htm"/>
[TableAttribute("dbo.TicketAlertType")]
public class TicketAlertType
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketAlertType_TicketAlertTypeId.htm"/>
    public enum TicketAlertTypeId
    {
        Inactive = 0,
        FirstReaction = 1,
        Deadline = 2,
        InternalTarget = 3,
    }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketAlertType_id.htm"/>
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Alert text without parameter</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketAlertType_MsgTemplateNoParams.htm"/>
    public virtual string MsgTemplateNoParams { get; set; }
    /// <summary>Alert text with parameter</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketAlertType_MsgTemplateParam1.htm"/>
    public virtual string MsgTemplateParam1 { get; set; }
    /// <summary>Alert name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketAlertType_Name.htm"/>
    public virtual string Name { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_TicketAlertType__ctor.htm"/>
    public TicketAlertType() { }
}
