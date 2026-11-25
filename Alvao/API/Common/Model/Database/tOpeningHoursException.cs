using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Exceptions in service operating hours.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHoursException.html"/>
[Table("dbo.tOpeningHoursException")]
public class tOpeningHoursException {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHoursException.html#Alvao_API_Common_Model_Database_tOpeningHoursException_bOpen"/>
    /// <remarks>Column <c>bOpen</c>: bit, not null.</remarks>
    public virtual bool bOpen { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHoursException.html#Alvao_API_Common_Model_Database_tOpeningHoursException_dFrom"/>
    /// <remarks>Column <c>dFrom</c>: datetime, not null.</remarks>
    public virtual DateTime dFrom { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHoursException.html#Alvao_API_Common_Model_Database_tOpeningHoursException_dTo"/>
    /// <remarks>Column <c>dTo</c>: datetime, not null.</remarks>
    public virtual DateTime dTo { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHoursException.html#Alvao_API_Common_Model_Database_tOpeningHoursException_iOpeningHoursExceptionId"/>
    /// <remarks>Column <c>iOpeningHoursExceptionId</c>: int, not null.</remarks>
    [Key]
    public virtual int iOpeningHoursExceptionId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHoursException.html#Alvao_API_Common_Model_Database_tOpeningHoursException_liOpeningHoursId"/>
    /// <remarks>Column <c>liOpeningHoursId</c>: int, not null. References <see cref="tOpeningHours"/>.</remarks>
    public virtual int liOpeningHoursId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHoursException.html#Alvao_API_Common_Model_Database_tOpeningHoursException_mNotes"/>
    /// <remarks>Column <c>mNotes</c>: nvarchar(max), null.</remarks>
    public virtual string mNotes { get; set; }
}
