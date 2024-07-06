using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Computers.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vComputer.htm"/>
[TableAttribute("dbo.vComputer")]
public class vComputer
{
    public virtual bool bolAutoUpdate { get; set; }
    public virtual bool? bolComputerStateOn { get; set; }
    public virtual bool bolIgnoreDifferences { get; set; }
    public virtual bool bSwAllAllowed { get; set; }
    public virtual int intNodeId { get; set; }
    public virtual int? intState { get; set; }
    public virtual bool? IsActive { get; set; }
    public virtual bool IsDiscarded { get; set; }
    public virtual bool? IsHidden { get; set; }
    public virtual int? lintClassId { get; set; }
    public virtual int? lintIconId { get; set; }
    public virtual int? lintParentId { get; set; }
    public virtual int? liSwProfileId { get; set; }
    public virtual string txtComputerName { get; set; }
    public virtual string txtDomain { get; set; }
    public virtual string txtFullComputerName { get; set; }
    public virtual string txtIPAddress { get; set; }
    public virtual string txtLDAPGUID { get; set; }
    public virtual string txtName { get; set; }
    public virtual string txtPath { get; set; }

    public vComputer() { }
}
