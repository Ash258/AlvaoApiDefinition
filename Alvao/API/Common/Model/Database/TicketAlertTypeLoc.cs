using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Language localization cache of SLA alert type, see TicketAlertType
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketAlertTypeLoc.htm"/>
[TableAttribute("dbo.TicketAlertTypeLoc")]
public class TicketAlertTypeLoc
{
    /// <summary>Language ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketAlertTypeLoc_LocaleId.htm"/>
    public virtual int LocaleId { get; set; }
    /// <summary>Localized alert text without parameter</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketAlertTypeLoc_MsgTemplateNoParams.htm"/>
    public virtual string MsgTemplateNoParams { get; set; }
    /// <summary>Localized alert text with parameter</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketAlertTypeLoc_MsgTemplateParam1.htm"/>
    public virtual string MsgTemplateParam1 { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketAlertTypeLoc_TicketAlertTypeId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int TicketAlertTypeId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_TicketAlertTypeLoc__ctor.htm"/>
    public TicketAlertTypeLoc() { }
}
