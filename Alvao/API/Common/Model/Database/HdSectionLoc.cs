using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Cache of service localizations.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_HdSectionLoc.htm"/>
[TableAttribute("dbo.HdSectionLoc")]
public class HdSectionLoc
{
    /// <summary>Localized service name.</summary>
    public virtual string HdSection { get; set; }
    /// <summary>Located short service name.</summary>
    public virtual string HdSectionDesc { get; set; }
    /// <summary>Service ID.</summary>
    [ExplicitKeyAttribute]
    public virtual int HdSectionId { get; set; }
    /// <summary>Localized service keywords.</summary>
    public virtual string HdSectionKeywords { get; set; }
    /// <summary>Record ID.</summary>
    public virtual int HdSectionLocId { get; set; }
    /// <summary>Located short service name.</summary>
    public virtual string HdSectionShort { get; set; }
    /// <summary>Language ID.</summary>
    public virtual int LocaleId { get; set; }

    public HdSectionLoc() { }
}
