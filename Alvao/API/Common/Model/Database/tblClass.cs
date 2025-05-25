using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>ID of the objects types. Texts in tblDict.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblClass.html"/>
[Table("dbo.tblClass")]
public class tblClass {
    /// <summary>Enumeration representing node class codes.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblClass.ClassCode.html#fields"/>
    public enum ClassCode {
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
        Store = 42,
        ObjectModels = 43,
        ServerFarm = 44,
        Tablet = 46,
        ComputerNotebook = 47,
        ComputerVirtual = 48,
        ComputerTerminal = 49,
        ComputerServer = 50,
        Organization = 51,
        StandardHwCatalog = 52,
        StandardHwCategory = 53,
        StandardHwItem = 54,
        StagingRoom = 55,
        Contract = 56,
        Contracts = 57,
        MobilePhone = 58,
        NetworkDevice = 59,
        UnknownDevice = 60,
        AzureSubscription = 62,
        ResourceGroup = 63,
        AzureSqlServer = 64,
        AzureSqlDatabase = 65,
        AzureStorageAccount = 66,
        ComputerAzureVm = 67,
        AzureAppService = 68,
        Certificate = 69,
        Workstation = 70,
        Cabinet = 71,
        Chair = 72,
        Desk = 73,
        FirstUserClass = 5000,
    }
    /// <summary>Default object template (tblNode.intNodeId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblClass.html#Alvao_API_Common_Model_Database_tblClass_DefaultObjectTemplateNodeId"/>
    public virtual int? DefaultObjectTemplateNodeId { get; set; }
    /// <summary>Object name template</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblClass.html#Alvao_API_Common_Model_Database_tblClass_ObjectNameTemplate"/>
    public virtual string ObjectNameTemplate { get; set; }
    /// <summary>If the type is a computer</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblClass.html#Alvao_API_Common_Model_Database_tblClass_bComputer"/>
    public virtual bool bComputer { get; set; }
    /// <summary>Class Id</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblClass.html#Alvao_API_Common_Model_Database_tblClass_intClassId"/>
    [ExplicitKey]
    public virtual int intClassId { get; set; }
}
