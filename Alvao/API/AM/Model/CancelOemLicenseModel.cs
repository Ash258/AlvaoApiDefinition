using Alvao.API.Common.Model.Database;
using Dapper.Contrib.Extensions;

namespace Alvao.API.AM.Model;

public class CancelOemLicenseModel : tblLicHist
{
    public virtual bool AutoAssign { get; set; }
    public virtual string AutoAssignFilter { get; set; }
    public virtual bool AutoAssignNow { get; set; }
    public virtual bool CoverPackPartsWithoutPackageInstalled { get; set; }
    public virtual DateTime? CreatedDate { get; set; }
    public virtual int? CreatedPersonId { get; set; }
    public virtual DateTime dteDate { get; set; }
    public virtual DateTime? dteDateExpire { get; set; }
    public virtual DateTime? dteUpgradeTo { get; set; }
    [KeyAttribute]
    public virtual int intLicHistId { get; set; }
    public int IntLicHistItemId { get; set; }
    public virtual int? InvalidatedByPersonId { get; set; }
    public virtual DateTime? InvalidatedDate { get; set; }
    [ComputedAttribute]
    public virtual bool IsValid { get; set; }
    public virtual int? LicenseCount { get; set; }
    public virtual int LicKindId { get; set; }
    public virtual int? LicTypeId { get; set; }
    public virtual int lintProductId { get; set; }
    public virtual bool MultiAssign { get; set; }
    public virtual bool NoProductInstallation { get; set; }
    public string Organization { get; set; }
    public virtual int? OrganizationNodeId { get; set; }
    public string Product { get; set; }
    public virtual string ProductNotes { get; set; }
    public virtual string txtActivationKey { get; set; }
    public virtual string txtDepartment { get; set; }
    public virtual string txtInventoryNum { get; set; }
    public virtual string txtLicName { get; set; }
    public virtual string txtMemo { get; set; }
    public virtual string UId { get; set; }
}
