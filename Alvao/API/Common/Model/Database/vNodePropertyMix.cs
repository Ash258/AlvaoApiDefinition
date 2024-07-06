using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Objects and properties - Public + Asset + Computer1.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vNodePropertyMix.htm"/>
[TableAttribute("dbo.vNodePropertyMix")]
public class vNodePropertyMix
{
    public virtual bool bolAutoUpdate { get; set; }
    public virtual bool? bolComputerStateOn { get; set; }
    public virtual bool bolIgnoreDifferences { get; set; }
    public virtual int intNodeId { get; set; }
    public virtual int intNodeId1 { get; set; }
    public virtual int intNodeId2 { get; set; }
    public virtual int intNodeId3 { get; set; }
    public virtual int? intState { get; set; }
    public virtual bool? IsHidden { get; set; }
    public virtual int? lintClassId { get; set; }
    public virtual int? lintIconId { get; set; }
    public virtual int? lintParentId { get; set; }
    public virtual string txtBIOSSerialNumber { get; set; }
    public virtual string txtEvidentiaryNumber { get; set; }
    public virtual string txtInventoryNumber { get; set; }
    public virtual string txtInvoiceNumber { get; set; }
    public virtual string txtLDAPGUID { get; set; }
    public virtual string txtManufacturer { get; set; }
    public virtual string txtName { get; set; }
    public virtual string txtPath { get; set; }
    public virtual string txtProp_Name { get; set; }
    public virtual string txtPurchased { get; set; }
    public virtual string txtSerialNumber { get; set; }
    public virtual string txtType { get; set; }
    public virtual string txtTypeMark { get; set; }
    public virtual string txtVendor { get; set; }
    public virtual string txtWarranty { get; set; }

    public vNodePropertyMix() { }
}
