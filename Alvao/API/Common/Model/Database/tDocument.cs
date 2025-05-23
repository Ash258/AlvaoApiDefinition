using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Attachments (to documents, notes, events, e-mails, ...) concerning the entire ALVAO system.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tDocument.htm"/>
[TableAttribute("dbo.tDocument")]
public class tDocument
{
    /// <summary>Document ID in ALVAO Asset Management (tblDocument), to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDocument_AMDocumentId.htm"/>
    public virtual int? AMDocumentId { get; set; }
    /// <summary>Object notice ID (tblNotice) to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDocument_AMNoticeId.htm"/>
    public virtual int? AMNoticeId { get; set; }
    /// <summary>Date and time on which was the document added.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDocument_Created.htm"/>
    public virtual DateTime? Created { get; set; }
    /// <summary>Id of the person (tPerson.iPersonId), who added the document.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDocument_CreatedByPersonId.htm"/>
    public virtual int? CreatedByPersonId { get; set; }
    /// <summary>User signature ID (tEmailSignature) to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDocument_EmailSignatureId.htm"/>
    public virtual int? EmailSignatureId { get; set; }
    /// <summary>If the value is 1, it is not an attachment but an image inserted directly into the formatted text.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDocument_EmbededImage.htm"/>
    public virtual bool EmbededImage { get; set; }
    /// <summary>ID of the approval step (tHdTicketApprovalItem) to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDocument_HdTicketApprovalItemId.htm"/>
    public virtual int? HdTicketApprovalItemId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDocument_iDocumentId.htm"/>
    [KeyAttribute]
    public virtual int iDocumentId { get; set; }
    /// <summary>Event ID in the ticket log (tAct) to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDocument_liDocumentActId.htm"/>
    public virtual int? liDocumentActId { get; set; }
    /// <summary>Article ID in the Knowledge Base (tArticle) to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDocument_liDocumentArticleId.htm"/>
    public virtual int? liDocumentArticleId { get; set; }
    /// <summary>News post ID (News.id) to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDocument_NewsId.htm"/>
    public virtual int? NewsId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDocument_NewTicketFormTextBlockId.htm"/>
    public virtual int? NewTicketFormTextBlockId { get; set; }
    /// <summary>Id of the object (tblNode.intNodeId), to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDocument_NodeId.htm"/>
    public virtual int? NodeId { get; set; }
    /// <summary>Last error message returned by OCR</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDocument_OcrLastError.htm"/>
    public virtual string OcrLastError { get; set; }
    /// <summary>Textual content of the image recognized by OCR</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDocument_OcrText.htm"/>
    public virtual string OcrText { get; set; }
    /// <summary>Binary data set if a file is attached. This column is NULL for a reference attachment</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDocument_oDocument.htm"/>
    public virtual byte[] oDocument { get; set; }
    /// <summary>ID of the print report template (PrintReportTemplate) to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDocument_PrintReportTemplateId.htm"/>
    public virtual int? PrintReportTemplateId { get; set; }
    /// <summary>File name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDocument_sDocument.htm"/>
    public virtual string sDocument { get; set; }
    /// <summary>MIME file type.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDocument_sDocumentContentType.htm"/>
    public virtual string sDocumentContentType { get; set; }
    /// <summary>Ticket status (TicketState.id) to whose instructions for resolvers this file belongs.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDocument_SolverInstructionsTicketStateId.htm"/>
    public virtual int? SolverInstructionsTicketStateId { get; set; }
    /// <summary>ID of the ticket template (TicketTemplate) to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDocument_TicketTemplateId.htm"/>
    public virtual int? TicketTemplateId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDocument_UniqueGUID.htm"/>
    [ComputedAttribute]
    public virtual Guid UniqueGUID { get; set; }
    /// <summary>URL address if it is the attachment of the link type. The column is NULL at the attachments of the file type.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDocument_Url.htm"/>
    public virtual string Url { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tDocument__ctor.htm"/>
    public tDocument() { }
}
