using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Products covered by licenses on the computers.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSwLic_ProductComputer.htm"/>
[TableAttribute("dbo.vSwLic_ProductComputer")]
public class vSwLic_ProductComputer
{
    public virtual string ActivationKey { get; set; }
    public virtual int bolOEM { get; set; }
    public virtual DateTime? CreatedDate { get; set; }
    public virtual int? CreatedPersonId { get; set; }
    public virtual int intLicHistId { get; set; }
    public virtual int intLicHistItemId { get; set; }
    public virtual int? LicTypeId { get; set; }
    public virtual int? lintProductDowngradeFromId { get; set; }
    public virtual int lintProductId { get; set; }
    public virtual int? lintProductPackFromId { get; set; }
    public virtual int? NodeId { get; set; }
    public virtual bool NoProductInstallation { get; set; }
    public virtual string txtCertificateNo { get; set; }
    public virtual string txtDepartment { get; set; }
    public virtual string txtInventoryNum { get; set; }
    public virtual string txtMemo { get; set; }

    public vSwLic_ProductComputer() { }
}
