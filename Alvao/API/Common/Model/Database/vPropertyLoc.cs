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
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPropertyLoc_LocaleId.htm"/>
    public virtual int LocaleId { get; set; }
    /// <summary>sPropertyValue translation</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPropertyLoc_LocalizedStringValue.htm"/>
    public virtual string LocalizedStringValue { get; set; }
    /// <summary>ID of settings from the tProperty table</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPropertyLoc_PropertyId.htm"/>
    public virtual int PropertyId { get; set; }
    /// <summary>Name of configuration in tProperty</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPropertyLoc_sProperty.htm"/>
    public virtual string sProperty { get; set; }
    /// <summary>The original text value of the setting from tProperty</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPropertyLoc_sPropertyValue.htm"/>
    public virtual string sPropertyValue { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vPropertyLoc__ctor.htm"/>
    public vPropertyLoc() { }
}
