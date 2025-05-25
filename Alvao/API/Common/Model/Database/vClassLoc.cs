using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Translations of the object type names in all languages ââused.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vClassLoc.html"/>
[Table("dbo.vClassLoc")]
public class vClassLoc {
    /// <summary>LCID of the language into which the localization is performed.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vClassLoc.html#Alvao_API_Common_Model_Database_vClassLoc_ClassLocaleId"/>
    public virtual int ClassLocaleId { get; set; }
    /// <summary>Localized name of the object type</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vClassLoc.html#Alvao_API_Common_Model_Database_vClassLoc_LocalizedText"/>
    public virtual string LocalizedText { get; set; }
    /// <summary>Object type ID (tblClass.intClassId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vClassLoc.html#Alvao_API_Common_Model_Database_vClassLoc_lintClassId"/>
    public virtual int? lintClassId { get; set; }
    /// <summary>Object type name in the ALVAO system language</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vClassLoc.html#Alvao_API_Common_Model_Database_vClassLoc_txtText"/>
    public virtual string txtText { get; set; }
}
