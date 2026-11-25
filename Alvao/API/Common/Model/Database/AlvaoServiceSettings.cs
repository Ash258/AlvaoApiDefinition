using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Alvao Service settings.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html"/>
[Table("dbo.AlvaoServiceSettings")]
public class AlvaoServiceSettings {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_AutoLoadActive"/>
    /// <remarks>Column <c>AutoLoadActive</c>: bit, not null.</remarks>
    public virtual bool AutoLoadActive { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_AutoLoadDeleteOnSucc"/>
    /// <remarks>Column <c>AutoLoadDeleteOnSucc</c>: bit, not null.</remarks>
    public virtual bool AutoLoadDeleteOnSucc { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_AutoLoadFolder"/>
    /// <remarks>Column <c>AutoLoadFolder</c>: nvarchar(1024), null.</remarks>
    public virtual string AutoLoadFolder { get; set; }
    /// <summary>
    /// Connection string of MS Azure storage account. The Alvao Service will automatically load detection data from
    /// this storage.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_AutoLoadStorageConString"/>
    /// <remarks>Column <c>AutoLoadStorageConString</c>: nvarchar(1024), null.</remarks>
    public virtual string AutoLoadStorageConString { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_AutoloadDeleteOnFail"/>
    /// <remarks>Column <c>AutoloadDeleteOnFail</c>: bit, not null.</remarks>
    public virtual bool AutoloadDeleteOnFail { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_DetAfterErrorMinutes"/>
    /// <remarks>Column <c>DetAfterErrorMinutes</c>: int, not null.</remarks>
    public virtual int DetAfterErrorMinutes { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_DetAfterPcOffMinutes"/>
    /// <remarks>Column <c>DetAfterPcOffMinutes</c>: int, not null.</remarks>
    public virtual int DetAfterPcOffMinutes { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_SchedEvalActive"/>
    /// <remarks>Column <c>SchedEvalActive</c>: bit, not null.</remarks>
    public virtual bool SchedEvalActive { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_SchedEvalDayExc"/>
    /// <remarks>Column <c>SchedEvalDayExc</c>: int, null.</remarks>
    public virtual int? SchedEvalDayExc { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_SchedEvalTimeFrom"/>
    /// <remarks>Column <c>SchedEvalTimeFrom</c>: float, null.</remarks>
    public virtual double? SchedEvalTimeFrom { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_SchedEvalTimeTo"/>
    /// <remarks>Column <c>SchedEvalTimeTo</c>: float, null.</remarks>
    public virtual double? SchedEvalTimeTo { get; set; }
    /// <summary>
    /// The Alvao Service will automatically update the SW product library from the Internet. If the option is enabled,
    /// it will take precedence over updating from the folder.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_SwLibDownloadLib"/>
    /// <remarks>Column <c>SwLibDownloadLib</c>: bit, not null.</remarks>
    public virtual bool SwLibDownloadLib { get; set; }
    /// <summary>The folder from which the new version of SW products library is uploaded.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_SwLibLoadFromPath"/>
    /// <remarks>Column <c>SwLibLoadFromPath</c>: nvarchar(1024), null.</remarks>
    public virtual string SwLibLoadFromPath { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_SwLibSearchUnknownSW"/>
    /// <remarks>Column <c>SwLibSearchUnknownSW</c>: bit, not null.</remarks>
    public virtual bool SwLibSearchUnknownSW { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_SwLibSendContactEmail"/>
    /// <remarks>Column <c>SwLibSendContactEmail</c>: nvarchar(255), null.</remarks>
    public virtual string SwLibSendContactEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_SwlibCheckNewLibDays"/>
    /// <remarks>Column <c>SwlibCheckNewLibDays</c>: int, null.</remarks>
    public virtual int? SwlibCheckNewLibDays { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_SwlibEvalAllDetAfterDownload"/>
    /// <remarks>Column <c>SwlibEvalAllDetAfterDownload</c>: bit, not null.</remarks>
    public virtual bool SwlibEvalAllDetAfterDownload { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_SwlibSendAnon"/>
    /// <remarks>Column <c>SwlibSendAnon</c>: bit, not null.</remarks>
    public virtual bool SwlibSendAnon { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
