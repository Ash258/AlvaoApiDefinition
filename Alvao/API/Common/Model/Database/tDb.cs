using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Database version, database language ID, activation keys for the entire ALVAO.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDb.html"/>
[Table("dbo.tDb")]
public class tDb {
    /// <summary>Product version for which the database is intended.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDb.html#Alvao_API_Common_Model_Database_tDb_AlvaoVersion"/>
    public virtual string AlvaoVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDb.html#Alvao_API_Common_Model_Database_tDb_Version"/>
    public virtual string Version { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDb.html#Alvao_API_Common_Model_Database_tDb_iDbLocaleId"/>
    public virtual int iDbLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDb.html#Alvao_API_Common_Model_Database_tDb_iDbVersion"/>
    [ExplicitKey]
    public virtual int? iDbVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDb.html#Alvao_API_Common_Model_Database_tDb_sDb"/>
    public virtual string sDb { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDb.html#Alvao_API_Common_Model_Database_tDb_sDbActivation"/>
    public virtual string sDbActivation { get; set; }
}
