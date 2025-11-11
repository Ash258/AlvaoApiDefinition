public class Settings 
{
    /*
     * When you move a computer from the Warehouse, a detection profile named "Standard" is automatically set for the computer.
     */

    public static readonly int movedObjectClassIdToCheck = (int)Alvao.API.AM.Model.ObjectClass.Code.Computer; // Object class ID of the moved object.
    public static readonly int oldParentobjectClassId = (int)Alvao.API.AM.Model.ObjectClass.Code.Warehouse; // Was moved object somewhere under the object of this Object class ID?
    public static readonly string detectionProfileName = "Standard"; // Name of the detection profile in database.
}
