namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectRight.html"/>
public static class ObjectRight {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectRight.Right.html#fields"/>
    public enum Right {
        CanObjectCreate = 5,
        CanObjectDelete = 3,
        CanObjectMove = 4,
        CanObjectRead = 1,
        CanObjectWrite = 2,
        IsSystemAdmin = 0,
    }
}
