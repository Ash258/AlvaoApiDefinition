using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Objects and properties - Public + Asset + Computer1.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html"/>
[Table("dbo.vNodePropertyMix")]
public class vNodePropertyMix {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_AdGuid"/>
    public virtual string AdGuid { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_IsHidden"/>
    public virtual bool? IsHidden { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_bolAutoUpdate"/>
    public virtual bool bolAutoUpdate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_bolComputerStateOn"/>
    public virtual bool? bolComputerStateOn { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_bolIgnoreDifferences"/>
    public virtual bool bolIgnoreDifferences { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_intNodeId"/>
    public virtual int intNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_intNodeId1"/>
    public virtual int intNodeId1 { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_intNodeId2"/>
    public virtual int intNodeId2 { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_intNodeId3"/>
    public virtual int intNodeId3 { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_intState"/>
    public virtual int? intState { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_lintClassId"/>
    public virtual int? lintClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_lintIconId"/>
    public virtual int? lintIconId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_lintParentId"/>
    public virtual int? lintParentId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_txtBIOSSerialNumber"/>
    public virtual string txtBIOSSerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_txtEvidentiaryNumber"/>
    public virtual string txtEvidentiaryNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_txtInventoryNumber"/>
    public virtual string txtInventoryNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_txtInvoiceNumber"/>
    public virtual string txtInvoiceNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_txtManufacturer"/>
    public virtual string txtManufacturer { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_txtName"/>
    public virtual string txtName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_txtPath"/>
    public virtual string txtPath { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_txtProp_Name"/>
    public virtual string txtProp_Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_txtPurchased"/>
    public virtual DateTime? txtPurchased { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_txtSerialNumber"/>
    public virtual string txtSerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_txtType"/>
    public virtual string txtType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_txtTypeMark"/>
    public virtual string txtTypeMark { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_txtVendor"/>
    public virtual string txtVendor { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix.html#Alvao_API_Common_Model_Database_vNodePropertyMix_txtWarranty"/>
    public virtual string txtWarranty { get; set; }
}
