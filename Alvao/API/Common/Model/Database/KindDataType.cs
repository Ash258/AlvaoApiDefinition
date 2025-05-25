using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Property data types in AM.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.KindDataType.html"/>
[Table("dbo.KindDataType")]
public class KindDataType {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.KindDataType.KindDataTypeIdEnum.html#fields"/>
    public enum KindDataTypeIdEnum {
        Text = 1,
        Date = 2,
        Float = 3,
        User = 4,
    }
    /// <summary>Property data type name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.KindDataType.html#Alvao_API_Common_Model_Database_KindDataType_DataTypeName"/>
    public virtual string DataTypeName { get; set; }
    /// <summary>Property data type ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.KindDataType.html#Alvao_API_Common_Model_Database_KindDataType_KindDataTypeId"/>
    [Key]
    public virtual int KindDataTypeId { get; set; }
}
