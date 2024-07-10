using Alvao.API.Common;
using Alvao.API.Common.Model.CustomApps;
using Alvao.Apps.API;
using Alvao.Context;
using Dapper;

public class TeamsWithUserCommand : IEntityCommand
{
    public string Id { get; set; }
    public Entity Entity { get; set; }

    public TeamsWithUserCommand()
    {
        Id = "Chat with user".GetHashCode().ToString();
        Entity = Entity.Object;
    }

    public EntityCommandShowResult Show(int entityId, int personId)
    {
        int position = 3;
        string icon = "TeamsLogo";
        string name = Localization.GetLocalization(personId, "ChatWithObjectUser");
        bool show = !string.IsNullOrEmpty(GetUserEmailForChat(entityId));

        return new EntityCommandShowResult(show, name, icon, position);
    }

    public CommandResult Run(int entityId, int personId)
    {
        MessageType messageType = MessageType.None;
        string messageText = string.Empty;
        string navigateToUrl = string.Empty;

        string email = GetUserEmailForChat(entityId);

        if (string.IsNullOrEmpty(email))
        {
            messageType = MessageType.Error;
            return new CommandResult(messageType, messageText, navigateToUrl);
        }

        var waUrl = DbProperty.WebAppUrl;
        var amObject = Alvao.API.AM.Object.GetById(personId, entityId);
        var objectUrl = "";
        if (!string.IsNullOrEmpty(waUrl))
        {
            objectUrl = waUrl + "/Object/" + entityId;
        }

        // Opens directly Windows application. It may not work in other environments.
        var openIn = Settings.TWUC_TargetState ? "MSTeams:/" : "https://teams.microsoft.com/";
        var message = string.IsNullOrEmpty(objectUrl) ? $" {amObject.txtName}" : $" {amObject.txtName}  - {objectUrl}";

        navigateToUrl = $"{openIn}l/chat/0/0?users={email}&topicName={System.Web.HttpUtility.UrlEncode(amObject.txtName)}&message={System.Web.HttpUtility.UrlEncode(message)}";

        return new CommandResult(messageType, messageText, navigateToUrl);
    }

    private string GetUserEmailForChat(int objectId)
    {
        using (var scope = AlvaoContext.GetConnectionScope())
        {
            //Retrieving the required object data from the database.
            string email = scope.Connection.QueryFirstOrDefault<string>(@"
                select
                    pe.txtValue [Email]
                from tblNode n
                    join tblProperty p on p.lintNodeId=n.intNodeId
                    join tblKind k on k.intKindId=p.lintKindId and k.intKindCode=145
                    join tblNode u on u.intNodeId=p.NodeIdValue
                    join tblProperty pe on pe.lintNodeId=u.intNodeId
                    join tblKind ke on ke.intKindId=pe.lintKindId and ke.intKindCode=46
                where n.intNodeId=@objectId

                union all

                select
                    pe.txtValue [Email]
                from tblNode n
                    join tblProperty p on p.lintNodeId=n.intNodeId and p.ParentNodeId is not null
                    join tblKind k on k.intKindId=p.lintKindId and k.intKindCode=5
                    join tblProperty pe on pe.lintNodeId=p.ParentNodeId
                    join tblKind ke on ke.intKindId=pe.lintKindId and ke.intKindCode=46
                    left join
                    (
                        select
                            p.lintNodeId
                        from tblProperty p
                            join tblKind k on k.intKindId=p.lintKindId and k.intKindCode=145
                    ) zmz on zmz.lintNodeId=n.intNodeId
                where n.intNodeId=@objectId
                    and zmz.lintNodeId is null", new { objectId }
            );

            return email;
        }
    }
}
