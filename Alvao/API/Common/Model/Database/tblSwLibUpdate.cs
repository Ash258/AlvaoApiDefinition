using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Information on which computer is executing the software product library update.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblSwLibUpdate.html"/>
[Table("dbo.tblSwLibUpdate")]
public class tblSwLibUpdate {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblSwLibUpdate.html#Alvao_API_Common_Model_Database_tblSwLibUpdate_dteUpdateStart"/>
    public virtual DateTime? dteUpdateStart { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblSwLibUpdate.html#Alvao_API_Common_Model_Database_tblSwLibUpdate_txtCollector"/>
    [ExplicitKey]
    public virtual string txtCollector { get; set; }
}
