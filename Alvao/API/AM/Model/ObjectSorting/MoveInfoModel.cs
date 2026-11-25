namespace Alvao.API.AM.Model.ObjectSorting;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.MoveInfoModel.html"/>
public record MoveInfoModel : IEquatable<MoveInfoModel> {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.MoveInfoModel.html#Alvao_API_AM_Model_ObjectSorting_MoveInfoModel_LastMoveTime"/>
    public DateTime LastMoveTime { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.MoveInfoModel.html#Alvao_API_AM_Model_ObjectSorting_MoveInfoModel_ObjectConditionColumns"/>
    public IEnumerable<string> ObjectConditionColumns { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.MoveInfoModel.html#Alvao_API_AM_Model_ObjectSorting_MoveInfoModel_ObjectOfAllTypeIds"/>
    public IEnumerable<int> ObjectOfAllTypeIds { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.MoveInfoModel.html#Alvao_API_AM_Model_ObjectSorting_MoveInfoModel_RuleCondition"/>
    public string RuleCondition { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.MoveInfoModel.html#Alvao_API_AM_Model_ObjectSorting_MoveInfoModel_RuleId"/>
    public int RuleId { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.MoveInfoModel.html#Alvao_API_AM_Model_ObjectSorting_MoveInfoModel_SrcAllObjects"/>
    public bool SrcAllObjects { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.MoveInfoModel.html#Alvao_API_AM_Model_ObjectSorting_MoveInfoModel_SrcObjectIds"/>
    public IEnumerable<int> SrcObjectIds { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.MoveInfoModel.html#Alvao_API_AM_Model_ObjectSorting_MoveInfoModel_SrcTypeIds"/>
    public IEnumerable<int> SrcTypeIds { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.MoveInfoModel.html#Alvao_API_AM_Model_ObjectSorting_MoveInfoModel_TarObjectId"/>
    public int? TarObjectId { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.MoveInfoModel.html#Alvao_API_AM_Model_ObjectSorting_MoveInfoModel_TarObjectType"/>
    public int? TarObjectType { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.MoveInfoModel.html#Alvao_API_AM_Model_ObjectSorting_MoveInfoModel_TargetConditionColumns"/>
    public IEnumerable<string> TargetConditionColumns { get; init; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.MoveInfoModel.html#Alvao_API_AM_Model_ObjectSorting_MoveInfoModel__ctor_System_Int32_System_Collections_Generic_IEnumerable_System_Int32__System_Collections_Generic_IEnumerable_System_Int32__System_Boolean_System_Collections_Generic_IEnumerable_System_Int32__System_Nullable_System_Int32__System_Nullable_System_Int32__System_String_System_Collections_Generic_IEnumerable_System_String__System_Collections_Generic_IEnumerable_System_String__System_DateTime_"/>
    public MoveInfoModel(int RuleId, IEnumerable<int> SrcObjectIds, IEnumerable<int> SrcTypeIds, bool SrcAllObjects, IEnumerable<int> ObjectOfAllTypeIds, int? TarObjectType, int? TarObjectId, string RuleCondition, IEnumerable<string> ObjectConditionColumns, IEnumerable<string> TargetConditionColumns, DateTime LastMoveTime) { }
}
