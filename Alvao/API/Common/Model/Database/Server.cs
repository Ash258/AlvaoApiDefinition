using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Settings of server applications (Alvao Service, AM Collector).</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html"/>
[Table("dbo.Server")]
public class Server {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_ApprovedCollector"/>
    public virtual bool ApprovedCollector { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_AutoLoadActive"/>
    public virtual bool AutoLoadActive { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_AutoLoadDeleteOnSucc"/>
    public virtual bool AutoLoadDeleteOnSucc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_AutoLoadFolder"/>
    public virtual string AutoLoadFolder { get; set; }
    /// <summary>Connection string of MS Azure storage account. The Alvao Service will automatically load detection data from this storage.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_AutoLoadStorageConString"/>
    public virtual string AutoLoadStorageConString { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_AutoloadDeleteOnFail"/>
    public virtual bool AutoloadDeleteOnFail { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_Default"/>
    public virtual bool Default { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_Desc"/>
    public virtual string Desc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_DetAafterErrorMinutes"/>
    public virtual int DetAafterErrorMinutes { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_DetAfterPcOffMinutes"/>
    public virtual int DetAfterPcOffMinutes { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_DetBlockSleepTimeMinutes"/>
    public virtual int DetBlockSleepTimeMinutes { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_DetCntAtOnce"/>
    public virtual int DetCntAtOnce { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_DetEvalCntAtOnce"/>
    public virtual int DetEvalCntAtOnce { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_DetEvalFilter"/>
    public virtual string DetEvalFilter { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_DetEvalImmediately"/>
    public virtual bool DetEvalImmediately { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_DetFilter"/>
    public virtual string DetFilter { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_DetPingBeforeAgent"/>
    public virtual bool DetPingBeforeAgent { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_DetPingBeforeDirect"/>
    public virtual bool DetPingBeforeDirect { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_Hostname"/>
    public virtual string Hostname { get; set; }
    /// <summary>1 = this record applies to Alvao Service.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_IsAlvaoService"/>
    public virtual bool IsAlvaoService { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_LastConnectDate"/>
    public virtual DateTime? LastConnectDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_NetScanActive"/>
    public virtual bool NetScanActive { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_NetScanAlwaysSaveIP"/>
    public virtual bool NetScanAlwaysSaveIP { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_PswdFilePath"/>
    public virtual string PswdFilePath { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_SchedDetActive"/>
    public virtual bool SchedDetActive { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_SchedDetDayExc"/>
    public virtual int? SchedDetDayExc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_SchedDetTimeFrom"/>
    public virtual double? SchedDetTimeFrom { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_SchedDetTimeTo"/>
    public virtual double? SchedDetTimeTo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_SchedEvalActive"/>
    public virtual bool SchedEvalActive { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_SchedEvalDayExc"/>
    public virtual int? SchedEvalDayExc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_SchedEvalTimeFrom"/>
    public virtual double? SchedEvalTimeFrom { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_SchedEvalTimeTo"/>
    public virtual double? SchedEvalTimeTo { get; set; }
    /// <summary>The collector will automatically update the SW product library from the Internet.  If the option is enabled, it will take precedence over updating from the folder.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_SwLibDownloadLib"/>
    public virtual bool SwLibDownloadLib { get; set; }
    /// <summary>The folder from which the new version of SW products library is uploaded.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_SwLibLoadFromPath"/>
    public virtual string SwLibLoadFromPath { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_SwLibSearchUnknownSW"/>
    public virtual bool SwLibSearchUnknownSW { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_SwLibSendContactEmail"/>
    public virtual string SwLibSendContactEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_SwlibCheckNewLibDays"/>
    public virtual int? SwlibCheckNewLibDays { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_SwlibEvalAllDetAfterDownload"/>
    public virtual bool SwlibEvalAllDetAfterDownload { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_SwlibSendAnon"/>
    public virtual bool SwlibSendAnon { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_Unknown"/>
    public virtual bool Unknown { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Server.html#Alvao_API_Common_Model_Database_Server_id"/>
    [Key]
    public virtual int id { get; set; }
}
