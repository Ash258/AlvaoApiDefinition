public class Settings
{
    /*
     * Objects that do not have all the mandatory properties filled in cannot be moved from the Storage room to another location in the object tree.
     */

    public static readonly int ObjectClassToCheckId = (int)Alvao.API.AM.Model.ObjectClass.Code.Warehouse; // Object class ID.
    public static readonly string ErrorMessage = "Fill in all mandatory properties of the object before moving from the storage room."; // Error message.
}
