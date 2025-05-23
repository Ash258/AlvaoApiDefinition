namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Model_ObjectsBulkMoveResult.htm"/>
[FlagsAttribute]
public enum ObjectsBulkMoveResult {
    Ok = 0,
    NoRights = 1,
    SomeRightsMissing = 2,
    ObjectNotMovable = 4,
    IsTargetObject = 8,
    TargetObjectIsChildObjectOfTransferred = 16,
    AlreadyInTarget = 32,
}
