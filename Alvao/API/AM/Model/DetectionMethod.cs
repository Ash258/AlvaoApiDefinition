namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.DetectionMethod.html"/>
public static class DetectionMethod {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.DetectionMethod.Type.html#fields"/>
    public enum Type {
        None = 0,
        Manual = 4,
        Auto = 5,
        Ssh = 6,
        Autonomous = 7,
        MSSccm = 8,
    }
}
