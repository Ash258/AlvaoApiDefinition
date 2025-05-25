using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Security for properties.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.KindRight.html"/>
[Table("dbo.KindRight")]
public class KindRight {
    /// <summary>Permission to change value.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.KindRight.html#Alvao_API_Common_Model_Database_KindRight_CanModify"/>
    public virtual byte? CanModify { get; set; }
    /// <summary>Permission to read.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.KindRight.html#Alvao_API_Common_Model_Database_KindRight_CanRead"/>
    public virtual byte? CanRead { get; set; }
    /// <summary>Object type ID. The value NULL meals that the permission applies to all object types.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.KindRight.html#Alvao_API_Common_Model_Database_KindRight_ClassId"/>
    public virtual int? ClassId { get; set; }
    /// <summary>Property definition ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.KindRight.html#Alvao_API_Common_Model_Database_KindRight_KindId"/>
    public virtual int KindId { get; set; }
    /// <summary>Group ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.KindRight.html#Alvao_API_Common_Model_Database_KindRight_RoleId"/>
    public virtual int RoleId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.KindRight.html#Alvao_API_Common_Model_Database_KindRight_id"/>
    [Key]
    public virtual int id { get; set; }
}
