using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Software products library version.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblVersion.htm"/>
[TableAttribute("dbo.tblVersion")]
public class tblVersion
{
    /// <summary>Software product library version date</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblVersion_dteSwLib.htm"/>
    public virtual DateTime? dteSwLib { get; set; }
    /// <summary>basic data version number</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblVersion_intDataVersion.htm"/>
    public virtual int? intDataVersion { get; set; }
    /// <summary>Database language</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblVersion_intLangId.htm"/>
    public virtual int? intLangId { get; set; }
    /// <summary>Database language</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblVersion_intLanguage.htm"/>
    public virtual int? intLanguage { get; set; }
    /// <summary>database version number (=35 and further recorded in tDb)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblVersion_intVersion.htm"/>
    [ExplicitKeyAttribute]
    public virtual int? intVersion { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblVersion__ctor.htm"/>
    public tblVersion() { }
}
