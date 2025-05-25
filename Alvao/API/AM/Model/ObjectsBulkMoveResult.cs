namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectsBulkMoveResult.html"/>
[Flags]
public enum ObjectsBulkMoveResult {
    AlreadyInTarget = 32,
    IsTargetObject = 8,
    NoRights = 1,
    ObjectNotMovable = 4,
    Ok = 0,
    SomeRightsMissing = 2,
    TargetObjectIsChildObjectOfTransferred = 16,
}
