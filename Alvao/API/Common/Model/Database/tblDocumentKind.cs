using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Kinds of documents. Texts in tblDict
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblDocumentKind.htm"/>
[TableAttribute("dbo.tblDocumentKind")]
public class tblDocumentKind
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDocumentKind_intDocumentKindId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int intDocumentKindId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblDocumentKind__ctor.htm"/>
    public tblDocumentKind() { }
}
