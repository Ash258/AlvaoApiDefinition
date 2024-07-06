using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Settings of server applications (Alvao Service, AM Collector).
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_Server.htm"/>
[TableAttribute("dbo.Server")]
public class Server
{
    public virtual bool ApprovedCollector { get; set; }
    public virtual bool AutoLoadActive { get; set; }
    public virtual bool AutoloadDeleteOnFail { get; set; }
    public virtual bool AutoLoadDeleteOnSucc { get; set; }
    public virtual string AutoLoadFolder { get; set; }
    /// <summary>Connection string of MS Azure storage account. The Alvao Service will automatically load detection data from this storage.</summary>
    public virtual string AutoLoadStorageConString { get; set; }
    public virtual bool Default { get; set; }
    public virtual string Desc { get; set; }
    public virtual int DetAafterErrorMinutes { get; set; }
    public virtual int DetAfterPcOffMinutes { get; set; }
    public virtual int DetBlockSleepTimeMinutes { get; set; }
    public virtual int DetCntAtOnce { get; set; }
    public virtual int DetEvalCntAtOnce { get; set; }
    public virtual string DetEvalFilter { get; set; }
    public virtual bool DetEvalImmediately { get; set; }
    public virtual string DetFilter { get; set; }
    public virtual bool DetPingBeforeAgent { get; set; }
    public virtual bool DetPingBeforeDirect { get; set; }
    public virtual string Hostname { get; set; }
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>1 = this record applies to Alvao Service.</summary>
    public virtual bool IsAlvaoService { get; set; }
    public virtual DateTime? LastConnectDate { get; set; }
    public virtual bool NetScanActive { get; set; }
    public virtual bool NetScanAlwaysSaveIP { get; set; }
    public virtual string PswdFilePath { get; set; }
    public virtual bool SchedDetActive { get; set; }
    public virtual int? SchedDetDayExc { get; set; }
    public virtual double? SchedDetTimeFrom { get; set; }
    public virtual double? SchedDetTimeTo { get; set; }
    public virtual bool SchedEvalActive { get; set; }
    public virtual int? SchedEvalDayExc { get; set; }
    public virtual double? SchedEvalTimeFrom { get; set; }
    public virtual double? SchedEvalTimeTo { get; set; }
    /// <summary>The collector will automatically update the SW product library from the Internet. If the option is enabled, it will take precedence over updating from the folder.</summary>
    public virtual bool SwLibDownloadLib { get; set; }
    public virtual bool SwlibEvalAllDetAfterDownload { get; set; }
    public virtual int? SwlibCheckNewLibDays { get; set; }
    /// <summary>The folder from which the new version of SW products library is uploaded.</summary>
    public virtual string SwLibLoadFromPath { get; set; }
    public virtual bool SwLibSearchUnknownSW { get; set; }
    public virtual bool SwLibSendAddUnknownReq { get; set; }
    public virtual bool SwlibSendAnon { get; set; }
    public virtual string SwLibSendContactEmail { get; set; }
    public virtual bool Unknown { get; set; }

    public Server() { }
}
