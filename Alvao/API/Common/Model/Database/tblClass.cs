using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>ID of the objects types. Texts in tblDict.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblClass.htm"/>
[TableAttribute("dbo.tblClass")]
public class tblClass {
    /// <summary>Enumeration representing node class codes.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblClass_ClassCode.htm"/>
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
        Tablet = 46,
        ComputerNotebook = 47,
        ComputerVirtual = 48,
        ComputerTerminal = 49,
        ComputerServer = 50,
        Organization = 51,
        MobilePhone = 58,
        FirstUserClass = 5_000,
    }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblClass_bComputer.htm"/>
    public virtual bool bComputer { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblClass_DefaultObjectTemplateNodeId.htm"/>
    public virtual int? DefaultObjectTemplateNodeId { get; set; }
    /// <summary>Class Id</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblClass_intClassId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int intClassId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblClass__ctor.htm"/>
    public tblClass() { }
}
