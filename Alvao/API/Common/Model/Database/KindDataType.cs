using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Property data types in AM.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_KindDataType.htm"/>
[TableAttribute("dbo.KindDataType")]
public class KindDataType {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_KindDataType_KindDataTypeIdEnum.htm"/>
    public enum KindDataTypeIdEnum {
        Text = 1,
        Date = 2,
        Float = 3,
        User = 4,
    }
    /// <summary>Property data type name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_KindDataType_DataTypeName.htm"/>
    public virtual string DataTypeName { get; set; }
    /// <summary>Property data type ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_KindDataType_KindDataTypeId.htm"/>
    [KeyAttribute]
    public virtual int KindDataTypeId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_KindDataType__ctor.htm"/>
    public KindDataType() { }
}
