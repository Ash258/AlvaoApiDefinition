using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Security for properties.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.KindRight.html"/>
[Table("dbo.KindRight")]
public class KindRight {
    /// <summary>Permission to change value.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.KindRight.html#Alvao_API_Common_Model_Database_KindRight_CanModify"/>
    /// <remarks>Column <c>CanModify</c>: tinyint, null.</remarks>
    public virtual byte? CanModify { get; set; }
    /// <summary>Permission to read.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.KindRight.html#Alvao_API_Common_Model_Database_KindRight_CanRead"/>
    /// <remarks>Column <c>CanRead</c>: tinyint, null.</remarks>
    public virtual byte? CanRead { get; set; }
    /// <summary>Object type ID. The value NULL meals that the permission applies to all object types.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.KindRight.html#Alvao_API_Common_Model_Database_KindRight_ClassId"/>
    /// <remarks>Column <c>ClassId</c>: int, null. References <see cref="tblClass"/>.</remarks>
    public virtual int? ClassId { get; set; }
    /// <summary>Property definition ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.KindRight.html#Alvao_API_Common_Model_Database_KindRight_KindId"/>
    /// <remarks>Column <c>KindId</c>: int, not null. References <see cref="tblKind"/>.</remarks>
    public virtual int KindId { get; set; }
    /// <summary>Group ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.KindRight.html#Alvao_API_Common_Model_Database_KindRight_RoleId"/>
    /// <remarks>Column <c>RoleId</c>: int, not null. References <see cref="tRole"/>.</remarks>
    public virtual int RoleId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.KindRight.html#Alvao_API_Common_Model_Database_KindRight_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
