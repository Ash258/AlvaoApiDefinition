using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Settings of server applications (Alvao Service, AM Collector).
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_Server.htm"/>
[TableAttribute("dbo.Server")]
public class Server
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_ApprovedCollector.htm"/>
    public virtual bool ApprovedCollector { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_AutoLoadActive.htm"/>
    public virtual bool AutoLoadActive { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_AutoloadDeleteOnFail.htm"/>
    public virtual bool AutoloadDeleteOnFail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_AutoLoadDeleteOnSucc.htm"/>
    public virtual bool AutoLoadDeleteOnSucc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_AutoLoadFolder.htm"/>
    public virtual string AutoLoadFolder { get; set; }
    /// <summary>Connection string of MS Azure storage account. The Alvao Service will automatically load detection data from this storage.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_AutoLoadStorageConString.htm"/>
    public virtual string AutoLoadStorageConString { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_Default.htm"/>
    public virtual bool Default { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_Desc.htm"/>
    public virtual string Desc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_DetAafterErrorMinutes.htm"/>
    public virtual int DetAafterErrorMinutes { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_DetAfterPcOffMinutes.htm"/>
    public virtual int DetAfterPcOffMinutes { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_DetBlockSleepTimeMinutes.htm"/>
    public virtual int DetBlockSleepTimeMinutes { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_DetCntAtOnce.htm"/>
    public virtual int DetCntAtOnce { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_DetEvalCntAtOnce.htm"/>
    public virtual int DetEvalCntAtOnce { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_DetEvalFilter.htm"/>
    public virtual string DetEvalFilter { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_DetEvalImmediately.htm"/>
    public virtual bool DetEvalImmediately { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_DetFilter.htm"/>
    public virtual string DetFilter { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_DetPingBeforeAgent.htm"/>
    public virtual bool DetPingBeforeAgent { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_DetPingBeforeDirect.htm"/>
    public virtual bool DetPingBeforeDirect { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_Hostname.htm"/>
    public virtual string Hostname { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>1 = this record applies to Alvao Service.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_IsAlvaoService.htm"/>
    public virtual bool IsAlvaoService { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_LastConnectDate.htm"/>
    public virtual DateTime? LastConnectDate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_NetScanActive.htm"/>
    public virtual bool NetScanActive { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_NetScanAlwaysSaveIP.htm"/>
    public virtual bool NetScanAlwaysSaveIP { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_PswdFilePath.htm"/>
    public virtual string PswdFilePath { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_SchedDetActive.htm"/>
    public virtual bool SchedDetActive { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_SchedDetDayExc.htm"/>
    public virtual int? SchedDetDayExc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_SchedDetTimeFrom.htm"/>
    public virtual double? SchedDetTimeFrom { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_SchedDetTimeTo.htm"/>
    public virtual double? SchedDetTimeTo { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_SchedEvalActive.htm"/>
    public virtual bool SchedEvalActive { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_SchedEvalDayExc.htm"/>
    public virtual int? SchedEvalDayExc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_SchedEvalTimeFrom.htm"/>
    public virtual double? SchedEvalTimeFrom { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_SchedEvalTimeTo.htm"/>
    public virtual double? SchedEvalTimeTo { get; set; }
    /// <summary>The collector will automatically update the SW product library from the Internet. If the option is enabled, it will take precedence over updating from the folder.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_SwLibDownloadLib.htm"/>
    public virtual bool SwLibDownloadLib { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_SwlibEvalAllDetAfterDownload.htm"/>
    public virtual bool SwlibEvalAllDetAfterDownload { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_SwlibCheckNewLibDays.htm"/>
    public virtual int? SwlibCheckNewLibDays { get; set; }
    /// <summary>The folder from which the new version of SW products library is uploaded.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_SwLibLoadFromPath.htm"/>
    public virtual string SwLibLoadFromPath { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_SwLibSearchUnknownSW.htm"/>
    public virtual bool SwLibSearchUnknownSW { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_SwLibSendAddUnknownReq.htm"/>
    public virtual bool SwLibSendAddUnknownReq { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_SwlibSendAnon.htm"/>
    public virtual bool SwlibSendAnon { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_SwLibSendContactEmail.htm"/>
    public virtual string SwLibSendContactEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Server_Unknown.htm"/>
    public virtual bool Unknown { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_Server__ctor.htm"/>
    public Server() { }
}
