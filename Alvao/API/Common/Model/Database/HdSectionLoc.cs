using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cache of service localizations.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionLoc.html"/>
[Table("dbo.HdSectionLoc")]
public class HdSectionLoc {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionLoc.html#Alvao_API_Common_Model_Database_HdSectionLoc_DescriptionFieldName"/>
    /// <remarks>Column <c>DescriptionFieldName</c>: nvarchar(255), null.</remarks>
    public virtual string DescriptionFieldName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionLoc.html#Alvao_API_Common_Model_Database_HdSectionLoc_DescriptionHtml"/>
    /// <remarks>Column <c>DescriptionHtml</c>: nvarchar(max), null.</remarks>
    public virtual string DescriptionHtml { get; set; }
    /// <summary>Localized service name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionLoc.html#Alvao_API_Common_Model_Database_HdSectionLoc_HdSection"/>
    /// <remarks>Column <c>HdSection</c>: nvarchar(1024), null.</remarks>
    public virtual string HdSection { get; set; }
    /// <summary>Located short service name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionLoc.html#Alvao_API_Common_Model_Database_HdSectionLoc_HdSectionDesc"/>
    /// <remarks>Column <c>HdSectionDesc</c>: nvarchar(max), null.</remarks>
    public virtual string HdSectionDesc { get; set; }
    /// <summary>Service ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionLoc.html#Alvao_API_Common_Model_Database_HdSectionLoc_HdSectionId"/>
    /// <remarks>Column <c>HdSectionId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int HdSectionId { get; set; }
    /// <summary>Localized service keywords.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionLoc.html#Alvao_API_Common_Model_Database_HdSectionLoc_HdSectionKeywords"/>
    /// <remarks>Column <c>HdSectionKeywords</c>: nvarchar(max), null.</remarks>
    public virtual string HdSectionKeywords { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionLoc.html#Alvao_API_Common_Model_Database_HdSectionLoc_HdSectionLocId"/>
    /// <remarks>Column <c>HdSectionLocId</c>: int, not null.</remarks>
    public virtual int HdSectionLocId { get; set; }
    /// <summary>Located short service name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionLoc.html#Alvao_API_Common_Model_Database_HdSectionLoc_HdSectionShort"/>
    /// <remarks>Column <c>HdSectionShort</c>: nvarchar(255), null.</remarks>
    public virtual string HdSectionShort { get; set; }
    /// <summary>Language ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionLoc.html#Alvao_API_Common_Model_Database_HdSectionLoc_LocaleId"/>
    /// <remarks>Column <c>LocaleId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int LocaleId { get; set; }
    /// <summary>Custom objects field name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionLoc.html#Alvao_API_Common_Model_Database_HdSectionLoc_ObjectsFieldName"/>
    /// <remarks>Column <c>ObjectsFieldName</c>: nvarchar(255), null.</remarks>
    public virtual string ObjectsFieldName { get; set; }
}
