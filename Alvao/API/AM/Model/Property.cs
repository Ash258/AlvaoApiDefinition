using Newtonsoft.Json;

namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Model_Property.htm"/>
public class Property
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_Property_CanModify.htm"/>
    [JsonIgnoreAttribute]
    public bool CanModify { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_Property_ClassId.htm"/>
    [JsonIgnoreAttribute]
    public int ClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_Property_DbName.htm"/>
    [JsonIgnoreAttribute]
    public string DbName { get; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_Property_HasGlobalScope.htm"/>
    [JsonIgnoreAttribute]
    public bool HasGlobalScope { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_Property_IsDetected.htm"/>
    [JsonIgnoreAttribute]
    public bool IsDetected { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_Property_IsFromAd.htm"/>
    [JsonIgnoreAttribute]
    public bool IsFromAd { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_Property_IsUnique.htm"/>
    [JsonIgnoreAttribute]
    public bool IsUnique { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_Property_KindCode.htm"/>
    [JsonIgnoreAttribute]
    public Kind.KindCode KindCode { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_Property_KindDataType.htm"/>
    [JsonIgnoreAttribute]
    public Kind.DataType KindDataType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_Property_KindId.htm"/>
    [JsonIgnoreAttribute]
    public int KindId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_Property_LikeValue.htm"/>
    [JsonIgnoreAttribute]
    public string LikeValue { get; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_Property_Name.htm"/>
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_Property_NameOrder.htm"/>
    public int? NameOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_Property_ObjectId.htm"/>
    [JsonIgnoreAttribute]
    public int ObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_Property_ParentNodeId.htm"/>
    [JsonIgnoreAttribute]
    public int? ParentNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_Property_PropertyId.htm"/>
    public int PropertyId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_Property_SampleString.htm"/>
    [JsonIgnoreAttribute]
    public string SampleString { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_Property_SequenceId.htm"/>
    [JsonIgnoreAttribute]
    public int SequenceId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_Property_Value.htm"/>
    public string Value { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_Property_ValueIsSelectionOnly.htm"/>
    [JsonIgnoreAttribute]
    public bool ValueIsSelectionOnly { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_Property_ValueKindId.htm"/>
    [JsonIgnoreAttribute]
    public int? ValueKindId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Model_Property__ctor.htm"/>
    public Property() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Model_Property__ctor_1.htm"/>
    public Property(
        int propertyId,
        int sequenceId
    )
    { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Model_Property__ctor_2.htm"/>
    public Property(
        string name,
        string value
    )
    { }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Model_Property_IsInherited.htm"/>
    public bool IsInherited() { throw new System.NotImplementedException(); }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Model_Property_IsQueryProperty.htm"/>
    public bool IsQueryProperty() { throw new System.NotImplementedException(); }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Model_Property_IsSystemProperty.htm"/>
    public bool IsSystemProperty() { throw new System.NotImplementedException(); }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Model_Property_Validate.htm"/>
    public bool Validate() { throw new System.NotImplementedException(); }
}
