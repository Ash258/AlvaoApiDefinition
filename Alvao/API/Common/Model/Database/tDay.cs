using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Calendar of days</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDay.html"/>
[Table("dbo.tDay")]
public class tDay {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDay.html#Alvao_API_Common_Model_Database_tDay_dDay"/>
    [ExplicitKey]
    public virtual DateTime dDay { get; set; }
}
