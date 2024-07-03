namespace Alvao.API.AM.Model;

[FlagsAttribute]
public enum AutoActionTypes
{
    None = 1,
    ObjectPropertyModifying = 2,
    ObjectPropertyModified = 4,
    ObjectMoving = 8,
    ObjectMoved = 16,
}
