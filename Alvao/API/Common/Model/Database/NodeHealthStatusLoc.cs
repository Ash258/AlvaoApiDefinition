using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cache of language localizations of object health statuses, see NodeHealthStatus.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeHealthStatusLoc.html"/>
[Table("dbo.NodeHealthStatusLoc")]
public class NodeHealthStatusLoc {
    /// <summary>Localized status description.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeHealthStatusLoc.html#Alvao_API_Common_Model_Database_NodeHealthStatusLoc_Description"/>
    /// <remarks>Column <c>Description</c>: nvarchar(max), null.</remarks>
    public virtual string Description { get; set; }
    /// <summary>Language ID (tLocale.iLocaleId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeHealthStatusLoc.html#Alvao_API_Common_Model_Database_NodeHealthStatusLoc_LocaleId"/>
    /// <remarks>Column <c>LocaleId</c>: int, not null. References <see cref="tLocale"/>.</remarks>
    public virtual int LocaleId { get; set; }
    /// <summary>Health status ID (NodeHealthStatus.id).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeHealthStatusLoc.html#Alvao_API_Common_Model_Database_NodeHealthStatusLoc_NodeHealthStatusId"/>
    /// <remarks>Column <c>NodeHealthStatusId</c>: int, not null. References <see cref="NodeHealthStatus"/>.</remarks>
    public virtual int NodeHealthStatusId { get; set; }
}
