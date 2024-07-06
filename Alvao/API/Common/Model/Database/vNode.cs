using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Objects in the Objects Tree. Differentiation between system objects and discarded assets.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vNodeClass.htm"/>
[TableAttribute("dbo.vNodeClass")]
public class vNodeClass
{
    public virtual bool bComputer { get; set; }
    public virtual bool bolAutoUpdate { get; set; }
    public virtual bool? bolComputerStateOn { get; set; }
    public virtual bool bolIgnoreDifferences { get; set; }
    public virtual bool bSwAllAllowed { get; set; }
    public virtual int intNodeId { get; set; }
    public virtual int? intState { get; set; }
    public virtual bool? IsActive { get; set; }
    public virtual bool IsDiscarded { get; set; }
    public virtual bool? IsHidden { get; set; }
    public virtual DateTime? LastAgentWSContact { get; set; }
    public virtual int? lintClassId { get; set; }
    public virtual int? lintIconId { get; set; }
    public virtual int? lintParentId { get; set; }
    public virtual int? liSwProfileId { get; set; }
    public virtual bool RequiredPropertyAlert { get; set; }
    public virtual string txtClass { get; set; }
    public virtual string txtLDAPGUID { get; set; }
    public virtual string txtName { get; set; }
    public virtual string txtPath { get; set; }

    public vNodeClass() { }
}
