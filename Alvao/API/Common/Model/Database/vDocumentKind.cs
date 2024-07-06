using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Kinds of documents.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vDocumentKind.htm"/>
[TableAttribute("dbo.vDocumentKind")]
public class vDocumentKind
{
    public virtual int intDocumentKindId { get; set; }
    public virtual string txtDocumentKind { get; set; }

    public vDocumentKind() { }
}
