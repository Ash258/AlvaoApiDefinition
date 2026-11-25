using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Method of setting the requester while creating linked tickets, see RelatedTicketRule.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRuleRequesterMode.html"/>
[Table("dbo.RelatedTicketRuleRequesterMode")]
public class RelatedTicketRuleRequesterMode {
    /// <summary>Record description</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRuleRequesterMode.html#Alvao_API_Common_Model_Database_RelatedTicketRuleRequesterMode_Description"/>
    /// <remarks>Column <c>Description</c>: nvarchar(1024), null.</remarks>
    public virtual string Description { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRuleRequesterMode.html#Alvao_API_Common_Model_Database_RelatedTicketRuleRequesterMode_id"/>
    /// <remarks>Column <c>id</c>: tinyint, not null.</remarks>
    [ExplicitKey]
    public virtual byte id { get; set; }
}
