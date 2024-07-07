using AlvaoScapper;

public static class MonkeyPatch
{
    public static string Methods(AlvaoClass clazz, string _name, string _definition)
    {
        if (Helpers.IsClass(clazz, "Alvao.API.AM", "ObjectRight") && _name.Equals("CheckForUser"))
            _definition = _definition.Replace(" ObjectRight.Right ", " Alvao.API.AM.Model.ObjectRight.Right ");
        if (Helpers.IsClass(clazz, "Alvao.API.Common", "ProfileValue"))
        {
            switch (_name)
            {
                case "Get":
                case "Delete":
                case "GetById":
                    _definition = _definition.Replace(" ProfileValue ", " Alvao.API.Common.Model.Database.ProfileValue ");
                    break;
            }
        }
        if (Helpers.IsClass(clazz, "Alvao.API.Common", "Webhook"))
        {
            switch (_name)
            {
                case "Create":
                case "Delete":
                case "GetById":
                    _definition = _definition.Replace(" Webhook ", " Alvao.API.Common.Model.Database.Webhook ");
                    break;
                case "GetTopicById":
                    _definition = _definition.Replace(" WebhookTopic ", " Alvao.API.Common.Model.Database.WebhookTopic ");
                    break;
            }
        }
        if (Helpers.IsClass(clazz, "Alvao.API.SD", "TicketState"))
        {
            switch (_name)
            {
                case "GetFromProcess":
                    _definition = _definition.Replace("<TicketState>", "<Alvao.API.Common.Model.Database.TicketState>");
                    break;
                case "GetByBehaviorId":
                case "GetById":
                case "GetByName":
                case "GetCurrentStateByTicketId":
                    _definition = _definition.Replace(" TicketState ", " Alvao.API.Common.Model.Database.TicketState ");
                    break;
            }
        }

        return _definition;
    }

}
