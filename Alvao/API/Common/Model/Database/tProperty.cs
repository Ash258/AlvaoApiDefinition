using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>ALVAO system settings.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tProperty.html"/>
[Table("dbo.tProperty")]
public class tProperty {
    /// <summary>Truth value.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tProperty.html#Alvao_API_Common_Model_Database_tProperty_bPropertyValue"/>
    public virtual bool? bPropertyValue { get; set; }
    /// <summary>Time value</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tProperty.html#Alvao_API_Common_Model_Database_tProperty_dPropertyValue"/>
    public virtual DateTime? dPropertyValue { get; set; }
    /// <summary>Integer value.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tProperty.html#Alvao_API_Common_Model_Database_tProperty_iPropertyValue"/>
    public virtual int? iPropertyValue { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tProperty.html#Alvao_API_Common_Model_Database_tProperty_id"/>
    public virtual int id { get; set; }
    /// <summary>Real value</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tProperty.html#Alvao_API_Common_Model_Database_tProperty_nPropertyValue"/>
    public virtual double? nPropertyValue { get; set; }
    /// <summary>Name of settings.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tProperty.html#Alvao_API_Common_Model_Database_tProperty_sProperty"/>
    [ExplicitKey]
    public virtual string sProperty { get; set; }
    /// <summary>Text value</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tProperty.html#Alvao_API_Common_Model_Database_tProperty_sPropertyValue"/>
    public virtual string sPropertyValue { get; set; }
}
