using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>ALVAO system settings.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tProperty.html"/>
[Table("dbo.tProperty")]
public class tProperty {
    /// <summary>Truth value.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tProperty.html#Alvao_API_Common_Model_Database_tProperty_bPropertyValue"/>
    /// <remarks>Column <c>bPropertyValue</c>: bit, null.</remarks>
    public virtual bool? bPropertyValue { get; set; }
    /// <summary>Time value</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tProperty.html#Alvao_API_Common_Model_Database_tProperty_dPropertyValue"/>
    /// <remarks>Column <c>dPropertyValue</c>: datetime, null.</remarks>
    public virtual DateTime? dPropertyValue { get; set; }
    /// <summary>Integer value.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tProperty.html#Alvao_API_Common_Model_Database_tProperty_iPropertyValue"/>
    /// <remarks>Column <c>iPropertyValue</c>: int, null.</remarks>
    public virtual int? iPropertyValue { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tProperty.html#Alvao_API_Common_Model_Database_tProperty_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    public virtual int id { get; set; }
    /// <summary>Real value</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tProperty.html#Alvao_API_Common_Model_Database_tProperty_nPropertyValue"/>
    /// <remarks>Column <c>nPropertyValue</c>: float, null.</remarks>
    public virtual double? nPropertyValue { get; set; }
    /// <summary>Name of settings.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tProperty.html#Alvao_API_Common_Model_Database_tProperty_sProperty"/>
    /// <remarks>Column <c>sProperty</c>: nvarchar(255), not null.</remarks>
    [ExplicitKey]
    public virtual string sProperty { get; set; }
    /// <summary>Text value</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tProperty.html#Alvao_API_Common_Model_Database_tProperty_sPropertyValue"/>
    /// <remarks>Column <c>sPropertyValue</c>: nvarchar(2048), null.</remarks>
    public virtual string sPropertyValue { get; set; }
}
