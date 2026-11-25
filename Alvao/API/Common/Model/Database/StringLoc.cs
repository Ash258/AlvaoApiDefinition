using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cache of text string localizations.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.StringLoc.html"/>
[Table("dbo.StringLoc")]
public class StringLoc {
    /// <summary>Language ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.StringLoc.html#Alvao_API_Common_Model_Database_StringLoc_LocaleId"/>
    /// <remarks>Column <c>LocaleId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int LocaleId { get; set; }
    /// <summary>Localized string text.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.StringLoc.html#Alvao_API_Common_Model_Database_StringLoc_String"/>
    /// <remarks>Column <c>String</c>: nvarchar(max), null.</remarks>
    public virtual string String { get; set; }
    /// <summary>Text string ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.StringLoc.html#Alvao_API_Common_Model_Database_StringLoc_StringId"/>
    /// <remarks>Column <c>StringId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int StringId { get; set; }
}
