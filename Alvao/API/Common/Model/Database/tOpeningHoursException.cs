using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Exceptions in service operating hours.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHoursException.html"/>
[Table("dbo.tOpeningHoursException")]
public class tOpeningHoursException {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHoursException.html#Alvao_API_Common_Model_Database_tOpeningHoursException_bOpen"/>
    public virtual bool bOpen { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHoursException.html#Alvao_API_Common_Model_Database_tOpeningHoursException_dFrom"/>
    public virtual DateTime dFrom { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHoursException.html#Alvao_API_Common_Model_Database_tOpeningHoursException_dTo"/>
    public virtual DateTime dTo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHoursException.html#Alvao_API_Common_Model_Database_tOpeningHoursException_iOpeningHoursExceptionId"/>
    [Key]
    public virtual int iOpeningHoursExceptionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHoursException.html#Alvao_API_Common_Model_Database_tOpeningHoursException_liOpeningHoursId"/>
    public virtual int liOpeningHoursId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tOpeningHoursException.html#Alvao_API_Common_Model_Database_tOpeningHoursException_mNotes"/>
    public virtual string mNotes { get; set; }
}
