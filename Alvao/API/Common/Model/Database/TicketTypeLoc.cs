using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cache of process localizations.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeLoc.html"/>
[Table("dbo.TicketTypeLoc")]
public class TicketTypeLoc {
    /// <summary>Language ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeLoc.html#Alvao_API_Common_Model_Database_TicketTypeLoc_LocaleId"/>
    /// <remarks>Column <c>LocaleId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int LocaleId { get; set; }
    /// <summary>Localized process name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeLoc.html#Alvao_API_Common_Model_Database_TicketTypeLoc_TicketType"/>
    /// <remarks>Column <c>TicketType</c>: nvarchar(255), null.</remarks>
    public virtual string TicketType { get; set; }
    /// <summary>Localized process description.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeLoc.html#Alvao_API_Common_Model_Database_TicketTypeLoc_TicketTypeDesc"/>
    /// <remarks>Column <c>TicketTypeDesc</c>: nvarchar(max), null.</remarks>
    public virtual string TicketTypeDesc { get; set; }
    /// <summary>Process ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeLoc.html#Alvao_API_Common_Model_Database_TicketTypeLoc_TicketTypeId"/>
    /// <remarks>Column <c>TicketTypeId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int TicketTypeId { get; set; }
}
