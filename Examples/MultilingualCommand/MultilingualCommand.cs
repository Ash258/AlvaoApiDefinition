using System;
using System.Threading;
using System.Threading.Tasks;
using Alvao.API.Common.Model.CustomApps;
using Alvao.Apps.API;

public class MultilingualCommand : IEntityCommand 
{
    public string Id {get; set;}
    public Entity Entity {get; set;}

    public MultilingualCommand()
    {
        Id = "MultilingualCommand";
        Entity = Entity.Request;
    }

    public async Task<EntityCommandShowResult> ShowAsync(EntityArgs e, CancellationToken cancellationToken)
    {   
        int position = 1; 
        string icon = "local_language_20_regular"; 

        // Call the localization class and get the localized string for the user's preferred language.
        string name = Localization.GetLocalization(e.PersonId, "CommandName"); 

        // Command show all users.
        bool show = true; 

        return new EntityCommandShowResult (show, name, icon, position);
    }

    public async Task<CommandResult> RunAsync(EntityArgs e, CancellationToken cancellationToken)
    {
        // Command does nothing.
        throw new NotImplementedException();
    }
}
