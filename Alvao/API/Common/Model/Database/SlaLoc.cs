using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Cache of SLA localizations.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_SlaLoc.htm"/>
[TableAttribute("dbo.SlaLoc")]
public class SlaLoc
{
    /// <summary>Language ID.</summary>
    public virtual int LocaleId { get; set; }
    /// <summary>Localized SLA name.</summary>
    public virtual string Sla { get; set; }
    /// <summary>Localized SLA description.</summary>
    public virtual string SlaDesc { get; set; }
    /// <summary>SLA ID.</summary>
    [ExplicitKeyAttribute]
    public virtual int SlaId { get; set; }

    public SlaLoc() { }
}
