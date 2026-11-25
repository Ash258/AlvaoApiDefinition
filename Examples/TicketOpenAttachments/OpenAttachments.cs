using System;
using System.Threading;
using System.Threading.Tasks;
using Alvao.API.Common.Model.CustomApps;
using Alvao.Apps.API;

public class OpenAttachments : IEntityCommand 
{
    public string Id {get; set;}
    public Entity Entity {get; set;}

    public OpenAttachments()
    {
        Id = "TicketOpenAttachments";
        Entity = Entity.Request;
    }

    public async Task<EntityCommandShowResult> ShowAsync(EntityArgs e, CancellationToken cancellationToken)
    {   
        int position = Settings.CommandPosition; 
        string icon =  Settings.CommandIcon; 
        string name =  Settings.CommandName; 

        string link = GetTicketAttachments(e.EntityId);

        if (string.IsNullOrWhiteSpace(link))
            return new EntityCommandShowResult (false, name, icon, position);

        Uri DocumentUri;
        if (!Uri.TryCreate(link, UriKind.Absolute, out DocumentUri))
            return new EntityCommandShowResult (false, name, icon, position);

        return new EntityCommandShowResult (true, name, icon, position);
    }

    public async Task<CommandResult> RunAsync(EntityArgs e, CancellationToken cancellationToken)
    {
        MessageType messageType = MessageType.None; 
        string messageText = string.Empty;
        string navigateToUrl = GetTicketAttachments(e.EntityId);
        return new CommandResult(messageType, messageText, navigateToUrl);
    }

    private static string GetTicketAttachments(int ticketId)
    {
        return Alvao.API.Common.Database.ReadColumn(ticketId, "tHdTicketCust", Settings.AttachmentsCustomColumnName);
    }
}
