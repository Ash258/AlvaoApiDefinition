using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Change record for a license or a license item.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistLog.html"/>
[Table("dbo.LicHistLog")]
public class LicHistLog {
    /// <summary>1=when the tblLicHistItem entry was assigned to an external object.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistLog.html#Alvao_API_Common_Model_Database_LicHistLog_IsExternalObject"/>
    /// <remarks>Column <c>IsExternalObject</c>: bit, not null.</remarks>
    public virtual bool IsExternalObject { get; set; }
    /// <summary>The license ID to which the change relates. A foreign key in the LicHist table.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistLog.html#Alvao_API_Common_Model_Database_LicHistLog_LicHistId"/>
    /// <remarks>Column <c>LicHistId</c>: int, null. References <see cref="tblLicHist"/>.</remarks>
    public virtual int? LicHistId { get; set; }
    /// <summary>Change kind ID. The kinds of changes are specified in the LicHistLogKind table.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistLog.html#Alvao_API_Common_Model_Database_LicHistLog_LicHistLogKindId"/>
    /// <remarks>Column <c>LicHistLogKindId</c>: int, not null. References <see cref="LicHistLogKind"/>.</remarks>
    public virtual int LicHistLogKindId { get; set; }
    /// <summary>Date and time of the event.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistLog.html#Alvao_API_Common_Model_Database_LicHistLog_LogDate"/>
    /// <remarks>Column <c>LogDate</c>: datetime, not null.</remarks>
    public virtual DateTime LogDate { get; set; }
    /// <summary>A message displayed in the license log.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistLog.html#Alvao_API_Common_Model_Database_LicHistLog_Message"/>
    /// <remarks>Column <c>Message</c>: nvarchar(max), null.</remarks>
    public virtual string Message { get; set; }
    /// <summary>New property value.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistLog.html#Alvao_API_Common_Model_Database_LicHistLog_NewVal"/>
    /// <remarks>Column <c>NewVal</c>: nvarchar(255), null.</remarks>
    public virtual string NewVal { get; set; }
    /// <summary>The original property value.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistLog.html#Alvao_API_Common_Model_Database_LicHistLog_OldVal"/>
    /// <remarks>Column <c>OldVal</c>: nvarchar(255), null.</remarks>
    public virtual string OldVal { get; set; }
    /// <summary>Change author ID. A foreign key in the tPerson table.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistLog.html#Alvao_API_Common_Model_Database_LicHistLog_PersonId"/>
    /// <remarks>Column <c>PersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int PersonId { get; set; }
    /// <summary>Name of the changed license property or license item property.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistLog.html#Alvao_API_Common_Model_Database_LicHistLog_PropName"/>
    /// <remarks>Column <c>PropName</c>: nvarchar(100), null.</remarks>
    public virtual string PropName { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicHistLog.html#Alvao_API_Common_Model_Database_LicHistLog_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
