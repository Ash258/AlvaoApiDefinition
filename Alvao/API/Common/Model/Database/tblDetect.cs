using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Information on HW and SW detections in the computers.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblDetect.htm"/>
[TableAttribute("dbo.tblDetect")]
public class tblDetect
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetect_DetectSourceMethod.htm"/>
    public virtual int? DetectSourceMethod { get; set; }
    /// <summary>Time at which the detection is performed.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetect_dteCreated.htm"/>
    public virtual DateTime? dteCreated { get; set; }
    /// <summary>Time at which the detection is loaded to the database</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetect_dteImported.htm"/>
    public virtual DateTime? dteImported { get; set; }
    /// <summary>Time at which the ticket (manual or automatic) was created The ticket will be created once the detection is loaded from the file to the AM Console. The time of the detection is written to dteRqCreated. The "Detect Again" command writes the current time.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetect_dteRqCreated.htm"/>
    public virtual DateTime? dteRqCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetect_dUpdated.htm"/>
    public virtual DateTime? dUpdated { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetect_intDetectId.htm"/>
    [KeyAttribute]
    public virtual int intDetectId { get; set; }
    /// <summary>Computer designated for detection (tblNode).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetect_lintComputerNodeId.htm"/>
    public virtual int lintComputerNodeId { get; set; }
    /// <summary>1=hw, 2=sw (see tblDetectKind, tblDict)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetect_lintDetectKindId.htm"/>
    public virtual int lintDetectKindId { get; set; }
    /// <summary>1 = "no response so far"2 = "ok" - carried out without warnings and errors.3 = "warning" - Warnings were encountered during the detection process, but no errors.4 = "error" - At least one error was encountered during the detection.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetect_lintDetectStatusId.htm"/>
    public virtual int lintDetectStatusId { get; set; }
    /// <summary>The user that created this ticket, see tPerson.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetect_liRqCreatedPersonId.htm"/>
    public virtual int liRqCreatedPersonId { get; set; }
    /// <summary>If the value is 1, the ticket was created manually with the activated Detect and evaluate immediately option.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetect_ManualRq.htm"/>
    public virtual bool ManualRq { get; set; }
    /// <summary>Name of server on which the AM Collector that reserved the ticket resolution is running.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetect_txtCollector.htm"/>
    public virtual string txtCollector { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetect_txtDescription.htm"/>
    public virtual string txtDescription { get; set; }
    /// <summary>Name of ticket sub-folder for detection via shared folder.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetect_txtShareRq.htm"/>
    public virtual string txtShareRq { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblDetect__ctor.htm"/>
    public tblDetect() { }
}
