using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cache of SLA localizations.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaLoc.html"/>
[Table("dbo.SlaLoc")]
public class SlaLoc {
    /// <summary>Language ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaLoc.html#Alvao_API_Common_Model_Database_SlaLoc_LocaleId"/>
    /// <remarks>Column <c>LocaleId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int LocaleId { get; set; }
    /// <summary>Localized SLA name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaLoc.html#Alvao_API_Common_Model_Database_SlaLoc_Sla"/>
    /// <remarks>Column <c>Sla</c>: nvarchar(255), null.</remarks>
    public virtual string Sla { get; set; }
    /// <summary>Localized SLA description.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaLoc.html#Alvao_API_Common_Model_Database_SlaLoc_SlaDesc"/>
    /// <remarks>Column <c>SlaDesc</c>: nvarchar(max), null.</remarks>
    public virtual string SlaDesc { get; set; }
    /// <summary>SLA ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaLoc.html#Alvao_API_Common_Model_Database_SlaLoc_SlaId"/>
    /// <remarks>Column <c>SlaId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int SlaId { get; set; }
}
