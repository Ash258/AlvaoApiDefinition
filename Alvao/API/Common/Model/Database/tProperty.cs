using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>ALVAO system settings.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tProperty.htm"/>
[TableAttribute("dbo.tProperty")]
public class tProperty
{
    /// <summary>Truth value.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tProperty_bPropertyValue.htm"/>
    public virtual bool? bPropertyValue { get; set; }
    /// <summary>Time value</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tProperty_dPropertyValue.htm"/>
    public virtual DateTime? dPropertyValue { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tProperty_id.htm"/>
    public virtual int id { get; set; }
    /// <summary>Integer value.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tProperty_iPropertyValue.htm"/>
    public virtual int? iPropertyValue { get; set; }
    /// <summary>Real value</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tProperty_nPropertyValue.htm"/>
    public virtual double? nPropertyValue { get; set; }
    /// <summary>Name of settings.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tProperty_sProperty.htm"/>
    [ExplicitKeyAttribute]
    public virtual string sProperty { get; set; }
    /// <summary>Text value</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tProperty_sPropertyValue.htm"/>
    public virtual string sPropertyValue { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tProperty__ctor.htm"/>
    public tProperty() { }
}
