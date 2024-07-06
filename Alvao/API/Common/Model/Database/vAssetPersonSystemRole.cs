using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// User membership in system roles of Asset Management.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vAssetPersonSystemRole.htm"/>
[TableAttribute("dbo.vAssetPersonSystemRole")]
public class vAssetPersonSystemRole
{
    public virtual bool? Detect { get; set; }
    public virtual bool? Hw { get; set; }
    public virtual bool? Inventory { get; set; }
    public virtual int PersonId { get; set; }
    public virtual bool? Reader { get; set; }
    public virtual bool? RelationReader { get; set; }
    public virtual bool? RelationWriter { get; set; }
    public virtual bool? SysAdmin { get; set; }

    public vAssetPersonSystemRole() { }
}
