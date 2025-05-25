using Alvao.API.Common.Model.Database;

namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectClass.html"/>
public class ObjectClass {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectClass.Code.html#fields"/>
    public enum Code {
        ADImportedObjects = 34,
        AutoloadFolder = 32,
        AzureAppService = 68,
        AzureSQLDatabase = 65,
        AzureSQLServer = 64,
        AzureStorageAccount = 66,
        AzureSubscription = 62,
        AzureVirtualMachine = 67,
        Bluetooth = 27,
        Cabinet = 71,
        Cdrom = 9,
        CellPhone = 58,
        Centre = 41,
        Certificate = 69,
        Chair = 72,
        Cloud = 45,
        Computer = 5,
        ComputerSet = 6,
        Computer_Notebook = 47,
        Computer_Server = 50,
        Computer_Terminal = 49,
        Computer_Virtual = 48,
        Concern = 39,
        Contract = 56,
        Contracts = 57,
        Department = 37,
        Desk = 73,
        Division = 35,
        Fdd = 10,
        FirstUserClass = 5000,
        FlashDisk = 26,
        Folder = 30,
        FoundComputersFolder = 29,
        GeneralObject = 1,
        GraphicCard = 11,
        Hdd = 8,
        ImportedEntraIdObjects = 61,
        ImportedObjects = 33,
        Joystick = 25,
        Keyboard = 14,
        Mainboard = 15,
        MediaCard = 20,
        Modem = 16,
        Monitor = 17,
        Mouse = 18,
        NetworkCard = 13,
        NetworkDevice = 59,
        ObjectModels = 43,
        Organization = 51,
        Printer = 21,
        Processor = 12,
        Ram = 19,
        ResourceGroup = 63,
        Scanner = 24,
        ScrappedFolder = 31,
        ScsiController = 28,
        Section = 40,
        ServersFarm = 44,
        SpecObjPropTabs = 4,
        SpecObjTemplate = 3,
        SpecObjTrash = 2,
        StagingRoom = 55,
        StandardHWCatalog = 52,
        StandardHWCategory = 53,
        StandardHWItem = 54,
        Tablet = 46,
        Tape = 23,
        Unioin = 36,
        UnknownDevice = 60,
        Ups = 22,
        User = 7,
        Warehouse = 42,
        Workplace = 38,
        Workstation = 70,
    }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectClass.ImportedObjectsFolderType.html#fields"/>
    public enum ImportedObjectsFolderType {
        ImportedAdObjects = 34,
        ImportedEntraIdObjects = 61,
        ImportedObjects = 33,
    }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectClass.ObjectsWithoutTemplate.html#fields"/>
    public enum ObjectsWithoutTemplate {
        DiscardedObjects = 31,
        ImportedFromActiveDirectory = 34,
        ImportedFromEntraId = 61,
        ImportedFromLoadedScans = 32,
        PropertyCategories = 4,
        RecycleBin = 2,
        Templates = 3,
    }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectClass.html#Alvao_API_AM_Model_ObjectClass_ClassCode"/>
    public tblClass.ClassCode ClassCode { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectClass.html#Alvao_API_AM_Model_ObjectClass_Name"/>
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectClass.html#Alvao_API_AM_Model_ObjectClass_IsSpecial_System_Nullable_System_Int32__"/>
    public static bool IsSpecial(int? classCode) { throw new System.NotImplementedException(); }
}
