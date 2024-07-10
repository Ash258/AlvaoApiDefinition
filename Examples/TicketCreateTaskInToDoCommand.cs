using Alvao.API.Common;
using Alvao.API.Common.Model.CustomApps;
using Alvao.Apps.API;
using Alvao.API.Common.Model.Database;
using MessageType = Alvao.API.Common.Model.CustomApps.MessageType;
using Alvao.API.Common.Exceptions;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Threading;
using Microsoft.Kiota.Abstractions.Authentication;

public class TicketCreateTaskInToDoCommand : IEntityCommand
{
    public string Id { get; set; }
    public Entity Entity { get; set; }

    public TicketCreateTaskInToDoCommand()
    {
        Id = "TicketCreateTaskInToDo".GetHashCode().ToString();
        Entity = Entity.Request;
    }

    public EntityCommandShowResult Show(int entityId, int personId)
    {
        int position = 2;
        string icon = "ToDoLogoOutline";
        string name = "Create task";
        bool show = false;

        tHdTicket ticket = Alvao.API.SD.Ticket.GetById(entityId);

        if (ticket != null && ticket.liHdTicketHdSectionId > 0)
        {
            var teamRoles = PersonRights.TicketRoles.SectionManager | PersonRights.TicketRoles.SectionMainSolver | PersonRights.TicketRoles.SectionSolver;
            show = PersonRights.HaveTicketRole(personId, entityId, ticket.liHdTicketHdSectionId, teamRoles, true);
        }

        if (show)
        {
            show = !string.IsNullOrEmpty(Person.GetById(personId).AzureAdObjectId);
        }

        return new EntityCommandShowResult(show, name, icon, position);
    }

    public CommandResult Run(int entityId, int personId)
    {
        MessageType messageType = MessageType.None;
        string messageText = string.Empty;
        string navigateToUrl = string.Empty;

        try
        {
            var graphClient = CreateGraphApiClient(personId, "https://graph.microsoft.com/.default");

            // Get ticket info
            var waUrl = DbProperty.WebAppUrl;
            var ticket = Alvao.API.SD.Ticket.GetById(entityId);
            var ticketFullName = Settings.GetSubject(ticket.sHdTicket, ticket.sHdTicketMessageTag);
            var ticketUrl = "";
            if (!string.IsNullOrEmpty(waUrl))
            {
                ticketUrl = waUrl + "/Ticket/" + entityId;
            }

            var todoTask = new Microsoft.Graph.Models.TodoTask
            {
                Title = ticketFullName,
                LinkedResources = new List<Microsoft.Graph.Models.LinkedResource>
                {
                    new Microsoft.Graph.Models.LinkedResource
                    {
                        WebUrl = ticketUrl,
                        ApplicationName = "Alvao",
                        DisplayName = ticketUrl,
                        ExternalId = entityId.ToString()
                    }
                }
            };

            var listsTask = Task.Run(async () => await graphClient.Me.Todo.Lists.GetAsync());
            var lists = listsTask.GetAwaiter().GetResult();

            if (lists != null && lists.Value.Any())
            {
                var postTask = Task.Run(async () => await graphClient.Me.Todo.Lists[lists.Value.First().Id].Tasks.PostAsync(todoTask));
                postTask.GetAwaiter().GetResult();

                messageType = MessageType.Info;
                messageText = "A new task has been created. Check your MS To Do list.";
            }
            else
            {
                messageType = MessageType.Warning;
                messageText = "The new task couldn't be created.";
            }
        }
        catch
        {
            messageType = MessageType.Error;
            messageText = "The new task could not be created because the application does not have the necessary permissions to your To Do. Please contact your administrator.";
            return new CommandResult(messageType, messageText, navigateToUrl);
        }

        return new CommandResult(messageType, messageText, navigateToUrl);
    }

    private Microsoft.Graph.GraphServiceClient? CreateGraphApiClient(int personId, string scope)
    {
        try
        {
            return new Microsoft.Graph.GraphServiceClient(
                new BaseBearerTokenAuthenticationProvider(
                    new TokenProvider(personId, scope)
                )
            );
        }
        catch (UserTokenServiceError)
        {
            return null;
        }
    }
}

public class TokenProvider : IAccessTokenProvider
{
    private readonly int personId;
    private readonly string scope;

    public TokenProvider(int personId, string scope)
    {
        this.personId = personId;
        this.scope = scope;
    }

    public Task<string> GetAuthorizationTokenAsync(Uri uri, Dictionary<string, object> additionalAuthenticationContext = default,
        CancellationToken cancellationToken = default)
    {
        var token = Alvao.API.Internal.UserToken.GetToken(personId, scope);
        if (string.IsNullOrEmpty(token))
            return null;
        return Task.FromResult(token);
    }

    public AllowedHostsValidator AllowedHostsValidator { get; }
}
