using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Objects and properties - Type Designation, Serial Number, Manufacturer, Registration Number, Name.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vNodePropertyMix_Public.htm"/>
[TableAttribute("dbo.vNodePropertyMix_Public")]
public class vNodePropertyMix_Public
{
    public virtual int intNodeId1 { get; set; }
    public virtual string txtEvidentiaryNumber { get; set; }
    public virtual string txtManufacturer { get; set; }
    public virtual string txtProp_Name { get; set; }
    public virtual string txtSerialNumber { get; set; }
    public virtual string txtTypeMark { get; set; }

    public vNodePropertyMix_Public() { }
}
