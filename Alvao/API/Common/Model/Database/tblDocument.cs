using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Documents.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblDocument.htm"/>
[TableAttribute("dbo.tblDocument")]
public class tblDocument {
    /// <summary>Date and time the document was created (UTC).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDocument_CreatedDate.htm"/>
    public virtual DateTime CreatedDate { get; set; }
    /// <summary>Document folder (DocumentFolder.id)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDocument_DocumentFolderId.htm"/>
    public virtual int DocumentFolderId { get; set; }
    /// <summary>Voided</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDocument_dteRemoved.htm"/>
    public virtual DateTime? dteRemoved { get; set; }
    /// <summary>The bit array of flags expressing the relation of the person handing over to the handed over asset in the handover protocol.Possible values:- NULL = no relation- 0x01 = assets entrusted for use- 0x02 = other entrusted assets</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDocument_GiverFlags.htm"/>
    public virtual int? GiverFlags { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDocument_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Identification number 1</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDocument_IdNumber.htm"/>
    public virtual string IdNumber { get; set; }
    /// <summary>Date of issue of the document.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDocument_IssuedDate.htm"/>
    public virtual DateTime? IssuedDate { get; set; }
    /// <summary>Author - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDocument_liCreatedPersonId.htm"/>
    public virtual int? liCreatedPersonId { get; set; }
    /// <summary>Handover protocol - the User type object representing a recipient (tblNode.intNodeId).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDocument_lintDestNodeId.htm"/>
    public virtual int? lintDestNodeId { get; set; }
    /// <summary>Type - tblDict</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDocument_lintDocumentKindId.htm"/>
    public virtual int lintDocumentKindId { get; set; }
    /// <summary>Vendor - tblCompany</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDocument_lintResellerCompanyId.htm"/>
    public virtual int? lintResellerCompanyId { get; set; }
    /// <summary>Handover protocol - the User type object representing a person handing over (tblNode.intNodeId).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDocument_lintSrcNodeId.htm"/>
    public virtual int? lintSrcNodeId { get; set; }
    /// <summary>Voided by - tPerson</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDocument_liRemovedPersonId.htm"/>
    public virtual int? liRemovedPersonId { get; set; }
    /// <summary>Name of the document.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDocument_Name.htm"/>
    public virtual string Name { get; set; }
    /// <summary>The bit array of flags expressing the relation of the recipient to the asset handed over in the handover protocol.Possible values:- NULL = no relation- 0x01 = assets entrusted for use- 0x02 = other entrusted assets</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDocument_ReceiverFlags.htm"/>
    public virtual int? ReceiverFlags { get; set; }
    /// <summary>Name of the computer from which the document was signed.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDocument_SignComputer.htm"/>
    public virtual string SignComputer { get; set; }
    /// <summary>Date of signing.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDocument_SignDate.htm"/>
    public virtual DateTime? SignDate { get; set; }
    /// <summary>The person who signed the document (if its ID cannot be obtained)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDocument_SignedBy.htm"/>
    public virtual string SignedBy { get; set; }
    /// <summary>ID of the person who signed the document.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDocument_SignPersonId.htm"/>
    public virtual int? SignPersonId { get; set; }
    /// <summary>1 = this is a summary internal handover protocol.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDocument_SummaryProtocol.htm"/>
    public virtual bool SummaryProtocol { get; set; }
    /// <summary>Sign method.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDocument_TransferConfirmTypeId.htm"/>
    public virtual int TransferConfirmTypeId { get; set; }
    /// <summary>ID number 2</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDocument_txtIdNumber2.htm"/>
    public virtual string txtIdNumber2 { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDocument_txtMemo.htm"/>
    public virtual string txtMemo { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblDocument__ctor.htm"/>
    public tblDocument() { }
}
