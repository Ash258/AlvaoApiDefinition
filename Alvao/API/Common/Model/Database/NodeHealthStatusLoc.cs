using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cache of language localizations of object health statuses, see NodeHealthStatus.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeHealthStatusLoc.html"/>
[Table("dbo.NodeHealthStatusLoc")]
public class NodeHealthStatusLoc {
    /// <summary>Localized status description.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeHealthStatusLoc.html#Alvao_API_Common_Model_Database_NodeHealthStatusLoc_Description"/>
    public virtual string Description { get; set; }
    /// <summary>Language ID (tLocale.iLocaleId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeHealthStatusLoc.html#Alvao_API_Common_Model_Database_NodeHealthStatusLoc_LocaleId"/>
    public virtual int LocaleId { get; set; }
    /// <summary>Health status ID (NodeHealthStatus.id).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NodeHealthStatusLoc.html#Alvao_API_Common_Model_Database_NodeHealthStatusLoc_NodeHealthStatusId"/>
    public virtual int NodeHealthStatusId { get; set; }
}
