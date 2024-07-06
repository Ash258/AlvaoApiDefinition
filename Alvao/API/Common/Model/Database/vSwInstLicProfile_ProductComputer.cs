using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Installed software vs licenses and software profiles. Note: This view is outdated and should not be used. It///           will be removed in a future version of ALVAO.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSwInstLicProfile_ProductComputer.htm"/>
[TableAttribute("dbo.vSwInstLicProfile_ProductComputer")]
public class vSwInstLicProfile_ProductComputer
{
    public virtual int bError { get; set; }
    public virtual int CoversMoreProds { get; set; }
    public virtual int? iLicStatusId { get; set; }
    public virtual int intFrom { get; set; }
    public virtual int? intInstHistId { get; set; }
    public virtual int? intLicHistId { get; set; }
    public virtual int? intLicHistItemId { get; set; }
    public virtual int? iSwProfStatusId { get; set; }
    public virtual int? LicTypeId { get; set; }
    public virtual int? lintComputerNodeId { get; set; }
    public virtual int? lintInstProductId { get; set; }
    public virtual int? lintLicProductId { get; set; }
    public virtual int? lintProductDowngradeFromId { get; set; }
    public virtual int? lintProductPackFromId { get; set; }
    public virtual int? liProductId { get; set; }
    public virtual int? liSwPresenceId { get; set; }
    public virtual int? liSwProfProductId { get; set; }
    public virtual int? ProductStateId { get; set; }

    public vSwInstLicProfile_ProductComputer() { }
}
