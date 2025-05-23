using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>List of processes used in all used languages.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vTicketTypeLoc.htm"/>
[TableAttribute("dbo.vTicketTypeLoc")]
public class vTicketTypeLoc
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketTypeLoc_BackResolveDeadlineHours.htm"/>
    public virtual double? BackResolveDeadlineHours { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketTypeLoc_CustomField1.htm"/>
    public virtual int? CustomField1 { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketTypeLoc_Description.htm"/>
    public virtual string Description { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketTypeLoc_id.htm"/>
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketTypeLoc_LocalizedType.htm"/>
    public virtual string LocalizedType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketTypeLoc_TicketType.htm"/>
    public virtual string TicketType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketTypeLoc_TicketTypeBehaviorId.htm"/>
    public virtual int TicketTypeBehaviorId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketTypeLoc_TicketTypeLocaleId.htm"/>
    public virtual int TicketTypeLocaleId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vTicketTypeLoc__ctor.htm"/>
    public vTicketTypeLoc() { }
}
