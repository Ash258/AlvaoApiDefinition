using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Attachments (to documents, notes, events, e-mails, ...) concerning the entire ALVAO system.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html"/>
[Table("dbo.tDocument")]
public class tDocument {
    /// <summary>Document ID in ALVAO Asset Management (tblDocument), to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_AMDocumentId"/>
    public virtual int? AMDocumentId { get; set; }
    /// <summary>Object notice ID (tblNotice) to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_AMNoticeId"/>
    public virtual int? AMNoticeId { get; set; }
    /// <summary>Date and time on which was the document added.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_Created"/>
    public virtual DateTime? Created { get; set; }
    /// <summary>Id of the person (tPerson.iPersonId), who added the document.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_CreatedByPersonId"/>
    public virtual int? CreatedByPersonId { get; set; }
    /// <summary>User signature ID (tEmailSignature) to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_EmailSignatureId"/>
    public virtual int? EmailSignatureId { get; set; }
    /// <summary>If the value is 1, it is not an attachment but an image inserted directly into the formatted text.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_EmbededImage"/>
    public virtual bool EmbededImage { get; set; }
    /// <summary>ID of the approval step (tHdTicketApprovalItem) to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_HdTicketApprovalItemId"/>
    public virtual int? HdTicketApprovalItemId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_NewTicketFormTextBlockId"/>
    public virtual int? NewTicketFormTextBlockId { get; set; }
    /// <summary>News post ID (News.id) to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_NewsId"/>
    public virtual int? NewsId { get; set; }
    /// <summary>Id of the object (tblNode.intNodeId), to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_NodeId"/>
    public virtual int? NodeId { get; set; }
    /// <summary>Last error message returned by OCR</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_OcrLastError"/>
    public virtual string OcrLastError { get; set; }
    /// <summary>Textual content of the image recognized by OCR</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_OcrText"/>
    public virtual string OcrText { get; set; }
    /// <summary>ID of the print report template (PrintReportTemplate) to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_PrintReportTemplateId"/>
    public virtual int? PrintReportTemplateId { get; set; }
    /// <summary>Related ticket rule ID to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_RelatedTicketRuleId"/>
    public virtual int? RelatedTicketRuleId { get; set; }
    /// <summary>Ticket status (TicketState.id) to whose instructions for resolvers this file belongs.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_SolverInstructionsTicketStateId"/>
    public virtual int? SolverInstructionsTicketStateId { get; set; }
    /// <summary>ID of the ticket template (TicketTemplate) to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_TicketTemplateId"/>
    public virtual int? TicketTemplateId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_UniqueGUID"/>
    [Computed]
    public virtual Guid UniqueGUID { get; set; }
    /// <summary>URL address if it is the attachment of the link type. The column is NULL at the attachments of the file type.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_Url"/>
    public virtual string Url { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_iDocumentId"/>
    [Key]
    public virtual int iDocumentId { get; set; }
    /// <summary>Event ID in the ticket log (tAct) to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_liDocumentActId"/>
    public virtual int? liDocumentActId { get; set; }
    /// <summary>Article ID in the Knowledge Base (tArticle) to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_liDocumentArticleId"/>
    public virtual int? liDocumentArticleId { get; set; }
    /// <summary>Binary data set if a file is attached. This column is NULL for a reference attachment</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_oDocument"/>
    public virtual byte[] oDocument { get; set; }
    /// <summary>File name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_sDocument"/>
    public virtual string sDocument { get; set; }
    /// <summary>MIME file type.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_sDocumentContentType"/>
    public virtual string sDocumentContentType { get; set; }
}
