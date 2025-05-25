using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Software products library version.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblVersion.html"/>
[Table("dbo.tblVersion")]
public class tblVersion {
    /// <summary>Software product library version date</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblVersion.html#Alvao_API_Common_Model_Database_tblVersion_dteSwLib"/>
    public virtual DateTime? dteSwLib { get; set; }
    /// <summary>basic data version number</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblVersion.html#Alvao_API_Common_Model_Database_tblVersion_intDataVersion"/>
    public virtual int? intDataVersion { get; set; }
    /// <summary>Database language</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblVersion.html#Alvao_API_Common_Model_Database_tblVersion_intLangId"/>
    public virtual int? intLangId { get; set; }
    /// <summary>Database language</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblVersion.html#Alvao_API_Common_Model_Database_tblVersion_intLanguage"/>
    public virtual int? intLanguage { get; set; }
    /// <summary>database version number (=35 and further recorded in tDb)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblVersion.html#Alvao_API_Common_Model_Database_tblVersion_intVersion"/>
    [ExplicitKey]
    public virtual int? intVersion { get; set; }
}
