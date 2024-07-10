using Alvao.API.Common.Model.CustomApps;
using Alvao.Apps.API;
using Alvao.Context;
using Dapper;

public class IntuneCommand : IEntityCommand
{
    public string Id { get; set; }
    public Entity Entity { get; set; }

    public IntuneCommand()
    {
        Id = "ObjectIntune".GetHashCode().ToString();
        Entity = Entity.Object;
    }

    public EntityCommandShowResult Show(int entityId, int personId)
    {
        int position = 2;
        string icon = "Devices2";
        string name = "MS Intune";
        if (!LicenceCheck())
            return new EntityCommandShowResult(false, name, icon, position);
        bool show = !string.IsNullOrEmpty(GetObjectIntuneId(entityId));

        return new EntityCommandShowResult(show, name, icon, position);
    }

    public CommandResult Run(int entityId, int personId)
    {
        if (!LicenceCheck())
            return new CommandResult(MessageType.Error, "Module is not activated.", null);
        MessageType messageType = MessageType.None;
        string messageText = string.Empty;
        string navigateToUrl = string.Empty;

        string intuneId = GetObjectIntuneId(entityId);
        if (string.IsNullOrEmpty(intuneId))
        {
            messageType = MessageType.Error;
            messageText = "Error getting the value of the Intune device Id property.";
        }
        else
        {
            navigateToUrl = "https://endpoint.microsoft.com/#view/Microsoft_Intune_Devices/DeviceSettingsMenuBlade/~/overview/mdmDeviceId/" + intuneId;
        }

        return new CommandResult(messageType, messageText, navigateToUrl);
    }

    private bool LicenceCheck() => false;
    // TODO: Fix with actual implementation of Alvao.Global and activation module, that is now skipped
    // private bool LicenceCheck() => Alvao.API.Common.Activation.IsModuleActivated(Alvao.Global.ModuleInfo.ModuleId.IntuneConnector);

    private string GetObjectIntuneId(int objectId)
    {
        using (var scope = AlvaoContext.GetConnectionScope())
        {
            //Retrieving the IntuneId from the database.
            return scope.Connection.QueryFirstOrDefault<string>(@"
                select p.txtValue
                from tblProperty p
                join tblKind k on k.intKindId = p.lintKindId and k.intKindCode = 166
                where p.lintNodeId = @objectId", new { objectId }
            );
        }
    }
}
