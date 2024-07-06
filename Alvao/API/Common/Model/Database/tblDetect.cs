using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Information on HW and SW detections in the computers.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblDetect.htm"/>
[TableAttribute("dbo.tblDetect")]
public class tblDetect
{
    public virtual int? DetectSourceMethod { get; set; }
    /// <summary>Time at which the detection is performed.</summary>
    public virtual DateTime? dteCreated { get; set; }
    /// <summary>Time at which the detection is loaded to the database</summary>
    public virtual DateTime? dteImported { get; set; }
    /// <summary>Time at which the ticket (manual or automatic) was created The ticket will be created once the detection is loaded from the file to the AM Console. The time of the detection is written to dteRqCreated. The "Detect Again" command writes the current time.</summary>
    public virtual DateTime? dteRqCreated { get; set; }
    public virtual DateTime? dUpdated { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int intDetectId { get; set; }
    /// <summary>Computer designated for detection (tblNode).</summary>
    public virtual int lintComputerNodeId { get; set; }
    /// <summary>1=hw, 2=sw (see tblDetectKind, tblDict)</summary>
    public virtual int lintDetectKindId { get; set; }
    /// <summary>1 = "no response so far"2 = "ok" - carried out without warnings and errors.3 = "warning" - Warnings were encountered during the detection process, but no errors.4 = "error" - At least one error was encountered during the detection.</summary>
    public virtual int lintDetectStatusId { get; set; }
    /// <summary>The user that created this ticket, see tPerson.</summary>
    public virtual int liRqCreatedPersonId { get; set; }
    /// <summary>If the value is 1, the ticket was created manually with the activated Detect and evaluate immediately option.</summary>
    public virtual bool ManualRq { get; set; }
    /// <summary>Name of server on which the AM Collector that reserved the ticket resolution is running.</summary>
    public virtual string txtCollector { get; set; }
    /// <summary>Note</summary>
    public virtual string txtDescription { get; set; }
    /// <summary>Name of ticket sub-folder for detection via shared folder.</summary>
    public virtual string txtShareRq { get; set; }

    public tblDetect() { }
}
