using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Software product library version.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblVersion.html"/>
[Table("dbo.tblVersion")]
public class tblVersion {
    /// <summary>Software product library version date</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblVersion.html#Alvao_API_Common_Model_Database_tblVersion_dteSwLib"/>
    /// <remarks>Column <c>dteSwLib</c>: datetime, null.</remarks>
    public virtual DateTime? dteSwLib { get; set; }
    /// <summary>basic data version number</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblVersion.html#Alvao_API_Common_Model_Database_tblVersion_intDataVersion"/>
    /// <remarks>Column <c>intDataVersion</c>: int, null.</remarks>
    public virtual int? intDataVersion { get; set; }
    /// <summary>Database language</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblVersion.html#Alvao_API_Common_Model_Database_tblVersion_intLangId"/>
    /// <remarks>Column <c>intLangId</c>: int, null.</remarks>
    public virtual int? intLangId { get; set; }
    /// <summary>Database language</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblVersion.html#Alvao_API_Common_Model_Database_tblVersion_intLanguage"/>
    /// <remarks>Column <c>intLanguage</c>: int, null.</remarks>
    public virtual int? intLanguage { get; set; }
    /// <summary>database version number (=35 and further recorded in tDb)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblVersion.html#Alvao_API_Common_Model_Database_tblVersion_intVersion"/>
    /// <remarks>Column <c>intVersion</c>: int, null.</remarks>
    [ExplicitKey]
    public virtual int? intVersion { get; set; }
}
