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
        Automatic = 5,
        AutonomousAgent = 7,
        Direct = 1,
        Manual = 4,
        None = 0,
        SCCM = 8,
        SSH = 6,
        SharedFolder = 3,
        TcpIp = 2,
    }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Detection.Status.html#fields"/>
    public enum Status {
        Error = 4,
        NoAnswer = 1,
        Ok = 2,
        Warning = 3,
    }
}
