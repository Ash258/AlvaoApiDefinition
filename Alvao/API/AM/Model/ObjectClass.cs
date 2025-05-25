using Alvao.API.Common.Model.Database;

namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectClass.html"/>
public class ObjectClass {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectClass.Code.html#fields"/>
    public enum Code {
        GeneralObject = 1,
        SpecObjTrash = 2,
        SpecObjTemplate = 3,
        SpecObjPropTabs = 4,
        Computer = 5,
        ComputerSet = 6,
        User = 7,
        Hdd = 8,
        Cdrom = 9,
        Fdd = 10,
        GraphicCard = 11,
        Processor = 12,
        NetworkCard = 13,
        Keyboard = 14,
        Mainboard = 15,
        Modem = 16,
        Monitor = 17,
        Mouse = 18,
        Ram = 19,
        MediaCard = 20,
        Printer = 21,
        Ups = 22,
        Tape = 23,
        Scanner = 24,
        Joystick = 25,
        FlashDisk = 26,
        Bluetooth = 27,
        ScsiController = 28,
        FoundComputersFolder = 29,
        Folder = 30,
        ScrappedFolder = 31,
        AutoloadFolder = 32,
        ImportedObjects = 33,
        ADImportedObjects = 34,
        Division = 35,
        Unioin = 36,
        Department = 37,
        Workplace = 38,
        Concern = 39,
        Section = 40,
        Centre = 41,
        Warehouse = 42,
        ObjectModels = 43,
        ServersFarm = 44,
        Cloud = 45,
        Tablet = 46,
        Computer_Notebook = 47,
        Computer_Virtual = 48,
        Computer_Terminal = 49,
        Computer_Server = 50,
        Organization = 51,
        StandardHWCatalog = 52,
        StandardHWCategory = 53,
        StandardHWItem = 54,
        StagingRoom = 55,
        Contract = 56,
        Contracts = 57,
        CellPhone = 58,
        NetworkDevice = 59,
        UnknownDevice = 60,
        ImportedEntraIdObjects = 61,
        AzureSubscription = 62,
        ResourceGroup = 63,
        AzureSQLServer = 64,
        AzureSQLDatabase = 65,
        AzureStorageAccount = 66,
        AzureVirtualMachine = 67,
        AzureAppService = 68,
        Certificate = 69,
        Workstation = 70,
        Cabinet = 71,
        Chair = 72,
        Desk = 73,
        FirstUserClass = 5000,
    }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectClass.ImportedObjectsFolderType.html#fields"/>
    public enum ImportedObjectsFolderType {
        ImportedObjects = 33,
        ImportedAdObjects = 34,
        ImportedEntraIdObjects = 61,
    }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectClass.ObjectsWithoutTemplate.html#fields"/>
    public enum ObjectsWithoutTemplate {
        RecycleBin = 2,
        Templates = 3,
        PropertyCategories = 4,
        DiscardedObjects = 31,
        ImportedFromLoadedScans = 32,
        ImportedFromActiveDirectory = 34,
        ImportedFromEntraId = 61,
    }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectClass.html#Alvao_API_AM_Model_ObjectClass_ClassCode"/>
    public tblClass.ClassCode ClassCode { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectClass.html#Alvao_API_AM_Model_ObjectClass_Name"/>
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectClass.html#Alvao_API_AM_Model_ObjectClass_IsSpecial_System_Nullable_System_Int32__"/>
    public static bool IsSpecial(int? classCode) { throw new NotImplementedException(); }
}
