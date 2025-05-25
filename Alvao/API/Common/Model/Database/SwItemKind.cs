using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Kinds of records in the views of software.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SwItemKind.html"/>
[Table("dbo.SwItemKind")]
public class SwItemKind {
    /// <summary>Kind of record.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SwItemKind.html#Alvao_API_Common_Model_Database_SwItemKind_Kind"/>
    public virtual string Kind { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SwItemKind.html#Alvao_API_Common_Model_Database_SwItemKind_id"/>
    [ExplicitKey]
    public virtual int id { get; set; }
}
