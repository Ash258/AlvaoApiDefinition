namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.AssetAutoAction.html"/>
public static class AssetAutoAction {
    /// <summary>Flags representing asset management auto action types.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.AssetAutoAction.AutoActionTypes.html#fields"/>
    [Flags]
    public enum AutoActionTypes {
        None = 1,
        ObjectMoved = 16,
        ObjectMoving = 8,
        ObjectPropertyModified = 4,
        ObjectPropertyModifying = 2,
    }
}
