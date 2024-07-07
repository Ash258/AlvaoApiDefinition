namespace Alvao.API.AM.Model;

public static class ObjectRight
{
    public enum Right
    {
        IsSystemAdmin = 0,
        CanObjectRead = 1,
        CanObjectWrite = 2,
        CanObjectDelete = 3,
        CanObjectMove = 4,
        CanObjectCreate = 5,
    }

}
