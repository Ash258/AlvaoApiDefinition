using Rebex.Mail;

namespace Alvao.API.AM;

/// <summary>Facade class grouping asset check and asset assignment methods.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.AssetAssignment.html"/>
public static class AssetAssignment {
    /// <summary>Replace My asset placeholder with a link with localized text.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.AssetAssignment.html#Alvao_API_AM_AssetAssignment_ReplaceMyAsset_System_String_System_String_"/>
    /// <param name="text">Text containing the placeholder.</param>
    /// <param name="myAsset">My asset text localized to receiver's language.</param>
    public static string ReplaceMyAsset(string text, string myAsset) { throw new NotImplementedException(); }
    /// <summary>Send new asset check/assignment message.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.AssetAssignment.html#Alvao_API_AM_AssetAssignment_SendMessage_System_String_System_String_System_String_System_Collections_Generic_List_System_String__System_Collections_Generic_List_Rebex_Mail_Attachment__"/>
    /// <param name="from">Sender of the message.</param>
    /// <param name="subject">Subject of the message.</param>
    /// <param name="text">Html text of the message.</param>
    /// <param name="bcc">List of BCC receivers.</param>
    /// <param name="attachments">List of attachments.</param>
    public static void SendMessage(string from, string subject, string text, List<string> bcc, List<Attachment> attachments = null) { throw new NotImplementedException(); }
}
