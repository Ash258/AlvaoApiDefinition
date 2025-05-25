using Alvao.API.Common.Model.Database;
using Microsoft.Extensions.Logging;

namespace Alvao.API.Common.Model;

/// <summary>Model representing HTML text.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.HtmlTextModel.html"/>
public class HtmlTextModel {
    /// <summary>Attachments list</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.HtmlTextModel.html#Alvao_API_Common_Model_HtmlTextModel_Attachments"/>
    public IEnumerable<AttachmentModel> Attachments { get; protected set; }
    /// <summary>HTML text</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.HtmlTextModel.html#Alvao_API_Common_Model_HtmlTextModel_HtmlText"/>
    public string HtmlText { get; protected set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.HtmlTextModel.html#Alvao_API_Common_Model_HtmlTextModel_Log"/>
    protected ILogger Log { get; set; }
    /// <summary>Plaintext of HTML text</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.HtmlTextModel.html#Alvao_API_Common_Model_HtmlTextModel_Plaintext"/>
    public string Plaintext { get; }

    /// <summary>
    /// <example>
    /// <code>
    /// public class Attachment : Alvao.API.Common.Model.IAttachment
    /// {
    ///     private Alvao.API.Common.Model.Database.tDocument document;
    ///     public Attachment(Alvao.API.Common.Model.Database.tDocument document)
    ///     {
    ///         this.document = document;
    ///     }
    ///     public string Name =&gt; document.sDocument;
    ///     public Guid UniqueName { get; } = Guid.NewGuid();
    ///     public int? DocumentId
    ///     {
    ///         get =&gt; document.iDocumentId == 0 ? null : (int?)document.iDocumentId;
    ///         set =&gt; document.iDocumentId = value ?? 0;
    ///     }
    ///     public string ContentType =&gt; document.sDocumentContentType;
    ///     public string Url =&gt; document.Url;
    ///     public bool EmbeddedImage =&gt; document.EmbededImage;
    ///     public Stream GetStream()
    ///     {
    ///         return new MemoryStream(document.oDocument);
    ///     }
    /// }
    /// 
    /// Alvao.API.Common.Model.Database.tDocument document = new Alvao.API.Common.Model.Database.tDocument(); //Create new document
    /// document.sDocument = "file.png"; //Document name
    /// document.sDocumentContentType = "application/octet-stream"; //Document type
    /// Stream s = System.IO.File.Open("file.png", FileMode.Open, FileAccess.Read, FileShare.Read); //Open document
    /// document.oDocument = new byte[s.Length];
    /// s.ReadAllBuffered(document.oDocument); //Document stream
    /// Attachment attachment = new Attachment(document); //Create new attachment from document
    /// List&lt;Alvao.API.Common.Model.IAttachment&gt; Attachments = new List&lt;Alvao.API.Common.Model.IAttachment&gt;(); //Create attachments list
    /// Attachments.Add(attachment); //Insert attachment into attachments list
    /// Alvao.API.Common.Model.HtmlTextModel HtmlMessage = new Alvao.API.Common.Model.HtmlTextModel("Message in HTML", Attachments); //Create message model
    /// </code>
    /// </example>
    /// </summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.HtmlTextModel.html#Alvao_API_Common_Model_HtmlTextModel__ctor_System_String_System_Collections_Generic_IEnumerable_Alvao_API_Common_Model_IAttachment__"/>
    /// <param name="htmlText">HTML text</param>
    /// <param name="attachments">List of attachments</param>
    public HtmlTextModel(string htmlText, IEnumerable<IAttachment> attachments = null) { }

    /// <summary>Adds attachments from ticket creating report.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.HtmlTextModel.html#Alvao_API_Common_Model_HtmlTextModel_AddAttachmentsBasedOnTemplate_Alvao_API_Common_Repository_IDocumentRepository_"/>
    /// <param name="documentRepository">Document repository</param>
    public void AddAttachmentsBasedOnTemplate(IDocumentRepository documentRepository) { throw new System.NotImplementedException(); }
    /// <summary>Updates embeded image cid after saving to DB and returns the value.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.HtmlTextModel.html#Alvao_API_Common_Model_HtmlTextModel_UpdateAndGetEmbededImage_Alvao_API_Common_Repository_IDocumentRepository_Alvao_API_Common_Model_IAttachment_"/>
    /// <param name="documentRepository">Document repository</param>
    /// <param name="attach">Attachment to update</param>
    /// <returns>True, if it is embeded image, false otherwise.</returns>
    protected bool UpdateAndGetEmbededImage(IDocumentRepository documentRepository, IAttachment attach) { throw new System.NotImplementedException(); }
    /// <summary>Updates attachments cid in HTML text after saving to DB.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.HtmlTextModel.html#Alvao_API_Common_Model_HtmlTextModel_UpdateAttachmentMark_Alvao_API_Common_Model_IAttachment_"/>
    /// <param name="attach">Attachment to update.</param>
    protected void UpdateAttachmentMark(IAttachment attach) { throw new System.NotImplementedException(); }
}
