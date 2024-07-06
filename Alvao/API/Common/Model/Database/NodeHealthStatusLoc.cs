using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Cache of language localizations of object health statuses, see NodeHealthStatus.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_NodeHealthStatusLoc.htm"/>
[TableAttribute("dbo.NodeHealthStatusLoc")]
public class NodeHealthStatusLoc
{
    /// <summary>Localized status description.</summary>
    public virtual string Description { get; set; }
    /// <summary>Language ID (tLocale.iLocaleId).</summary>
    public virtual int LocaleId { get; set; }
    /// <summary>Health status ID (NodeHealthStatus.id).</summary>
    public virtual int NodeHealthStatusId { get; set; }

    public NodeHealthStatusLoc() { }
}
