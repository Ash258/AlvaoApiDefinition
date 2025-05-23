using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_TeamsNotification.htm"/>
public static class TeamsNotification {

    /// <summary>Returns a list of users with correct settings for receiving MS Teams notification</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_TeamsNotification_GetRecipientList.htm"/>
    ///
    /// <param name="recipients">List of all users</param>
    public static IEnumerable<tPerson> GetRecipientList(
        IEnumerable<int> recipients
    ) { throw new System.NotImplementedException(); }

    /// <summary>Sends a custom notification to Alvao Teams Bot</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_TeamsNotification_Send.htm"/>
    ///
    /// <param name="toPersonId">ID of a person who should get the notification</param>
    /// <param name="cardJson">JSON object containing notification card data</param>
    public static void Send(
        int toPersonId,
        string cardJson
    ) { throw new System.NotImplementedException(); }

    /// <summary>Sends a custom notification to Alvao Teams Bot</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_TeamsNotification_Send_1.htm"/>
    ///
    /// <param name="toPersonId">ID of a person who should get the notification</param>
    /// <param name="subject">Subject of a notification (and a card title)</param>
    /// <param name="notificationText">Notification body text</param>
    /// <param name="buttonText">Button text (if empty - no button will be shown in the notification)</param>
    /// <param name="buttonLink">Button link</param>
    /// <param name="iconId">Icon ID (if empty - no icon will be shown in the notification)</param>
    /// <param name="iconColor">Icon color</param>
    public static void Send(
        int toPersonId,
        string subject,
        string notificationText,
        string buttonText,
        string buttonLink,
        int? iconId,
        int? iconColor
    ) { throw new System.NotImplementedException(); }
}
