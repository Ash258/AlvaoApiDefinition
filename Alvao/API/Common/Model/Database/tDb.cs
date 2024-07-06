using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Database version, database language ID, activation keys for the entire ALVAO.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tDb.htm"/>
[TableAttribute("dbo.tDb")]
public class tDb
{
    /// <summary>Product version for which the database is intended.</summary>
    public virtual string AlvaoVersion { get; set; }
    public virtual int iDbLocaleId { get; set; }
    [ExplicitKeyAttribute]
    public virtual int? iDbVersion { get; set; }
    public virtual string sDb { get; set; }
    public virtual string sDbActivation { get; set; }
    public virtual string Version { get; set; }

    public tDb() { }
}
