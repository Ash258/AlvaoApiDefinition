using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Assigning/removing/moving license to/from/between computers.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistItemAssign.html"/>
[Table("dbo.LicHistItemAssign")]
public class LicHistItemAssign {
    /// <summary>Date assigned/removed</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistItemAssign.html#Alvao_API_Common_Model_Database_LicHistItemAssign_AssignedDate"/>
    /// <remarks>Column <c>AssignedDate</c>: datetime, not null.</remarks>
    public virtual DateTime AssignedDate { get; set; }
    /// <summary>Assigning/Removing author</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistItemAssign.html#Alvao_API_Common_Model_Database_LicHistItemAssign_AssignedPersonId"/>
    /// <remarks>Column <c>AssignedPersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int AssignedPersonId { get; set; }
    /// <summary>Target object</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistItemAssign.html#Alvao_API_Common_Model_Database_LicHistItemAssign_DestNodeId"/>
    /// <remarks>Column <c>DestNodeId</c>: int, null. References <see cref="tblNode"/>.</remarks>
    public virtual int? DestNodeId { get; set; }
    /// <summary>Information on the assigned/removed license item.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistItemAssign.html#Alvao_API_Common_Model_Database_LicHistItemAssign_ItemInfo"/>
    /// <remarks>Column <c>ItemInfo</c>: nvarchar(1000), null.</remarks>
    public virtual string ItemInfo { get; set; }
    /// <summary>License</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistItemAssign.html#Alvao_API_Common_Model_Database_LicHistItemAssign_LicHistId"/>
    /// <remarks>Column <c>LicHistId</c>: int, not null. References <see cref="tblLicHist"/>.</remarks>
    public virtual int LicHistId { get; set; }
    /// <summary>License item</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistItemAssign.html#Alvao_API_Common_Model_Database_LicHistItemAssign_LicHistItemId"/>
    /// <remarks>Column <c>LicHistItemId</c>: int, null. References <see cref="tblLicHistItem"/>.</remarks>
    public virtual int? LicHistItemId { get; set; }
    /// <summary>Information on the assigned/removed license.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistItemAssign.html#Alvao_API_Common_Model_Database_LicHistItemAssign_LicInfo"/>
    /// <remarks>Column <c>LicInfo</c>: nvarchar(1000), null.</remarks>
    public virtual string LicInfo { get; set; }
    /// <summary>Source object</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistItemAssign.html#Alvao_API_Common_Model_Database_LicHistItemAssign_SrcNodeId"/>
    /// <remarks>Column <c>SrcNodeId</c>: int, null. References <see cref="tblNode"/>.</remarks>
    public virtual int? SrcNodeId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistItemAssign.html#Alvao_API_Common_Model_Database_LicHistItemAssign_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
