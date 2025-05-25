using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Objects and properties - Assets Number, Purchase Date, Warranty expiration, Manufacturer, Packing Slip Number.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix_Asset.html"/>
[Table("dbo.vNodePropertyMix_Asset")]
public class vNodePropertyMix_Asset {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix_Asset.html#Alvao_API_Common_Model_Database_vNodePropertyMix_Asset_intNodeId2"/>
    public virtual int intNodeId2 { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix_Asset.html#Alvao_API_Common_Model_Database_vNodePropertyMix_Asset_txtInventoryNumber"/>
    public virtual string txtInventoryNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix_Asset.html#Alvao_API_Common_Model_Database_vNodePropertyMix_Asset_txtInvoiceNumber"/>
    public virtual string txtInvoiceNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix_Asset.html#Alvao_API_Common_Model_Database_vNodePropertyMix_Asset_txtPurchased"/>
    public virtual DateTime? txtPurchased { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix_Asset.html#Alvao_API_Common_Model_Database_vNodePropertyMix_Asset_txtVendor"/>
    public virtual string txtVendor { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix_Asset.html#Alvao_API_Common_Model_Database_vNodePropertyMix_Asset_txtWarranty"/>
    public virtual string txtWarranty { get; set; }
}
