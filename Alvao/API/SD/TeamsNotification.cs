using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.TeamsNotification.html"/>
public static class TeamsNotification {
    /// <summary>Returns a list of users with correct settings for receiving MS Teams notification</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.TeamsNotification.html#Alvao_API_SD_TeamsNotification_GetRecipientList_System_Collections_Generic_IEnumerable_System_Int32__"/>
    /// <param name="recipients">List of all users</param>
    public static IEnumerable<tPerson> GetRecipientList(IEnumerable<int> recipients) { throw new System.NotImplementedException(); }
    /// <summary>Sends a custom notification to Alvao Teams Bot</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.TeamsNotification.html#Alvao_API_SD_TeamsNotification_Send_System_Int32_System_String_"/>
    /// <param name="toPersonId">ID of a person who should get the notification</param>
    /// <param name="cardJson">JSON object containing notification card data</param>
    public static void Send(int toPersonId, string cardJson) { throw new System.NotImplementedException(); }
    /// <summary>Sends a custom notification to Alvao Teams Bot</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.TeamsNotification.html#Alvao_API_SD_TeamsNotification_Send_System_Int32_System_String_System_String_System_String_System_String_System_Nullable_System_Int32__System_Nullable_System_Int32__"/>
    /// <param name="toPersonId">ID of a person who should get the notification</param>
    /// <param name="subject">Subject of a notification (and a card title)</param>
    /// <param name="notificationText">Notification body text</param>
    /// <param name="buttonText">Button text (if empty - no button will be shown in the notification)</param>
    /// <param name="buttonLink">Button link</param>
    /// <param name="iconId">Icon ID (if empty - no icon will be shown in the notification)</param>
    /// <param name="iconColor">Icon color</param>
    public static void Send(int toPersonId, string subject, string notificationText, string buttonText, string buttonLink, int? iconId, int? iconColor) { throw new System.NotImplementedException(); }
}
