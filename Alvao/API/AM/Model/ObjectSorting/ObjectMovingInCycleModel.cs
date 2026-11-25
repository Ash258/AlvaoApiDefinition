namespace Alvao.API.AM.Model.ObjectSorting;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.ObjectMovingInCycleModel.html"/>
public record ObjectMovingInCycleModel : IEquatable<ObjectMovingInCycleModel> {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.ObjectMovingInCycleModel.html#Alvao_API_AM_Model_ObjectSorting_ObjectMovingInCycleModel_NodeId"/>
    public int NodeId { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.ObjectMovingInCycleModel.html#Alvao_API_AM_Model_ObjectSorting_ObjectMovingInCycleModel_RuleId"/>
    public int RuleId { get; init; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.ObjectMovingInCycleModel.html#Alvao_API_AM_Model_ObjectSorting_ObjectMovingInCycleModel__ctor_System_Int32_System_Int32_"/>
    public ObjectMovingInCycleModel(int NodeId, int RuleId) { }
}
