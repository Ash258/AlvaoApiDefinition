using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Objects and properties - Assets Number, Purchase Date, Warranty expiration, Manufacturer, Packing Slip///           Number.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vNodePropertyMix_Asset.htm"/>
[TableAttribute("dbo.vNodePropertyMix_Asset")]
public class vNodePropertyMix_Asset
{
    public virtual int intNodeId2 { get; set; }
    public virtual string txtInventoryNumber { get; set; }
    public virtual string txtInvoiceNumber { get; set; }
    public virtual string txtPurchased { get; set; }
    public virtual string txtVendor { get; set; }
    public virtual string txtWarranty { get; set; }

    public vNodePropertyMix_Asset() { }
}
