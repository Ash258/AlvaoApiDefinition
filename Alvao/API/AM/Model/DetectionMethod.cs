namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.DetectionMethod.html"/>
public static class DetectionMethod {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.DetectionMethod.Type.html#fields"/>
    public enum Type {
        Auto = 5,
        Autonomous = 7,
        Direct = 1,
        MSSccm = 8,
        Manual = 4,
        None = 0,
        Ssh = 6,
        Tcpip = 2,
    }
}
