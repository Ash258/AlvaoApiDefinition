namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Model_ObjectRight.htm"/>
public static class ObjectRight {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Model_ObjectRight_Right.htm"/>
    public enum Right {
        IsSystemAdmin = 0,
        CanObjectRead = 1,
        CanObjectWrite = 2,
        CanObjectDelete = 3,
        CanObjectMove = 4,
        CanObjectCreate = 5,
    }
}
