using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Documents.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblDocument.htm"/>
[TableAttribute("dbo.tblDocument")]
public class tblDocument
{
    /// <summary>Date and time the document was created (UTC).</summary>
    public virtual DateTime CreatedDate { get; set; }
    /// <summary>Document folder (DocumentFolder.id)</summary>
    public virtual int DocumentFolderId { get; set; }
    /// <summary>Voided</summary>
    public virtual DateTime? dteRemoved { get; set; }
    /// <summary>The bit array of flags expressing the relation of the person handing over to the handed over asset in the handover protocol.Possible values:- NULL = no relation- 0x01 = assets entrusted for use- 0x02 = other entrusted assets</summary>
    public virtual int? GiverFlags { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Identification number 1</summary>
    public virtual string IdNumber { get; set; }
    /// <summary>Date of issue of the document.</summary>
    public virtual DateTime? IssuedDate { get; set; }
    /// <summary>Author - tPerson</summary>
    public virtual int? liCreatedPersonId { get; set; }
    /// <summary>Handover protocol - the User type object representing a recipient (tblNode.intNodeId).</summary>
    public virtual int? lintDestNodeId { get; set; }
    /// <summary>Type - tblDict</summary>
    public virtual int lintDocumentKindId { get; set; }
    /// <summary>Vendor - tblCompany</summary>
    public virtual int? lintResellerCompanyId { get; set; }
    /// <summary>Handover protocol - the User type object representing a person handing over (tblNode.intNodeId).</summary>
    public virtual int? lintSrcNodeId { get; set; }
    /// <summary>Voided by - tPerson</summary>
    public virtual int? liRemovedPersonId { get; set; }
    /// <summary>Name of the document.</summary>
    public virtual string Name { get; set; }
    /// <summary>The bit array of flags expressing the relation of the recipient to the asset handed over in the handover protocol.Possible values:- NULL = no relation- 0x01 = assets entrusted for use- 0x02 = other entrusted assets</summary>
    public virtual int? ReceiverFlags { get; set; }
    /// <summary>Name of the computer from which the document was signed.</summary>
    public virtual string SignComputer { get; set; }
    /// <summary>Date of signing.</summary>
    public virtual DateTime? SignDate { get; set; }
    /// <summary>The person who signed the document (if its ID cannot be obtained)</summary>
    public virtual string SignedBy { get; set; }
    /// <summary>ID of the person who signed the document.</summary>
    public virtual int? SignPersonId { get; set; }
    /// <summary>1 = this is a summary internal handover protocol.</summary>
    public virtual bool SummaryProtocol { get; set; }
    /// <summary>Sign method.</summary>
    public virtual int TransferConfirmTypeId { get; set; }
    /// <summary>ID number 2</summary>
    public virtual string txtIdNumber2 { get; set; }
    /// <summary>Note</summary>
    public virtual string txtMemo { get; set; }

    public tblDocument() { }
}
