using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Translations of the object kind names in all languages ​​used.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vClassLoc.htm"/>
[TableAttribute("dbo.vClassLoc")]
public class vClassLoc
{
    /// <summary>LCID of the language into which the localization is performed.</summary>
    public virtual int ClassLocaleId { get; set; }
    /// <summary>Object kind ID (tblClass.intClassId)</summary>
    public virtual int? lintClassId { get; set; }
    /// <summary>Localized name of the object kind</summary>
    public virtual string LocalizedText { get; set; }
    /// <summary>Object kind name in the ALVAO system language</summary>
    public virtual string txtText { get; set; }

    public vClassLoc() { }
}
