namespace Alvao.API.Common.Model;

/// <summary>
/// Model representing HTML text.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_HtmlTextModel.htm"/>
public class HtmlTextModel
{
    /// <summary>Attachments list</summary>
    public IEnumerable<AttachmentModel> Attachments { get; }
    /// <summary>HTML text</summary>
    public string HtmlText { get; }
    /// <summary>Plaintext of HTML text</summary>
    public string Plaintext { get; }

    /// <summary>Creates a new instance.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_HtmlTextModel__ctor.htm"/>
    public HtmlTextModel(
string htmlText,
IEnumerable<IAttachment> attachments = null
)
    { }
}
