using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Documents.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_wDocument.htm"/>
[TableAttribute("dbo.wDocument")]
public class wDocument
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_CreatedDate.htm"/>
    public virtual DateTime CreatedDate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_DocumentFolderId.htm"/>
    public virtual int DocumentFolderId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_dteRemoved.htm"/>
    public virtual DateTime? dteRemoved { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_GiverFlags.htm"/>
    public virtual int? GiverFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_id.htm"/>
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_IdNumber.htm"/>
    public virtual string IdNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_intDocumentKindId.htm"/>
    public virtual int intDocumentKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_IssuedDate.htm"/>
    public virtual DateTime? IssuedDate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_liCreatedPersonId.htm"/>
    public virtual int? liCreatedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_lintDestNodeId.htm"/>
    public virtual int? lintDestNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_lintDocumentKindId.htm"/>
    public virtual int lintDocumentKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_lintResellerCompanyId.htm"/>
    public virtual int? lintResellerCompanyId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_lintSrcNodeId.htm"/>
    public virtual int? lintSrcNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_liRemovedPersonId.htm"/>
    public virtual int? liRemovedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_Name.htm"/>
    public virtual string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_ReceiverFlags.htm"/>
    public virtual int? ReceiverFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_sCreatedPersonName.htm"/>
    public virtual string sCreatedPersonName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_SignComputer.htm"/>
    public virtual string SignComputer { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_SignDate.htm"/>
    public virtual DateTime? SignDate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_SignedBy.htm"/>
    public virtual string SignedBy { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_SignPersonId.htm"/>
    public virtual int? SignPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_sRemovedPersonName.htm"/>
    public virtual string sRemovedPersonName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_SummaryProtocol.htm"/>
    public virtual bool SummaryProtocol { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_TransferConfirmTypeId.htm"/>
    public virtual int TransferConfirmTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_txtDestNodeName.htm"/>
    public virtual string txtDestNodeName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_txtDocumentKind.htm"/>
    public virtual string txtDocumentKind { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_txtIdNumber2.htm"/>
    public virtual string txtIdNumber2 { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_txtLink.htm"/>
    public virtual int? txtLink { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_txtMemo.htm"/>
    public virtual string txtMemo { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_txtResellerCompany.htm"/>
    public virtual string txtResellerCompany { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_wDocument_txtSrcNodeName.htm"/>
    public virtual string txtSrcNodeName { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_wDocument__ctor.htm"/>
    public wDocument() { }
}
