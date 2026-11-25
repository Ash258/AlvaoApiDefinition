using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Attachments (to documents, notes, events, emails, ...) concerning the entire ALVAO system.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html"/>
[Table("dbo.tDocument")]
public class tDocument {
    /// <summary>Document ID in ALVAO Asset Management (tblDocument), to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_AMDocumentId"/>
    /// <remarks>Column <c>AMDocumentId</c>: int, null. References <see cref="tblDocument"/>.</remarks>
    public virtual int? AMDocumentId { get; set; }
    /// <summary>Object notice ID (tblNotice) to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_AMNoticeId"/>
    /// <remarks>Column <c>AMNoticeId</c>: int, null. References <see cref="tblNotice"/>.</remarks>
    public virtual int? AMNoticeId { get; set; }
    /// <summary>Date and time on which was the document added.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_Created"/>
    /// <remarks>Column <c>Created</c>: datetime, null.</remarks>
    public virtual DateTime? Created { get; set; }
    /// <summary>Id of the person (tPerson.iPersonId), who added the document.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_CreatedByPersonId"/>
    /// <remarks>Column <c>CreatedByPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? CreatedByPersonId { get; set; }
    /// <summary>User signature ID (tEmailSignature) to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_EmailSignatureId"/>
    /// <remarks>Column <c>EmailSignatureId</c>: int, null. References <see cref="tEmailSignature"/>.</remarks>
    public virtual int? EmailSignatureId { get; set; }
    /// <summary>
    /// If the value is 1, it is not an attachment but an image inserted directly into the formatted text.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_EmbededImage"/>
    /// <remarks>Column <c>EmbededImage</c>: bit, not null.</remarks>
    public virtual bool EmbededImage { get; set; }
    /// <summary>ID of the approval step (tHdTicketApprovalItem) to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_HdTicketApprovalItemId"/>
    /// <remarks>
    /// Column <c>HdTicketApprovalItemId</c>: int, null. References <see cref="tHdTicketApprovalItem"/>.
    /// </remarks>
    public virtual int? HdTicketApprovalItemId { get; set; }
    /// <summary>Text block (NewTicketFormTextBlock.Id) to whose this file belongs.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_NewTicketFormTextBlockId"/>
    /// <remarks>
    /// Column <c>NewTicketFormTextBlockId</c>: int, null. References <see cref="NewTicketFormTextBlock"/>.
    /// </remarks>
    public virtual int? NewTicketFormTextBlockId { get; set; }
    /// <summary>News post ID (News.id) to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_NewsId"/>
    /// <remarks>Column <c>NewsId</c>: int, null. References <see cref="News"/>.</remarks>
    public virtual int? NewsId { get; set; }
    /// <summary>Id of the object (tblNode.intNodeId), to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_NodeId"/>
    /// <remarks>Column <c>NodeId</c>: int, null. References <see cref="tblNode"/>.</remarks>
    public virtual int? NodeId { get; set; }
    /// <summary>Last error message returned by OCR</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_OcrLastError"/>
    /// <remarks>Column <c>OcrLastError</c>: nvarchar(max), null.</remarks>
    public virtual string OcrLastError { get; set; }
    /// <summary>Textual content of the image recognized by OCR</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_OcrText"/>
    /// <remarks>Column <c>OcrText</c>: nvarchar(max), null.</remarks>
    public virtual string OcrText { get; set; }
    /// <summary>ID of the print report template (PrintReportTemplate) to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_PrintReportTemplateId"/>
    /// <remarks>Column <c>PrintReportTemplateId</c>: int, null. References <see cref="PrintReportTemplate"/>.</remarks>
    public virtual int? PrintReportTemplateId { get; set; }
    /// <summary>Related ticket rule ID to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_RelatedTicketRuleId"/>
    /// <remarks>Column <c>RelatedTicketRuleId</c>: int, null.</remarks>
    public virtual int? RelatedTicketRuleId { get; set; }
    /// <summary>Ticket status (TicketState.id) to whose instructions for resolvers this file belongs.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_SolverInstructionsTicketStateId"/>
    /// <remarks>
    /// Column <c>SolverInstructionsTicketStateId</c>: int, null. References <see cref="TicketState"/>.
    /// </remarks>
    public virtual int? SolverInstructionsTicketStateId { get; set; }
    /// <summary>Text block (TicketStatusTransitionFormTextBlock.Id) to whose this file belongs.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_TicketStatusTransitionFormTextBlockId"/>
    /// <remarks>
    /// Column <c>TicketStatusTransitionFormTextBlockId</c>: int, null. References <see
    /// cref="TicketStatusTransitionFormTextBlock"/>.
    /// </remarks>
    public virtual int? TicketStatusTransitionFormTextBlockId { get; set; }
    /// <summary>ID of the ticket template (TicketTemplate) to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_TicketTemplateId"/>
    /// <remarks>Column <c>TicketTemplateId</c>: int, null. References <see cref="TicketTemplate"/>.</remarks>
    public virtual int? TicketTemplateId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_UniqueGUID"/>
    /// <remarks>Column <c>UniqueGUID</c>: uniqueidentifier, not null.</remarks>
    [Computed]
    public virtual Guid UniqueGUID { get; set; }
    /// <summary>
    /// URL address if it is the attachment of the link type. The column is NULL at the attachments of the file type.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_Url"/>
    /// <remarks>Column <c>Url</c>: nvarchar(max), null.</remarks>
    public virtual string Url { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_iDocumentId"/>
    /// <remarks>Column <c>iDocumentId</c>: int, not null.</remarks>
    [Key]
    public virtual int iDocumentId { get; set; }
    /// <summary>Event ID in the ticket log (tAct) to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_liDocumentActId"/>
    /// <remarks>Column <c>liDocumentActId</c>: int, null. References <see cref="tAct"/>.</remarks>
    public virtual int? liDocumentActId { get; set; }
    /// <summary>Article ID in the Knowledge Base (tArticle) to which the attachment belongs.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_liDocumentArticleId"/>
    /// <remarks>Column <c>liDocumentArticleId</c>: int, null. References <see cref="tArticle"/>.</remarks>
    public virtual int? liDocumentArticleId { get; set; }
    /// <summary>Binary data set if a file is attached. This column is NULL for a reference attachment</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_oDocument"/>
    /// <remarks>Column <c>oDocument</c>: varbinary, null.</remarks>
    public virtual byte[] oDocument { get; set; }
    /// <summary>File name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_sDocument"/>
    /// <remarks>Column <c>sDocument</c>: nvarchar(255), null.</remarks>
    public virtual string sDocument { get; set; }
    /// <summary>MIME file type.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tDocument.html#Alvao_API_Common_Model_Database_tDocument_sDocumentContentType"/>
    /// <remarks>Column <c>sDocumentContentType</c>: nvarchar(255), null.</remarks>
    public virtual string sDocumentContentType { get; set; }
}
