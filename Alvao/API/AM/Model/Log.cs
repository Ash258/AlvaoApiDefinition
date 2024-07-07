namespace Alvao.API.AM.Model;

public class Log
{
    public enum Kind
    {
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


    public Log() { }
}
