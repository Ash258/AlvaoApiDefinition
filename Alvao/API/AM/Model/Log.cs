namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Log.html"/>
public class Log {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Log.Kind.html#fields"/>
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
}
