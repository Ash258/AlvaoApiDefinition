using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Objects and properties - Type Designation, Serial Number, Manufacturer, Registration Number, Name.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix_Public.html"/>
[Table("dbo.vNodePropertyMix_Public")]
public class vNodePropertyMix_Public {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix_Public.html#Alvao_API_Common_Model_Database_vNodePropertyMix_Public_intNodeId1"/>
    public virtual int intNodeId1 { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix_Public.html#Alvao_API_Common_Model_Database_vNodePropertyMix_Public_txtEvidentiaryNumber"/>
    public virtual string txtEvidentiaryNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix_Public.html#Alvao_API_Common_Model_Database_vNodePropertyMix_Public_txtManufacturer"/>
    public virtual string txtManufacturer { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix_Public.html#Alvao_API_Common_Model_Database_vNodePropertyMix_Public_txtProp_Name"/>
    public virtual string txtProp_Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix_Public.html#Alvao_API_Common_Model_Database_vNodePropertyMix_Public_txtSerialNumber"/>
    public virtual string txtSerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix_Public.html#Alvao_API_Common_Model_Database_vNodePropertyMix_Public_txtTypeMark"/>
    public virtual string txtTypeMark { get; set; }
}
