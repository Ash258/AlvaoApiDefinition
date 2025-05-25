using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Scanners importing data from other systems or physical devices into Alvao.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Scanner.html"/>
[Table("dbo.Scanner")]
public class Scanner {
    /// <summary>Scanner name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Scanner.html#Alvao_API_Common_Model_Database_Scanner_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Scanner id (system-defined values)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Scanner.html#Alvao_API_Common_Model_Database_Scanner_id"/>
    [ExplicitKey]
    public virtual int id { get; set; }
}
