using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cache of service localizations.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_HdSectionLoc.htm"/>
[TableAttribute("dbo.HdSectionLoc")]
public class HdSectionLoc
{
    /// <summary>Localized service name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionLoc_HdSection.htm"/>
    public virtual string HdSection { get; set; }
    /// <summary>Located short service name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionLoc_HdSectionDesc.htm"/>
    public virtual string HdSectionDesc { get; set; }
    /// <summary>Service ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionLoc_HdSectionId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int HdSectionId { get; set; }
    /// <summary>Localized service keywords.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionLoc_HdSectionKeywords.htm"/>
    public virtual string HdSectionKeywords { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionLoc_HdSectionLocId.htm"/>
    public virtual int HdSectionLocId { get; set; }
    /// <summary>Located short service name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionLoc_HdSectionShort.htm"/>
    public virtual string HdSectionShort { get; set; }
    /// <summary>Language ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionLoc_LocaleId.htm"/>
    public virtual int LocaleId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_HdSectionLoc__ctor.htm"/>
    public HdSectionLoc() { }
}
