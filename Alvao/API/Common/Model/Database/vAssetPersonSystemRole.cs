using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>User membership in system roles of Asset Management.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vAssetPersonSystemRole.htm"/>
[TableAttribute("dbo.vAssetPersonSystemRole")]
public class vAssetPersonSystemRole
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAssetPersonSystemRole_Detect.htm"/>
    public virtual bool? Detect { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAssetPersonSystemRole_Hw.htm"/>
    public virtual bool? Hw { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAssetPersonSystemRole_Inventory.htm"/>
    public virtual bool? Inventory { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAssetPersonSystemRole_PersonId.htm"/>
    public virtual int PersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAssetPersonSystemRole_Reader.htm"/>
    public virtual bool? Reader { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAssetPersonSystemRole_RelationReader.htm"/>
    public virtual bool? RelationReader { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAssetPersonSystemRole_RelationWriter.htm"/>
    public virtual bool? RelationWriter { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAssetPersonSystemRole_SysAdmin.htm"/>
    public virtual bool? SysAdmin { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vAssetPersonSystemRole__ctor.htm"/>
    public vAssetPersonSystemRole() { }
}
