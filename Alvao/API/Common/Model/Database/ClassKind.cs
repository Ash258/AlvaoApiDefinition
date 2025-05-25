using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Definition of properties for object class</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ClassKind.html"/>
[Table("dbo.ClassKind")]
public class ClassKind {
    /// <summary>ID of object class (tblClass.intClassId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ClassKind.html#Alvao_API_Common_Model_Database_ClassKind_ClassId"/>
    [ExplicitKey]
    public virtual int ClassId { get; set; }
    /// <summary>ID of object property (tblKind.intKindId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ClassKind.html#Alvao_API_Common_Model_Database_ClassKind_KindId"/>
    public virtual int KindId { get; set; }
}
