using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Users in the object tree.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetUser.html"/>
[Table("dbo.vAssetUser")]
public class vAssetUser {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetUser.html#Alvao_API_Common_Model_Database_vAssetUser_AdGuid"/>
    public virtual string AdGuid { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetUser.html#Alvao_API_Common_Model_Database_vAssetUser_City"/>
    public virtual string City { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetUser.html#Alvao_API_Common_Model_Database_vAssetUser_Department"/>
    public virtual string Department { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetUser.html#Alvao_API_Common_Model_Database_vAssetUser_Email"/>
    public virtual string Email { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetUser.html#Alvao_API_Common_Model_Database_vAssetUser_IsHidden"/>
    public virtual bool? IsHidden { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetUser.html#Alvao_API_Common_Model_Database_vAssetUser_Login"/>
    public virtual string Login { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetUser.html#Alvao_API_Common_Model_Database_vAssetUser_Mobile"/>
    public virtual string Mobile { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetUser.html#Alvao_API_Common_Model_Database_vAssetUser_Office"/>
    public virtual string Office { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetUser.html#Alvao_API_Common_Model_Database_vAssetUser_PersonalNum"/>
    public virtual string PersonalNum { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetUser.html#Alvao_API_Common_Model_Database_vAssetUser_Phone"/>
    public virtual string Phone { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetUser.html#Alvao_API_Common_Model_Database_vAssetUser_User"/>
    public virtual string User { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetUser.html#Alvao_API_Common_Model_Database_vAssetUser_WorkPosition"/>
    public virtual string WorkPosition { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetUser.html#Alvao_API_Common_Model_Database_vAssetUser_intNodeId"/>
    public virtual int intNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAssetUser.html#Alvao_API_Common_Model_Database_vAssetUser_txtName"/>
    public virtual string txtName { get; set; }
}
