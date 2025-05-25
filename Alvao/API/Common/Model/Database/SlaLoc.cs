using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cache of SLA localizations.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaLoc.html"/>
[Table("dbo.SlaLoc")]
public class SlaLoc {
    /// <summary>Language ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaLoc.html#Alvao_API_Common_Model_Database_SlaLoc_LocaleId"/>
    public virtual int LocaleId { get; set; }
    /// <summary>Localized SLA name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaLoc.html#Alvao_API_Common_Model_Database_SlaLoc_Sla"/>
    public virtual string Sla { get; set; }
    /// <summary>Localized SLA description.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaLoc.html#Alvao_API_Common_Model_Database_SlaLoc_SlaDesc"/>
    public virtual string SlaDesc { get; set; }
    /// <summary>SLA ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaLoc.html#Alvao_API_Common_Model_Database_SlaLoc_SlaId"/>
    [ExplicitKey]
    public virtual int SlaId { get; set; }
}
