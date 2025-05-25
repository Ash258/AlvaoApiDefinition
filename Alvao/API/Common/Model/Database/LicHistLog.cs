using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Change record for a license or a license item.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistLog.html"/>
[Table("dbo.LicHistLog")]
public class LicHistLog {
    /// <summary>The license ID to which the change relates. A foreign key in the LicHist table.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistLog.html#Alvao_API_Common_Model_Database_LicHistLog_LicHistId"/>
    public virtual int? LicHistId { get; set; }
    /// <summary>Change kind ID. The kinds of changes are specified in the LicHistLogKind table.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistLog.html#Alvao_API_Common_Model_Database_LicHistLog_LicHistLogKindId"/>
    public virtual int LicHistLogKindId { get; set; }
    /// <summary>Date and time of the event.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistLog.html#Alvao_API_Common_Model_Database_LicHistLog_LogDate"/>
    public virtual DateTime LogDate { get; set; }
    /// <summary>A message displayed in the license log.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistLog.html#Alvao_API_Common_Model_Database_LicHistLog_Message"/>
    public virtual string Message { get; set; }
    /// <summary>New property value.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistLog.html#Alvao_API_Common_Model_Database_LicHistLog_NewVal"/>
    public virtual string NewVal { get; set; }
    /// <summary>The original property value.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistLog.html#Alvao_API_Common_Model_Database_LicHistLog_OldVal"/>
    public virtual string OldVal { get; set; }
    /// <summary>Change author ID. A foreign key in the tPerson table.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistLog.html#Alvao_API_Common_Model_Database_LicHistLog_PersonId"/>
    public virtual int PersonId { get; set; }
    /// <summary>Name of the changed license property or license item property.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistLog.html#Alvao_API_Common_Model_Database_LicHistLog_PropName"/>
    public virtual string PropName { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistLog.html#Alvao_API_Common_Model_Database_LicHistLog_id"/>
    [Key]
    public virtual int id { get; set; }
}
