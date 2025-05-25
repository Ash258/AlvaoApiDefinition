using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Kinds of documents. Texts in tblDict</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocumentKind.html"/>
[Table("dbo.tblDocumentKind")]
public class tblDocumentKind {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocumentKind.html#Alvao_API_Common_Model_Database_tblDocumentKind_intDocumentKindId"/>
    [ExplicitKey]
    public virtual int intDocumentKindId { get; set; }
}
