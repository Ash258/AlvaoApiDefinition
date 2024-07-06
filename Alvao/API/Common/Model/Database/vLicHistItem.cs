using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// License items.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vLicHistItem.htm"/>
[TableAttribute("dbo.vLicHistItem")]
public class vLicHistItem
{
    public virtual string ActivationKey { get; set; }
    public virtual int bolOEM { get; set; }
    public virtual int intLicHistItemId { get; set; }
    public virtual int LicensesCount { get; set; }
    public virtual int lintLicHistId { get; set; }
    public virtual int? NodeId { get; set; }
    public virtual string Object { get; set; }
    public virtual string txtDepartment { get; set; }
    public virtual string txtInventoryNum { get; set; }
    public virtual string txtMemo { get; set; }
    public virtual string txtRequest { get; set; }

    public vLicHistItem() { }
}
