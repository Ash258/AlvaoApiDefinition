using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Language environments.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tLocale.htm"/>
[TableAttribute("dbo.tLocale")]
public class tLocale
{
    /// <summary>If set to 1, the language is used and is displayed in menus.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tLocale_bLocaleEnabled.htm"/>
    public virtual bool bLocaleEnabled { get; set; }
    /// <summary>LocaleID. The list of these, for example, can be found here http://msdn.microsoft.com/en-us/goglobal/bb964664.aspx.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tLocale_iLocaleId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int iLocaleId { get; set; }
    /// <summary>Three-letter language abbreviations. Used in all names of localization dll files. The list of these, for example, can be found here http://www.microsoft.com/resources/msdn/goglobal/default.mspx.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tLocale_sLangAbbr.htm"/>
    public virtual string sLangAbbr { get; set; }
    /// <summary>Language name in Czech.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tLocale_sLocale.htm"/>
    public virtual string sLocale { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tLocale__ctor.htm"/>
    public tLocale() { }
}
