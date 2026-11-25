using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Language environments.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tLocale.html"/>
[Table("dbo.tLocale")]
public class tLocale {
    /// <summary>Culture code of the language.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tLocale.html#Alvao_API_Common_Model_Database_tLocale_CultureCode"/>
    /// <remarks>Column <c>CultureCode</c>: nvarchar(16), not null.</remarks>
    public virtual string CultureCode { get; set; }
    /// <summary>If set to 1, the language is used and is displayed in menus.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tLocale.html#Alvao_API_Common_Model_Database_tLocale_bLocaleEnabled"/>
    /// <remarks>Column <c>bLocaleEnabled</c>: bit, not null.</remarks>
    public virtual bool bLocaleEnabled { get; set; }
    /// <summary>
    /// Locale ID. The list of these, for example, can be found here
    /// http://msdn.microsoft.com/en-us/goglobal/bb964664.aspx.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tLocale.html#Alvao_API_Common_Model_Database_tLocale_iLocaleId"/>
    /// <remarks>Column <c>iLocaleId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int iLocaleId { get; set; }
    /// <summary>Two letter ISO language name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tLocale.html#Alvao_API_Common_Model_Database_tLocale_sLangAbbr"/>
    /// <remarks>Column <c>sLangAbbr</c>: nvarchar(10), null.</remarks>
    public virtual string sLangAbbr { get; set; }
    /// <summary>Language name in Czech.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tLocale.html#Alvao_API_Common_Model_Database_tLocale_sLocale"/>
    /// <remarks>Column <c>sLocale</c>: nvarchar(255), not null.</remarks>
    public virtual string sLocale { get; set; }
}
