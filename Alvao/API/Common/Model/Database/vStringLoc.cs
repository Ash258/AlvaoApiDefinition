using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// List of strings from ALVAO applications in all used languages.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vStringLoc.htm"/>
[TableAttribute("dbo.vStringLoc")]
public class vStringLoc
{
    /// <summary>String ID.</summary>
    public virtual int iStringId { get; set; }
    /// <summary>Localized string.</summary>
    public virtual string LocalizedString { get; set; }
    /// <summary>String.</summary>
    public virtual string mString { get; set; }
    /// <summary>Language localization ID.</summary>
    public virtual int StringLocaleId { get; set; }

    public vStringLoc() { }
}
