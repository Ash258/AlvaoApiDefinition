using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Kinds of documents.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocumentKind.html"/>
[Table("dbo.vDocumentKind")]
public class vDocumentKind {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocumentKind.html#Alvao_API_Common_Model_Database_vDocumentKind_intDocumentKindId"/>
    public virtual int intDocumentKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocumentKind.html#Alvao_API_Common_Model_Database_vDocumentKind_txtDocumentKind"/>
    public virtual string txtDocumentKind { get; set; }
}
