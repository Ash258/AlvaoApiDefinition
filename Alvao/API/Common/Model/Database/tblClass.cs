using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>ID of the objects types. Texts in tblDict.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblClass.html"/>
[Table("dbo.tblClass")]
public class tblClass {
    /// <summary>Enumeration representing node class codes.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblClass.ClassCode.html#fields"/>
    public enum ClassCode {
        ADImportedObjects = 34,
        AutoloadFolder = 32,
        AzureAppService = 68,
        AzureSqlDatabase = 65,
        AzureSqlServer = 64,
        AzureStorageAccount = 66,
        AzureSubscription = 62,
        Bluetooth = 27,
        Cabinet = 71,
        Cdrom = 9,
        Centre = 41,
        Certificate = 69,
        Chair = 72,
        Computer = 5,
        ComputerAzureVm = 67,
        ComputerNotebook = 47,
        ComputerServer = 50,
        ComputerSet = 6,
        ComputerTerminal = 49,
        ComputerVirtual = 48,
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
        ImportedObjects = 33,
        Joystick = 25,
        Keyboard = 14,
        Mainboard = 15,
        MediaCard = 20,
        MobilePhone = 58,
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
        ServerFarm = 44,
        SpecObjPropTabs = 4,
        SpecObjTemplate = 3,
        SpecObjTrash = 2,
        StagingRoom = 55,
        StandardHwCatalog = 52,
        StandardHwCategory = 53,
        StandardHwItem = 54,
        Store = 42,
        Tablet = 46,
        Tape = 23,
        Unioin = 36,
        UnknownDevice = 60,
        Ups = 22,
        User = 7,
        Workplace = 38,
        Workstation = 70,
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
