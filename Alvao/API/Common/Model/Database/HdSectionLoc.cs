using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cache of service localizations.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionLoc.html"/>
[Table("dbo.HdSectionLoc")]
public class HdSectionLoc {
    /// <summary>Localized service name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionLoc.html#Alvao_API_Common_Model_Database_HdSectionLoc_HdSection"/>
    public virtual string HdSection { get; set; }
    /// <summary>Located short service name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionLoc.html#Alvao_API_Common_Model_Database_HdSectionLoc_HdSectionDesc"/>
    public virtual string HdSectionDesc { get; set; }
    /// <summary>Service ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionLoc.html#Alvao_API_Common_Model_Database_HdSectionLoc_HdSectionId"/>
    [ExplicitKey]
    public virtual int HdSectionId { get; set; }
    /// <summary>Localized service keywords.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionLoc.html#Alvao_API_Common_Model_Database_HdSectionLoc_HdSectionKeywords"/>
    public virtual string HdSectionKeywords { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionLoc.html#Alvao_API_Common_Model_Database_HdSectionLoc_HdSectionLocId"/>
    public virtual int HdSectionLocId { get; set; }
    /// <summary>Located short service name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionLoc.html#Alvao_API_Common_Model_Database_HdSectionLoc_HdSectionShort"/>
    public virtual string HdSectionShort { get; set; }
    /// <summary>Language ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionLoc.html#Alvao_API_Common_Model_Database_HdSectionLoc_LocaleId"/>
    public virtual int LocaleId { get; set; }
}
