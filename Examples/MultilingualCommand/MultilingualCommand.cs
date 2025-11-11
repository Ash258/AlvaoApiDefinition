using System;
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

    public EntityCommandShowResult Show(int entityId, int personId)
    {   
        int position = 1; 
        string icon = "local_language_20_regular"; 

        // Call the localization class and get the localized string for the user's preferred language.
        string name = Localization.GetLocalization(personId, "CommandName"); 

        // Command show all users.
        bool show = true; 

        return new EntityCommandShowResult (show, name, icon, position);
    }

    public CommandResult Run(int entityId, int personId)
    {
        // Command does nothing.
        throw new NotImplementedException();
    }
}
