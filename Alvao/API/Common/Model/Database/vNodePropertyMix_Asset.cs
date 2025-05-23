using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Objects and properties - Assets Number, Purchase Date, Warranty expiration, Manufacturer, Packing Slip Number.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vNodePropertyMix_Asset.htm"/>
[TableAttribute("dbo.vNodePropertyMix_Asset")]
public class vNodePropertyMix_Asset
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNodePropertyMix_Asset_intNodeId2.htm"/>
    public virtual int intNodeId2 { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNodePropertyMix_Asset_txtInventoryNumber.htm"/>
    public virtual string txtInventoryNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNodePropertyMix_Asset_txtInvoiceNumber.htm"/>
    public virtual string txtInvoiceNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNodePropertyMix_Asset_txtPurchased.htm"/>
    public virtual string txtPurchased { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNodePropertyMix_Asset_txtVendor.htm"/>
    public virtual string txtVendor { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNodePropertyMix_Asset_txtWarranty.htm"/>
    public virtual string txtWarranty { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vNodePropertyMix_Asset__ctor.htm"/>
    public vNodePropertyMix_Asset() { }
}
