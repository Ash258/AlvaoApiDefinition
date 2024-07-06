using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Translations of tProperty settings in all languages ​​used.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vPropertyLoc.htm"/>
[TableAttribute("dbo.vPropertyLoc")]
public class vPropertyLoc
{
    /// <summary>LocaleID of the translation in LocalizedStringValue</summary>
    public virtual int LocaleId { get; set; }
    /// <summary>sPropertyValue translation</summary>
    public virtual string LocalizedStringValue { get; set; }
    /// <summary>ID of settings from the tProperty table</summary>
    public virtual int PropertyId { get; set; }
    /// <summary>Name of configuration in tProperty</summary>
    public virtual string sProperty { get; set; }
    /// <summary>The original text value of the setting from tProperty</summary>
    public virtual string sPropertyValue { get; set; }

    public vPropertyLoc() { }
}
