using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Cache of tag types localizations.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketTagTypeLoc.htm"/>
[TableAttribute("dbo.TicketTagTypeLoc")]
public class TicketTagTypeLoc
{
    /// <summary>Language ID</summary>
    public virtual int LocaleId { get; set; }
    /// <summary>Localized tag name</summary>
    public virtual string Name { get; set; }
    /// <summary>Id of tag type (see TicketTagType.id)</summary>
    [ExplicitKeyAttribute]
    public virtual int TicketTagTypeId { get; set; }

    public TicketTagTypeLoc() { }
}
