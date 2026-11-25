namespace Alvao.API.AM.Model.Detection;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Detection.html"/>
public static class Detection {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Detection.Kind.html#fields"/>
    public enum Kind {
        Hardware = 1,
        Software = 2,
    }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Detection.Method.html#fields"/>
    public enum Method {
        None = 0,
        Manual = 4,
        Automatic = 5,
        SSH = 6,
        AutonomousAgent = 7,
        SCCM = 8,
        Intune = 9,
    }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Detection.MethodBehaviorId.html#fields"/>
    public enum MethodBehaviorId {
        SSH = 0,
        Automatic = 1,
        AutonomousAgent = 2,
        SCCM = 6,
        Manual = 7,
        Intune = 8,
    }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Detection.ScanDataType.html#fields"/>
    public enum ScanDataType {
        Xml = 0,
        Json = 1,
    }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Detection.Status.html#fields"/>
    public enum Status {
        NoAnswer = 1,
        Ok = 2,
        Warning = 3,
        Error = 4,
    }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Detection.html#Alvao_API_AM_Model_Detection_Detection_ToAliasString_Alvao_API_AM_Model_Detection_Detection_Kind_"/>
    public static string ToAliasString(this Detection.Kind kind) { throw new NotImplementedException(); }
}
