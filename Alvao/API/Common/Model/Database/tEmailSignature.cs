using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Signatures for e-mail messages.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tEmailSignature.htm"/>
[TableAttribute("dbo.tEmailSignature")]
public class tEmailSignature
{
    /// <summary>Description in HTML</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tEmailSignature_EmailSignatureHtml.htm"/>
    public virtual string EmailSignatureHtml { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tEmailSignature_iEmailSignatureId.htm"/>
    [KeyAttribute]
    public virtual int iEmailSignatureId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tEmailSignature_liEmailSignaturePersonId.htm"/>
    public virtual int? liEmailSignaturePersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tEmailSignature_mEmailSignatureText.htm"/>
    public virtual string mEmailSignatureText { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tEmailSignature_sEmailSignature.htm"/>
    public virtual string sEmailSignature { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tEmailSignature__ctor.htm"/>
    public tEmailSignature() { }
}
