using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cache of tag types localizations.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketTagTypeLoc.htm"/>
[TableAttribute("dbo.TicketTagTypeLoc")]
public class TicketTagTypeLoc
{
    /// <summary>Language ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTagTypeLoc_LocaleId.htm"/>
    public virtual int LocaleId { get; set; }
    /// <summary>Localized tag name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTagTypeLoc_Name.htm"/>
    public virtual string Name { get; set; }
    /// <summary>Id of tag type (see TicketTagType.id)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTagTypeLoc_TicketTagTypeId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int TicketTagTypeId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_TicketTagTypeLoc__ctor.htm"/>
    public TicketTagTypeLoc() { }
}
