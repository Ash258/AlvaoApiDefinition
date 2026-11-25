using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Documents.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html"/>
[Table("dbo.tblDocument")]
public class tblDocument {
    /// <summary>Date and time the document was created (UTC).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_CreatedDate"/>
    /// <remarks>Column <c>CreatedDate</c>: datetime, not null.</remarks>
    public virtual DateTime CreatedDate { get; set; }
    /// <summary>Document folder (DocumentFolder.id)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_DocumentFolderId"/>
    /// <remarks>Column <c>DocumentFolderId</c>: int, not null. References <see cref="DocumentFolder"/>.</remarks>
    public virtual int DocumentFolderId { get; set; }
    /// <summary>
    /// The bit array of flags expressing the relation of the person handing over to the handed over asset in the
    /// handover protocol. Possible values:
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_GiverFlags"/>
    /// <remarks>Column <c>GiverFlags</c>: int, null.</remarks>
    public virtual int? GiverFlags { get; set; }
    /// <summary>Html text of the document.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_HtmlText"/>
    /// <remarks>Column <c>HtmlText</c>: nvarchar(max), null.</remarks>
    public virtual string HtmlText { get; set; }
    /// <summary>Identification number 1</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_IdNumber"/>
    /// <remarks>Column <c>IdNumber</c>: nvarchar(255), null.</remarks>
    public virtual string IdNumber { get; set; }
    /// <summary>Date of issue of the document.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_IssuedDate"/>
    /// <remarks>Column <c>IssuedDate</c>: datetime, null.</remarks>
    public virtual DateTime? IssuedDate { get; set; }
    /// <summary>Name of the document.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(255), null.</remarks>
    public virtual string Name { get; set; }
    /// <summary>
    /// The bit array of flags expressing the relation of the recipient to the asset handed over in the handover
    /// protocol. Possible values:
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_ReceiverFlags"/>
    /// <remarks>Column <c>ReceiverFlags</c>: int, null.</remarks>
    public virtual int? ReceiverFlags { get; set; }
    /// <summary>Name of the computer from which the document was signed.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_SignComputer"/>
    /// <remarks>Column <c>SignComputer</c>: nvarchar(255), null.</remarks>
    public virtual string SignComputer { get; set; }
    /// <summary>Date of signing.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_SignDate"/>
    /// <remarks>Column <c>SignDate</c>: datetime, null.</remarks>
    public virtual DateTime? SignDate { get; set; }
    /// <summary>ID of the person who signed the document.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_SignPersonId"/>
    /// <remarks>Column <c>SignPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? SignPersonId { get; set; }
    /// <summary>The person who signed the document (if its ID cannot be obtained)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_SignedBy"/>
    /// <remarks>Column <c>SignedBy</c>: nvarchar(128), null.</remarks>
    public virtual string SignedBy { get; set; }
    /// <summary>1 = this is a summary internal handover protocol.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_SummaryProtocol"/>
    /// <remarks>Column <c>SummaryProtocol</c>: bit, not null.</remarks>
    public virtual bool SummaryProtocol { get; set; }
    /// <summary>Sign method.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_TransferConfirmTypeId"/>
    /// <remarks>
    /// Column <c>TransferConfirmTypeId</c>: int, not null. References <see cref="TransferConfirmType"/>.
    /// </remarks>
    public virtual int TransferConfirmTypeId { get; set; }
    /// <summary>Voided</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_dteRemoved"/>
    /// <remarks>Column <c>dteRemoved</c>: datetime, null.</remarks>
    public virtual DateTime? dteRemoved { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
    /// <summary>Author - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_liCreatedPersonId"/>
    /// <remarks>Column <c>liCreatedPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? liCreatedPersonId { get; set; }
    /// <summary>Voided by - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_liRemovedPersonId"/>
    /// <remarks>Column <c>liRemovedPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? liRemovedPersonId { get; set; }
    /// <summary>Handover protocol - the User type object representing a recipient (tblNode.intNodeId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_lintDestNodeId"/>
    /// <remarks>Column <c>lintDestNodeId</c>: int, null. References <see cref="tblNode"/>.</remarks>
    public virtual int? lintDestNodeId { get; set; }
    /// <summary>Type - tblDict</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_lintDocumentKindId"/>
    /// <remarks>Column <c>lintDocumentKindId</c>: int, not null. References <see cref="tblDocumentKind"/>.</remarks>
    public virtual int lintDocumentKindId { get; set; }
    /// <summary>Vendor - tblCompany</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_lintResellerCompanyId"/>
    /// <remarks>Column <c>lintResellerCompanyId</c>: int, null. References <see cref="tblCompany"/>.</remarks>
    public virtual int? lintResellerCompanyId { get; set; }
    /// <summary>
    /// Handover protocol - the User type object representing a person handing over (tblNode.intNodeId).
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_lintSrcNodeId"/>
    /// <remarks>Column <c>lintSrcNodeId</c>: int, null. References <see cref="tblNode"/>.</remarks>
    public virtual int? lintSrcNodeId { get; set; }
    /// <summary>ID number 2</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_txtIdNumber2"/>
    /// <remarks>Column <c>txtIdNumber2</c>: nvarchar(255), null.</remarks>
    public virtual string txtIdNumber2 { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDocument.html#Alvao_API_Common_Model_Database_tblDocument_txtMemo"/>
    /// <remarks>Column <c>txtMemo</c>: nvarchar(max), null.</remarks>
    public virtual string txtMemo { get; set; }
}
