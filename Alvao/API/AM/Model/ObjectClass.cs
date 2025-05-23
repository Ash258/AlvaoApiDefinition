namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Model_ObjectClass.htm"/>
public static class ObjectClass {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Model_ObjectClass_Code.htm"/>
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
        ImportedEntraIdObjects = 61,
        FirstUserClass = 5_000,
    }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Model_ObjectClass_ImportedObjectsFolderType.htm"/>
    public enum ImportedObjectsFolderType {
        ImportedObjects = 33,
        ImportedAdObjects = 34,
        ImportedEntraIdObjects = 61,
    }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Model_ObjectClass_IsSpecial.htm"/>
    ///
    /// <param name="classCode"> </param>
    public static bool IsSpecial(
        int? classCode
    ) { throw new System.NotImplementedException(); }
}
