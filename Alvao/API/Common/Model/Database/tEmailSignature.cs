using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Signatures for email messages.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tEmailSignature.html"/>
[Table("dbo.tEmailSignature")]
public class tEmailSignature {
    /// <summary>Description in HTML</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tEmailSignature.html#Alvao_API_Common_Model_Database_tEmailSignature_EmailSignatureHtml"/>
    /// <remarks>Column <c>EmailSignatureHtml</c>: nvarchar(max), null.</remarks>
    public virtual string EmailSignatureHtml { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tEmailSignature.html#Alvao_API_Common_Model_Database_tEmailSignature_iEmailSignatureId"/>
    /// <remarks>Column <c>iEmailSignatureId</c>: int, not null.</remarks>
    [Key]
    public virtual int iEmailSignatureId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tEmailSignature.html#Alvao_API_Common_Model_Database_tEmailSignature_liEmailSignaturePersonId"/>
    /// <remarks>Column <c>liEmailSignaturePersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? liEmailSignaturePersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tEmailSignature.html#Alvao_API_Common_Model_Database_tEmailSignature_mEmailSignatureText"/>
    /// <remarks>Column <c>mEmailSignatureText</c>: nvarchar(max), null.</remarks>
    public virtual string mEmailSignatureText { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tEmailSignature.html#Alvao_API_Common_Model_Database_tEmailSignature_sEmailSignature"/>
    /// <remarks>Column <c>sEmailSignature</c>: nvarchar(255), not null.</remarks>
    public virtual string sEmailSignature { get; set; }
}
