using System.Data;
using Alvao.API.Common.Model.Database;
using static Alvao.API.Common.Model.Database.KindDataType;

namespace Alvao.API.AM.Model.Detection;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.CompareProperty.html"/>
public class CompareProperty {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.CompareProperty.html#Alvao_API_AM_Model_Detection_CompareProperty_DbColumnName"/>
    public string DbColumnName { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.CompareProperty.html#Alvao_API_AM_Model_Detection_CompareProperty_DbColumnType"/>
    public KindDataType.KindDataTypeIdEnum DbColumnType { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.CompareProperty.html#Alvao_API_AM_Model_Detection_CompareProperty_IsKey"/>
    public bool IsKey { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.CompareProperty.html#Alvao_API_AM_Model_Detection_CompareProperty_KindCode"/>
    public Kind.KindCode KindCode { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.CompareProperty.html#Alvao_API_AM_Model_Detection_CompareProperty_KindId"/>
    public int KindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.CompareProperty.html#Alvao_API_AM_Model_Detection_CompareProperty_PropertyName"/>
    public string PropertyName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.CompareProperty.html#Alvao_API_AM_Model_Detection_CompareProperty_TreeColumnName"/>
    public string TreeColumnName { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.CompareProperty.html#Alvao_API_AM_Model_Detection_CompareProperty_TreeValue"/>
    public object TreeValue { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.CompareProperty.html#Alvao_API_AM_Model_Detection_CompareProperty_WmiAttribute"/>
    public string WmiAttribute { get; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.CompareProperty.html#Alvao_API_AM_Model_Detection_CompareProperty__ctor"/>
    public CompareProperty() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.CompareProperty.html#Alvao_API_AM_Model_Detection_CompareProperty__ctor_Alvao_API_AM_Model_Kind_KindCode_System_Boolean_System_String_Alvao_API_Common_Model_Database_KindDataType_KindDataTypeIdEnum_"/>
    public CompareProperty(Kind.KindCode kindCode, bool isKey, string dbColumnName, KindDataType.KindDataTypeIdEnum dbColumnType = KindDataTypeIdEnum.Text) { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.CompareProperty.html#Alvao_API_AM_Model_Detection_CompareProperty__ctor_Alvao_API_AM_Model_Kind_KindCode_System_String_System_Boolean_System_String_Alvao_API_Common_Model_Database_KindDataType_KindDataTypeIdEnum_"/>
    public CompareProperty(Kind.KindCode kindCode, string wmiAttribute, bool isKey, string dbColumnName, KindDataType.KindDataTypeIdEnum dbColumnType = KindDataTypeIdEnum.Text) { }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.CompareProperty.html#Alvao_API_AM_Model_Detection_CompareProperty_IsKeySameValue_System_Data_DataRow_System_Data_DataRow_"/>
    public bool IsKeySameValue(DataRow treeObject, DataRow wmiObject) { throw new System.NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.CompareProperty.html#Alvao_API_AM_Model_Detection_CompareProperty_IsSameValue_System_Data_DataRow_System_Data_DataRow_"/>
    public bool IsSameValue(DataRow treeObject, DataRow wmiObject) { throw new System.NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.CompareProperty.html#Alvao_API_AM_Model_Detection_CompareProperty_Load_Alvao_API_AM_Repository_IDetectionRepository_System_Int32_"/>
    public bool Load(IDetectionRepository repo, int nodeId) { throw new System.NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.CompareProperty.html#Alvao_API_AM_Model_Detection_CompareProperty_NormalizedWmiValue_System_Data_DataRow_"/>
    public string NormalizedWmiValue(DataRow wmiObject) { throw new System.NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.CompareProperty.html#Alvao_API_AM_Model_Detection_CompareProperty_UpdateValue_Alvao_API_AM_Repository_IObjectPropertyRepository_System_Int32_System_Object_System_String_System_Nullable_System_DateTime__System_Nullable_System_Double__System_Nullable_System_Int32__System_Int32_System_Boolean_"/>
    public bool UpdateValue(IObjectPropertyRepository repo, int nodeId, object treeValue, string wmiValueString, DateTime? wmiValueDate, double? wmiValueDouble, int? wmiValueInt, int personId, bool isNewObject) { throw new System.NotImplementedException(); }
}
