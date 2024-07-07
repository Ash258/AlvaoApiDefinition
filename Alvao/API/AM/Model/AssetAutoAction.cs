namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Model_AssetAutoAction.htm"/>
public static class AssetAutoAction
{
    [FlagsAttribute]
    public enum AutoActionTypes
    {
        None = 1,
        ObjectPropertyModifying = 2,
        ObjectPropertyModified = 4,
        ObjectMoving = 8,
        ObjectMoved = 16,
    }
}
