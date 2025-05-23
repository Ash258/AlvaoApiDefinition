namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Model_Log.htm"/>
public class Log {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Model_Log_Kind.htm"/>
    public enum Kind {
        Null = 0,
        Info = 1,
        Warning = 2,
        Error = 3,
        PropertyChanged = 4,
        ComputerOff = 5,
        DetNoAnsFile = 6,
        DiffDetVsTree = 7,
        DetCantUpdateObject = 8,
        HwDetectionPerformed = 9,
        SwDetectionPerformed = 10,
        InventoryPerformed = 11,
        DuplicitComputer = 12,
    }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Model_Log__ctor.htm"/>
    public Log() { }
}
