using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// ALVAO system settings.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tProperty.htm"/>
[TableAttribute("dbo.tProperty")]
public class tProperty
{
    /// <summary>Truth value.</summary>
    public virtual bool? bPropertyValue { get; set; }
    /// <summary>Time value</summary>
    public virtual DateTime? dPropertyValue { get; set; }
    /// <summary>Record ID</summary>
    public virtual int id { get; set; }
    /// <summary>Integer value.</summary>
    public virtual int? iPropertyValue { get; set; }
    /// <summary>Real value</summary>
    public virtual double? nPropertyValue { get; set; }
    /// <summary>Name of settings.</summary>
    [ExplicitKeyAttribute]
    public virtual string sProperty { get; set; }
    /// <summary>Text value</summary>
    public virtual string sPropertyValue { get; set; }

    public tProperty() { }
}
