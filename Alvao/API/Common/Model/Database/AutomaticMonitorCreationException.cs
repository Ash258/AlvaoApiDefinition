using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Object type IDs under which monitors are created in opposite to default placement.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticMonitorCreationException.html"/>
[Table("dbo.AutomaticMonitorCreationException")]
public class AutomaticMonitorCreationException {
    /// <summary>Object class ID (tblClass.intClassId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticMonitorCreationException.html#Alvao_API_Common_Model_Database_AutomaticMonitorCreationException_ClassId"/>
    /// <remarks>Column <c>ClassId</c>: int, not null. References <see cref="tblClass"/>.</remarks>
    public virtual int ClassId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticMonitorCreationException.html#Alvao_API_Common_Model_Database_AutomaticMonitorCreationException_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [Key]
    public virtual int Id { get; set; }
}
