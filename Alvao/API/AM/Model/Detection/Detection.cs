namespace Alvao.API.AM.Model.Detection;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Detection.html"/>
public static class Detection {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Detection.Kind.html#fields"/>
    public enum Kind {
        Hardware = 1,
        Software = 2,
    }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Detection.Method.html#fields"/>
    public enum Method {
        None = 0,
        Direct = 1,
        TcpIp = 2,
        SharedFolder = 3,
        Manual = 4,
        Automatic = 5,
        SSH = 6,
        AutonomousAgent = 7,
        SCCM = 8,
    }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Detection.Status.html#fields"/>
    public enum Status {
        NoAnswer = 1,
        Ok = 2,
        Warning = 3,
        Error = 4,
    }
}
