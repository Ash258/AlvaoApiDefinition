using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Property data types in AM.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_KindDataType.htm"/>
[TableAttribute("dbo.KindDataType")]
public class KindDataType
{
    public enum KindDataTypeIdEnum
    {
        Text = 1,
        Date = 2,
        Float = 3,
        User = 4,
    }


    /// <summary>Property data type name.</summary>
    public virtual string DataTypeName { get; set; }
    /// <summary>Property data type ID.</summary>
    [KeyAttribute]
    public virtual int KindDataTypeId { get; set; }

    public KindDataType() { }
}
