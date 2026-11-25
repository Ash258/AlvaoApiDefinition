namespace Alvao.API.AM.Model.ObjectSorting;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.ObjectMovingByRuleModel.html"/>
public record ObjectMovingByRuleModel : IEquatable<ObjectMovingByRuleModel> {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.ObjectMovingByRuleModel.html#Alvao_API_AM_Model_ObjectSorting_ObjectMovingByRuleModel_ObjectId"/>
    public int ObjectId { get; init; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.ObjectMovingByRuleModel.html#Alvao_API_AM_Model_ObjectSorting_ObjectMovingByRuleModel_ObjectName"/>
    public string ObjectName { get; init; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.ObjectSorting.ObjectMovingByRuleModel.html#Alvao_API_AM_Model_ObjectSorting_ObjectMovingByRuleModel__ctor_System_Int32_System_String_"/>
    public ObjectMovingByRuleModel(int ObjectId, string ObjectName) { }
}
