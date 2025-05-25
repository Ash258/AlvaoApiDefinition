using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>List of strings from ALVAO applications in all used languages.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vStringLoc.html"/>
[Table("dbo.vStringLoc")]
public class vStringLoc {
    /// <summary>Localized string.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vStringLoc.html#Alvao_API_Common_Model_Database_vStringLoc_LocalizedString"/>
    public virtual string LocalizedString { get; set; }
    /// <summary>Language localization ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vStringLoc.html#Alvao_API_Common_Model_Database_vStringLoc_StringLocaleId"/>
    public virtual int StringLocaleId { get; set; }
    /// <summary>String ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vStringLoc.html#Alvao_API_Common_Model_Database_vStringLoc_iStringId"/>
    public virtual int iStringId { get; set; }
    /// <summary>String.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vStringLoc.html#Alvao_API_Common_Model_Database_vStringLoc_mString"/>
    public virtual string mString { get; set; }
}
