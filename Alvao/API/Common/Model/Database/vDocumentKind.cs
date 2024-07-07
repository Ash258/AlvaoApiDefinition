using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Kinds of documents.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vDocumentKind.htm"/>
[TableAttribute("dbo.vDocumentKind")]
public class vDocumentKind
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDocumentKind_intDocumentKindId.htm"/>
    public virtual int intDocumentKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDocumentKind_txtDocumentKind.htm"/>
    public virtual string txtDocumentKind { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vDocumentKind__ctor.htm"/>
    public vDocumentKind() { }
}
