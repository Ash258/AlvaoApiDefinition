using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>The table contains properties that must be filled in for the given object types.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RequiredClassKind.html"/>
[Table("dbo.RequiredClassKind")]
public class RequiredClassKind {
    /// <summary>Object type ID (tblClass.intClassId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RequiredClassKind.html#Alvao_API_Common_Model_Database_RequiredClassKind_ClassId"/>
    [ExplicitKey]
    public virtual int ClassId { get; set; }
    /// <summary>Property definition ID (tblKind.intKindId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.RequiredClassKind.html#Alvao_API_Common_Model_Database_RequiredClassKind_KindId"/>
    public virtual int KindId { get; set; }
}
