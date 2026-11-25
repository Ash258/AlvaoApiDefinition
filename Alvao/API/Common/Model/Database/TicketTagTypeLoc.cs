using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cache of tag types localizations.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTagTypeLoc.html"/>
[Table("dbo.TicketTagTypeLoc")]
public class TicketTagTypeLoc {
    /// <summary>Language ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTagTypeLoc.html#Alvao_API_Common_Model_Database_TicketTagTypeLoc_LocaleId"/>
    /// <remarks>Column <c>LocaleId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int LocaleId { get; set; }
    /// <summary>Localized tag name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTagTypeLoc.html#Alvao_API_Common_Model_Database_TicketTagTypeLoc_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(70), not null.</remarks>
    public virtual string Name { get; set; }
    /// <summary>Id of tag type (see TicketTagType.id)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTagTypeLoc.html#Alvao_API_Common_Model_Database_TicketTagTypeLoc_TicketTagTypeId"/>
    /// <remarks>Column <c>TicketTagTypeId</c>: int, not null. References <see cref="TicketTagType"/>.</remarks>
    [ExplicitKey]
    public virtual int TicketTagTypeId { get; set; }
}
