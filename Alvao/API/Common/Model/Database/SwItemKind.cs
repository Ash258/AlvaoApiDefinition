using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Kinds of records in the views of software.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_SwItemKind.htm"/>
[TableAttribute("dbo.SwItemKind")]
public class SwItemKind
{
    /// <summary>Record ID.</summary>
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Kind of record.</summary>
    public virtual string Kind { get; set; }

    public SwItemKind() { }
}
