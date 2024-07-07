namespace Alvao.API.AM.Model;

public class ObjectHistoryModel
{
    public enum EHistoryFlag
    {
        HistfMoveDest = 1,
        HistfMoveSrc = 2,
        HistfTo = 3,
        HistfInsertNew = 4,
        HistfToNew = 5,
        HistfShift = 8,
        HistfMask = 65_280,
    }

    public int DetectId { get; set; }
    public int Flags { get; set; }
    public int ObjectId { get; set; }
    public int? Op2ObjectId { get; set; }
    public string Op2ObjectName { get; set; }
    public int? OpObjectId { get; set; }
    public string OpObjectName { get; set; }
    public int PersonId { get; set; }

    public ObjectHistoryModel() { }
}
