namespace Alvao.API.AM.Model;

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
