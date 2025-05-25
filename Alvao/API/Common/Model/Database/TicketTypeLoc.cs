using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cache of process localizations.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeLoc.html"/>
[Table("dbo.TicketTypeLoc")]
public class TicketTypeLoc {
    /// <summary>Language ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeLoc.html#Alvao_API_Common_Model_Database_TicketTypeLoc_LocaleId"/>
    public virtual int LocaleId { get; set; }
    /// <summary>Localized process name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeLoc.html#Alvao_API_Common_Model_Database_TicketTypeLoc_TicketType"/>
    public virtual string TicketType { get; set; }
    /// <summary>Localized process description.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeLoc.html#Alvao_API_Common_Model_Database_TicketTypeLoc_TicketTypeDesc"/>
    public virtual string TicketTypeDesc { get; set; }
    /// <summary>Process ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeLoc.html#Alvao_API_Common_Model_Database_TicketTypeLoc_TicketTypeId"/>
    [ExplicitKey]
    public virtual int TicketTypeId { get; set; }
}
