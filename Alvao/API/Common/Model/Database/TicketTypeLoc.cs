using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Cache of process localizations.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketTypeLoc.htm"/>
[TableAttribute("dbo.TicketTypeLoc")]
public class TicketTypeLoc
{
    /// <summary>Language ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTypeLoc_LocaleId.htm"/>
    public virtual int LocaleId { get; set; }
    /// <summary>Localized process name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTypeLoc_TicketType.htm"/>
    public virtual string TicketType { get; set; }
    /// <summary>Localized process description.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTypeLoc_TicketTypeDesc.htm"/>
    public virtual string TicketTypeDesc { get; set; }
    /// <summary>Process ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTypeLoc_TicketTypeId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int TicketTypeId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_TicketTypeLoc__ctor.htm"/>
    public TicketTypeLoc() { }
}
