using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Database version, database language ID, activation keys for the entire ALVAO.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tDb.htm"/>
[TableAttribute("dbo.tDb")]
public class tDb {
    /// <summary>Product version for which the database is intended.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDb_AlvaoVersion.htm"/>
    public virtual string AlvaoVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDb_iDbLocaleId.htm"/>
    public virtual int iDbLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDb_iDbVersion.htm"/>
    [ExplicitKeyAttribute]
    public virtual int? iDbVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDb_sDb.htm"/>
    public virtual string sDb { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDb_sDbActivation.htm"/>
    public virtual string sDbActivation { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDb_Version.htm"/>
    public virtual string Version { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tDb__ctor.htm"/>
    public tDb() { }
}
