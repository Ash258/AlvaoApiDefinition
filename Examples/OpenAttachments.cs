using System;
using Alvao.API.Common.Model.CustomApps;
using Alvao.Apps.API;

public class OpenAttachments : IEntityCommand
{
    public string Id { get; set; }
    public Entity Entity { get; set; }

    public OpenAttachments()
    {
        Id = Settings.OA_CommandName.GetHashCode().ToString();
        Entity = Entity.Request;
    }

    public EntityCommandShowResult Show(int entityId, int personId)
    {
        int position = Settings.OA_CommandPosition;
        string icon = Settings.OA_CommandIcon;
        string name = Settings.OA_CommandName;

        string link = GetTicketAttachments(entityId);

        if (string.IsNullOrWhiteSpace(link))
            return new EntityCommandShowResult(false, name, icon, position);

        Uri DocumentUri;
        if (!Uri.TryCreate(link, UriKind.Absolute, out DocumentUri))
            return new EntityCommandShowResult(false, name, icon, position);

        return new EntityCommandShowResult(true, name, icon, position);
    }

    public CommandResult Run(int entityId, int personId)
    {
        MessageType messageType = MessageType.None;
        string messageText = string.Empty;
        string navigateToUrl = GetTicketAttachments(entityId);
        return new CommandResult(messageType, messageText, navigateToUrl);
    }

    private static string GetTicketAttachments(int ticketId)
    {
        return Alvao.API.Common.Database.ReadColumn(ticketId, "tHdTicketCust", Settings.AttachmentsCustomColumnName);
    }
}
