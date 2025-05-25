using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Assigning/removing/moving license to/from/between computers.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistItemAssign.html"/>
[Table("dbo.LicHistItemAssign")]
public class LicHistItemAssign {
    /// <summary>Date assigned/removed</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistItemAssign.html#Alvao_API_Common_Model_Database_LicHistItemAssign_AssignedDate"/>
    public virtual DateTime AssignedDate { get; set; }
    /// <summary>Assigning/Removing author</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistItemAssign.html#Alvao_API_Common_Model_Database_LicHistItemAssign_AssignedPersonId"/>
    public virtual int AssignedPersonId { get; set; }
    /// <summary>Target object</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistItemAssign.html#Alvao_API_Common_Model_Database_LicHistItemAssign_DestNodeId"/>
    public virtual int? DestNodeId { get; set; }
    /// <summary>Information on the assigned/removed license item.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistItemAssign.html#Alvao_API_Common_Model_Database_LicHistItemAssign_ItemInfo"/>
    public virtual string ItemInfo { get; set; }
    /// <summary>License</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistItemAssign.html#Alvao_API_Common_Model_Database_LicHistItemAssign_LicHistId"/>
    public virtual int LicHistId { get; set; }
    /// <summary>License item</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistItemAssign.html#Alvao_API_Common_Model_Database_LicHistItemAssign_LicHistItemId"/>
    public virtual int? LicHistItemId { get; set; }
    /// <summary>Information on the assigned/removed license.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistItemAssign.html#Alvao_API_Common_Model_Database_LicHistItemAssign_LicInfo"/>
    public virtual string LicInfo { get; set; }
    /// <summary>Source object</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistItemAssign.html#Alvao_API_Common_Model_Database_LicHistItemAssign_SrcNodeId"/>
    public virtual int? SrcNodeId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistItemAssign.html#Alvao_API_Common_Model_Database_LicHistItemAssign_id"/>
    [Key]
    public virtual int id { get; set; }
}
