using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Signatures for e-mail messages.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tEmailSignature.html"/>
[Table("dbo.tEmailSignature")]
public class tEmailSignature {
    /// <summary>Description in HTML</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tEmailSignature.html#Alvao_API_Common_Model_Database_tEmailSignature_EmailSignatureHtml"/>
    public virtual string EmailSignatureHtml { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tEmailSignature.html#Alvao_API_Common_Model_Database_tEmailSignature_iEmailSignatureId"/>
    [Key]
    public virtual int iEmailSignatureId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tEmailSignature.html#Alvao_API_Common_Model_Database_tEmailSignature_liEmailSignaturePersonId"/>
    public virtual int? liEmailSignaturePersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tEmailSignature.html#Alvao_API_Common_Model_Database_tEmailSignature_mEmailSignatureText"/>
    public virtual string mEmailSignatureText { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tEmailSignature.html#Alvao_API_Common_Model_Database_tEmailSignature_sEmailSignature"/>
    public virtual string sEmailSignature { get; set; }
}
