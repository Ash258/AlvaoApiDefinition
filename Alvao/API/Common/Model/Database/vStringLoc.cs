using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>List of strings from ALVAO applications in all used languages.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vStringLoc.htm"/>
[TableAttribute("dbo.vStringLoc")]
public class vStringLoc {
    /// <summary>String ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vStringLoc_iStringId.htm"/>
    public virtual int iStringId { get; set; }
    /// <summary>Localized string.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vStringLoc_LocalizedString.htm"/>
    public virtual string LocalizedString { get; set; }
    /// <summary>String.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vStringLoc_mString.htm"/>
    public virtual string mString { get; set; }
    /// <summary>Language localization ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vStringLoc_StringLocaleId.htm"/>
    public virtual int StringLocaleId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vStringLoc__ctor.htm"/>
    public vStringLoc() { }
}
