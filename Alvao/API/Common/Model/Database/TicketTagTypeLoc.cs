using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cache of tag types localizations.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTagTypeLoc.html"/>
[Table("dbo.TicketTagTypeLoc")]
public class TicketTagTypeLoc {
    /// <summary>Language ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTagTypeLoc.html#Alvao_API_Common_Model_Database_TicketTagTypeLoc_LocaleId"/>
    public virtual int LocaleId { get; set; }
    /// <summary>Localized tag name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTagTypeLoc.html#Alvao_API_Common_Model_Database_TicketTagTypeLoc_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Id of tag type (see TicketTagType.id)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTagTypeLoc.html#Alvao_API_Common_Model_Database_TicketTagTypeLoc_TicketTagTypeId"/>
    [ExplicitKey]
    public virtual int TicketTagTypeId { get; set; }
}
