using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Database version, database language ID, activation keys for the entire ALVAO.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDb.html"/>
[Table("dbo.tDb")]
public class tDb {
    /// <summary>Product version for which the database is intended.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDb.html#Alvao_API_Common_Model_Database_tDb_AlvaoVersion"/>
    /// <remarks>Column <c>AlvaoVersion</c>: nvarchar(50), null.</remarks>
    public virtual string AlvaoVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDb.html#Alvao_API_Common_Model_Database_tDb_Version"/>
    /// <remarks>Column <c>Version</c>: nvarchar(32), not null.</remarks>
    public virtual string Version { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDb.html#Alvao_API_Common_Model_Database_tDb_iDbLocaleId"/>
    /// <remarks>Column <c>iDbLocaleId</c>: int, not null.</remarks>
    public virtual int iDbLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDb.html#Alvao_API_Common_Model_Database_tDb_iDbVersion"/>
    /// <remarks>Column <c>iDbVersion</c>: int, null.</remarks>
    [ExplicitKey]
    public virtual int? iDbVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDb.html#Alvao_API_Common_Model_Database_tDb_sDb"/>
    /// <remarks>Column <c>sDb</c>: nvarchar(255), null.</remarks>
    public virtual string sDb { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDb.html#Alvao_API_Common_Model_Database_tDb_sDbActivation"/>
    /// <remarks>Column <c>sDbActivation</c>: nvarchar(max), null.</remarks>
    public virtual string sDbActivation { get; set; }
}
