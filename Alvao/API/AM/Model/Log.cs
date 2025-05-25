namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Log.html"/>
public class Log {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Log.Kind.html#fields"/>
    public enum Kind {
        ComputerOff = 5,
        DetCantUpdateObject = 8,
        DetNoAnsFile = 6,
        DiffDetVsTree = 7,
        DuplicitComputer = 12,
        Error = 3,
        HwDetectionPerformed = 9,
        Info = 1,
        InventoryPerformed = 11,
        Null = 0,
        PropertyChanged = 4,
        SwDetectionPerformed = 10,
        Warning = 2,
    }
}
