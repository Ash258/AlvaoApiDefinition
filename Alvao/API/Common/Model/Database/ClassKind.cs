using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Definition of properties for object class</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ClassKind.html"/>
[Table("dbo.ClassKind")]
public class ClassKind {
    /// <summary>ID of object class (tblClass.intClassId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ClassKind.html#Alvao_API_Common_Model_Database_ClassKind_ClassId"/>
    /// <remarks>Column <c>ClassId</c>: int, not null. References <see cref="tblClass"/>.</remarks>
    [ExplicitKey]
    public virtual int ClassId { get; set; }
    /// <summary>ID of object property (tblKind.intKindId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ClassKind.html#Alvao_API_Common_Model_Database_ClassKind_KindId"/>
    /// <remarks>Column <c>KindId</c>: int, not null. References <see cref="tblKind"/>.</remarks>
    [ExplicitKey]
    public virtual int KindId { get; set; }
}
