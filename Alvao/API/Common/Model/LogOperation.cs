namespace Alvao.API.Common.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.LogOperation.html"/>
public static class LogOperation {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.LogOperation.Operation.html#fields"/>
    public enum Operation {
        Edit = 2,
        Insert = 1,
        Remove = 3,
    }
}
