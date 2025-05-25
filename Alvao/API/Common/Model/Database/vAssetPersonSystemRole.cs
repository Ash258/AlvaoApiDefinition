using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>User membership in system roles of Asset Management.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetPersonSystemRole.html"/>
[Table("dbo.vAssetPersonSystemRole")]
public class vAssetPersonSystemRole {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetPersonSystemRole.html#Alvao_API_Common_Model_Database_vAssetPersonSystemRole_Detect"/>
    public virtual bool? Detect { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetPersonSystemRole.html#Alvao_API_Common_Model_Database_vAssetPersonSystemRole_Hw"/>
    public virtual bool? Hw { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetPersonSystemRole.html#Alvao_API_Common_Model_Database_vAssetPersonSystemRole_Inventory"/>
    public virtual bool? Inventory { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetPersonSystemRole.html#Alvao_API_Common_Model_Database_vAssetPersonSystemRole_PersonId"/>
    public virtual int PersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetPersonSystemRole.html#Alvao_API_Common_Model_Database_vAssetPersonSystemRole_Reader"/>
    public virtual bool? Reader { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetPersonSystemRole.html#Alvao_API_Common_Model_Database_vAssetPersonSystemRole_RelationReader"/>
    public virtual bool? RelationReader { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetPersonSystemRole.html#Alvao_API_Common_Model_Database_vAssetPersonSystemRole_RelationWriter"/>
    public virtual bool? RelationWriter { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetPersonSystemRole.html#Alvao_API_Common_Model_Database_vAssetPersonSystemRole_SysAdmin"/>
    public virtual bool? SysAdmin { get; set; }
}
