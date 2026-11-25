using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Alvao Service settings.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html"/>
[Table("dbo.AlvaoServiceSettings")]
public class AlvaoServiceSettings {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_AutoLoadActive"/>
    public virtual bool AutoLoadActive { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_AutoLoadDeleteOnSucc"/>
    public virtual bool AutoLoadDeleteOnSucc { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_AutoLoadFolder"/>
    public virtual string AutoLoadFolder { get; set; }
    /// <summary>
    /// Connection string of MS Azure storage account. The Alvao Service will automatically load detection data from
    /// this storage.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_AutoLoadStorageConString"/>
    public virtual string AutoLoadStorageConString { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_AutoloadDeleteOnFail"/>
    public virtual bool AutoloadDeleteOnFail { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_DetAfterErrorMinutes"/>
    public virtual int DetAfterErrorMinutes { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_DetAfterPcOffMinutes"/>
    public virtual int DetAfterPcOffMinutes { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_SchedEvalActive"/>
    public virtual bool SchedEvalActive { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_SchedEvalDayExc"/>
    public virtual int? SchedEvalDayExc { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_SchedEvalTimeFrom"/>
    public virtual double? SchedEvalTimeFrom { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_SchedEvalTimeTo"/>
    public virtual double? SchedEvalTimeTo { get; set; }
    /// <summary>
    /// The Alvao Service will automatically update the SW product library from the Internet. If the option is enabled,
    /// it will take precedence over updating from the folder.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_SwLibDownloadLib"/>
    public virtual bool SwLibDownloadLib { get; set; }
    /// <summary>The folder from which the new version of SW products library is uploaded.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_SwLibLoadFromPath"/>
    public virtual string SwLibLoadFromPath { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_SwLibSearchUnknownSW"/>
    public virtual bool SwLibSearchUnknownSW { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_SwLibSendContactEmail"/>
    public virtual string SwLibSendContactEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_SwlibCheckNewLibDays"/>
    public virtual int? SwlibCheckNewLibDays { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_SwlibEvalAllDetAfterDownload"/>
    public virtual bool SwlibEvalAllDetAfterDownload { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_SwlibSendAnon"/>
    public virtual bool SwlibSendAnon { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoServiceSettings.html#Alvao_API_Common_Model_Database_AlvaoServiceSettings_id"/>
    [Key]
    public virtual int id { get; set; }
}
