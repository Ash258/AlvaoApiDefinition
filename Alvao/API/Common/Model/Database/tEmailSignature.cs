using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Signatures for e-mail messages.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tEmailSignature.htm"/>
[TableAttribute("dbo.tEmailSignature")]
public class tEmailSignature
{
    /// <summary>Description in HTML</summary>
    public virtual string EmailSignatureHtml { get; set; }
    [KeyAttribute]
    public virtual int iEmailSignatureId { get; set; }
    public virtual int? liEmailSignaturePersonId { get; set; }
    public virtual string mEmailSignatureText { get; set; }
    public virtual string sEmailSignature { get; set; }

    public tEmailSignature() { }
}
