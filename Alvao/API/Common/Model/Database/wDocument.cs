using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Documents.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html"/>
[Table("dbo.wDocument")]
public class wDocument {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_CreatedDate"/>
    public virtual DateTime CreatedDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_DocumentFolderId"/>
    public virtual int DocumentFolderId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_GiverFlags"/>
    public virtual int? GiverFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_IdNumber"/>
    public virtual string IdNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_IssuedDate"/>
    public virtual DateTime? IssuedDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_Name"/>
    public virtual string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_ReceiverFlags"/>
    public virtual int? ReceiverFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_SignComputer"/>
    public virtual string SignComputer { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_SignDate"/>
    public virtual DateTime? SignDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_SignPersonId"/>
    public virtual int? SignPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_SignedBy"/>
    public virtual string SignedBy { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_SummaryProtocol"/>
    public virtual bool SummaryProtocol { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_TransferConfirmTypeId"/>
    public virtual int TransferConfirmTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_dteRemoved"/>
    public virtual DateTime? dteRemoved { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_id"/>
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_intDocumentKindId"/>
    public virtual int intDocumentKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_liCreatedPersonId"/>
    public virtual int? liCreatedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_liRemovedPersonId"/>
    public virtual int? liRemovedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_lintDestNodeId"/>
    public virtual int? lintDestNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_lintDocumentKindId"/>
    public virtual int lintDocumentKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_lintResellerCompanyId"/>
    public virtual int? lintResellerCompanyId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_lintSrcNodeId"/>
    public virtual int? lintSrcNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_sCreatedPersonName"/>
    public virtual string sCreatedPersonName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_sRemovedPersonName"/>
    public virtual string sRemovedPersonName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_txtDestNodeName"/>
    public virtual string txtDestNodeName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_txtDocumentKind"/>
    public virtual string txtDocumentKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_txtIdNumber2"/>
    public virtual string txtIdNumber2 { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_txtLink"/>
    public virtual int? txtLink { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_txtMemo"/>
    public virtual string txtMemo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_txtResellerCompany"/>
    public virtual string txtResellerCompany { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.wDocument.html#Alvao_API_Common_Model_Database_wDocument_txtSrcNodeName"/>
    public virtual string txtSrcNodeName { get; set; }
}
