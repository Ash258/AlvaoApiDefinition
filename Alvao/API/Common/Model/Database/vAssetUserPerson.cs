using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// The user's link in the object tree to the user in the Administration service (tPerson.
/// Link based on priority:
/// 
/// AD GUID
/// Personal number
/// Login name
/// E-mail
/// </summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetUserPerson.html"/>
[Table("dbo.vAssetUserPerson")]
public class vAssetUserPerson {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetUserPerson.html#Alvao_API_Common_Model_Database_vAssetUserPerson_NodeId"/>
    public virtual int NodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetUserPerson.html#Alvao_API_Common_Model_Database_vAssetUserPerson_PersonId"/>
    public virtual int PersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetUserPerson.html#Alvao_API_Common_Model_Database_vAssetUserPerson_PersonManagerId"/>
    public virtual int? PersonManagerId { get; set; }
}
