using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Language environments.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tLocale.html"/>
[Table("dbo.tLocale")]
public class tLocale {
    /// <summary>Culture code of the language.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tLocale.html#Alvao_API_Common_Model_Database_tLocale_CultureCode"/>
    public virtual string CultureCode { get; set; }
    /// <summary>If set to 1, the language is used and is displayed in menus.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tLocale.html#Alvao_API_Common_Model_Database_tLocale_bLocaleEnabled"/>
    public virtual bool bLocaleEnabled { get; set; }
    /// <summary>LocaleID. The list of these, for example, can be found here http://msdn.microsoft.com/en-us/goglobal/bb964664.aspx.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tLocale.html#Alvao_API_Common_Model_Database_tLocale_iLocaleId"/>
    [ExplicitKey]
    public virtual int iLocaleId { get; set; }
    /// <summary>Three-letter language abbreviations. Used in all names of localization dll files. The list of these, for example, can be found here http://www.microsoft.com/resources/msdn/goglobal/default.mspx.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tLocale.html#Alvao_API_Common_Model_Database_tLocale_sLangAbbr"/>
    public virtual string sLangAbbr { get; set; }
    /// <summary>Language name in Czech.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tLocale.html#Alvao_API_Common_Model_Database_tLocale_sLocale"/>
    public virtual string sLocale { get; set; }
}
