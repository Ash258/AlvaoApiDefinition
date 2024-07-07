namespace Alvao.API.AM.Model;

[FlagsAttribute]
public enum ObjectsBulkMoveResult
{
    Ok = 0,
    NoRights = 1,
    SomeRightsMissing = 2,
    ObjectNotMovable = 4,
    IsTargetObject = 8,
    TargetObjectIsChildObjectOfTransferred = 16,
    AlreadyInTarget = 32,
}
