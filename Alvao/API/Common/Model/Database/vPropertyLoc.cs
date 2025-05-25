using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Translations of tProperty settings in all languages ââused.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyLoc.html"/>
[Table("dbo.vPropertyLoc")]
public class vPropertyLoc {
    /// <summary>LocaleID of the translation in LocalizedStringValue</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyLoc.html#Alvao_API_Common_Model_Database_vPropertyLoc_LocaleId"/>
    public virtual int LocaleId { get; set; }
    /// <summary>sPropertyValue translation</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyLoc.html#Alvao_API_Common_Model_Database_vPropertyLoc_LocalizedStringValue"/>
    public virtual string LocalizedStringValue { get; set; }
    /// <summary>ID of settings from the tProperty table</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyLoc.html#Alvao_API_Common_Model_Database_vPropertyLoc_PropertyId"/>
    public virtual int PropertyId { get; set; }
    /// <summary>Name of configuration in tProperty</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyLoc.html#Alvao_API_Common_Model_Database_vPropertyLoc_sProperty"/>
    public virtual string sProperty { get; set; }
    /// <summary>The original text value of the setting from tProperty</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyLoc.html#Alvao_API_Common_Model_Database_vPropertyLoc_sPropertyValue"/>
    public virtual string sPropertyValue { get; set; }
}
