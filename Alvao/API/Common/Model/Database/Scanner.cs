using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Scanners importing data from other systems or physical devices into Alvao.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_Scanner.htm"/>
[TableAttribute("dbo.Scanner")]
public class Scanner
{
    /// <summary>Scanner id (system-defined values)</summary>
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Scanner name</summary>
    public virtual string Name { get; set; }

    public Scanner() { }
}
