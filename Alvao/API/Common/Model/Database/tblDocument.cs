using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Documents.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html"/>
[Table("dbo.tblDocument")]
public class tblDocument {
    /// <summary>Date and time the document was created (UTC).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_CreatedDate"/>
    public virtual DateTime CreatedDate { get; set; }
    /// <summary>Document folder (DocumentFolder.id)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_DocumentFolderId"/>
    public virtual int DocumentFolderId { get; set; }
    /// <summary>The bit array of flags expressing the relation of the person handing over to the handed over asset in the handover protocol. Possible values:</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_GiverFlags"/>
    public virtual int? GiverFlags { get; set; }
    /// <summary>Html text of the document.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_HtmlText"/>
    public virtual string HtmlText { get; set; }
    /// <summary>Identification number 1</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_IdNumber"/>
    public virtual string IdNumber { get; set; }
    /// <summary>Date of issue of the document.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_IssuedDate"/>
    public virtual DateTime? IssuedDate { get; set; }
    /// <summary>Name of the document.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_Name"/>
    public virtual string Name { get; set; }
    /// <summary>The bit array of flags expressing the relation of the recipient to the asset handed over in the handover protocol. Possible values:</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_ReceiverFlags"/>
    public virtual int? ReceiverFlags { get; set; }
    /// <summary>Name of the computer from which the document was signed.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_SignComputer"/>
    public virtual string SignComputer { get; set; }
    /// <summary>Date of signing.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_SignDate"/>
    public virtual DateTime? SignDate { get; set; }
    /// <summary>ID of the person who signed the document.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_SignPersonId"/>
    public virtual int? SignPersonId { get; set; }
    /// <summary>The person who signed the document (if its ID cannot be obtained)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_SignedBy"/>
    public virtual string SignedBy { get; set; }
    /// <summary>1 = this is a summary internal handover protocol.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_SummaryProtocol"/>
    public virtual bool SummaryProtocol { get; set; }
    /// <summary>Sign method.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_TransferConfirmTypeId"/>
    public virtual int TransferConfirmTypeId { get; set; }
    /// <summary>Voided</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_dteRemoved"/>
    public virtual DateTime? dteRemoved { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_id"/>
    [Key]
    public virtual int id { get; set; }
    /// <summary>Author - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_liCreatedPersonId"/>
    public virtual int? liCreatedPersonId { get; set; }
    /// <summary>Voided by - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_liRemovedPersonId"/>
    public virtual int? liRemovedPersonId { get; set; }
    /// <summary>Handover protocol - the User type object representing a recipient (tblNode.intNodeId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_lintDestNodeId"/>
    public virtual int? lintDestNodeId { get; set; }
    /// <summary>Type - tblDict</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_lintDocumentKindId"/>
    public virtual int lintDocumentKindId { get; set; }
    /// <summary>Vendor - tblCompany</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_lintResellerCompanyId"/>
    public virtual int? lintResellerCompanyId { get; set; }
    /// <summary>Handover protocol - the User type object representing a person handing over (tblNode.intNodeId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_lintSrcNodeId"/>
    public virtual int? lintSrcNodeId { get; set; }
    /// <summary>ID number 2</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_txtIdNumber2"/>
    public virtual string txtIdNumber2 { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_txtMemo"/>
    public virtual string txtMemo { get; set; }
}
