using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Documents.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html"/>
[Table("dbo.vDocument")]
public class vDocument {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_CreatedDate"/>
    public virtual DateTime CreatedDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_DocumentFolderId"/>
    public virtual int DocumentFolderId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_GiverFlags"/>
    public virtual int? GiverFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_IdNumber"/>
    public virtual string IdNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_IssuedDate"/>
    public virtual DateTime? IssuedDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_Name"/>
    public virtual string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_ReceiverFlags"/>
    public virtual int? ReceiverFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_SignComputer"/>
    public virtual string SignComputer { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_SignDate"/>
    public virtual DateTime? SignDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_SignPersonId"/>
    public virtual int? SignPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_SignedBy"/>
    public virtual string SignedBy { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_SummaryProtocol"/>
    public virtual bool SummaryProtocol { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_TransferConfirmTypeId"/>
    public virtual int TransferConfirmTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_dteRemoved"/>
    public virtual DateTime? dteRemoved { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_id"/>
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_liCreatedPersonId"/>
    public virtual int? liCreatedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_liRemovedPersonId"/>
    public virtual int? liRemovedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_lintDestNodeId"/>
    public virtual int? lintDestNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_lintDocumentKindId"/>
    public virtual int lintDocumentKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_lintResellerCompanyId"/>
    public virtual int? lintResellerCompanyId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_lintSrcNodeId"/>
    public virtual int? lintSrcNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_sCreatedPersonName"/>
    public virtual string sCreatedPersonName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_sRemovedPersonName"/>
    public virtual string sRemovedPersonName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_txtIdNumber2"/>
    public virtual string txtIdNumber2 { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_txtLink"/>
    public virtual int? txtLink { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_txtMemo"/>
    public virtual string txtMemo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDocument.html#Alvao_API_Common_Model_Database_vDocument_txtResellerCompany"/>
    public virtual string txtResellerCompany { get; set; }
}
