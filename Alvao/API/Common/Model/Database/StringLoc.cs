using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Cache of text string localizations.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_StringLoc.htm"/>
[TableAttribute("dbo.StringLoc")]
public class StringLoc
{
    /// <summary>Language ID.</summary>
    public virtual int LocaleId { get; set; }
    /// <summary>Localized string text.</summary>
    public virtual string String { get; set; }
    /// <summary>Text string ID.</summary>
    [ExplicitKeyAttribute]
    public virtual int StringId { get; set; }

    public StringLoc() { }
}
