using Alvao.API.Common.Model.CustomApps;
using Alvao.Apps.API;
using Alvao.Context;
using Dapper;

public class ManufacturerSupport : IEntityCommand
{
    public string Id { get; set; }
    public Entity Entity { get; set; }

    public ManufacturerSupport()
    {
        Id = "Manufacturer support".GetHashCode().ToString();
        Entity = Entity.Object;
    }

    public EntityCommandShowResult Show(int entityId, int personId)
    {
        int position = 2;
        string icon = "Manufacturing";
        string name = Localization.GetLocalization(personId, "CommandName");
        bool show = !string.IsNullOrEmpty(GetManufacturerSupportUrl(entityId));

        return new EntityCommandShowResult(show, name, icon, position);
    }

    public CommandResult Run(int entityId, int personId)
    {
        MessageType messageType = MessageType.None;
        string messageText = string.Empty;
        string navigateToUrl = GetManufacturerSupportUrl(entityId);

        return new CommandResult(messageType, messageText, navigateToUrl);
    }

    private string GetManufacturerSupportUrl(int objectId)
    {
        using (var scope = AlvaoContext.GetConnectionScope())
        {
            //Retrieving the required object data from the database.
            var objectModel = scope.Connection.QueryFirstOrDefault<ManufacturerSupportObjectModel>(@"
                select
                    [12] SerialNumber,
                    [16] Manufacturer,
                    [87] BiosSerialNumber
                from (
                    select p.txtValue, k.intKindCode from tblProperty p
                    join tblKind k on k.intKindId = p.lintKindId and k.intKindCode in (12, 16, 87)
                    where p.lintNodeId = @objectId
                ) d
                pivot
                (
                    max(txtValue)
                    for intKindCode in ([12], [16], [87])
                ) piv;", new { objectId }
            );

            if (objectModel == null)
            {
                return string.Empty;
            }

            string serialNumber = string.IsNullOrEmpty(objectModel.SerialNumber) ? objectModel.BiosSerialNumber : objectModel.SerialNumber;

            //Check if the object has filled properties.
            if (!string.IsNullOrEmpty(objectModel.Manufacturer) && !string.IsNullOrEmpty(serialNumber))
            {
                string url = string.Empty;

                switch (objectModel.Manufacturer.ToLower())
                {
                    case "dell":
                    case "dell inc.":
                        url = "https://www.dell.com/support/home/product-support/servicetag/" + serialNumber;
                        break;
                    case "lenovo":
                        url = "https://pcsupport.lenovo.com/products/" + serialNumber;
                        break;
                }

                return url;
            }

            return string.Empty;
        }
    }

    public class ManufacturerSupportObjectModel
    {
        public string Manufacturer { get; set; }
        public string SerialNumber { get; set; }
        public string BiosSerialNumber { get; set; }
    }
}
