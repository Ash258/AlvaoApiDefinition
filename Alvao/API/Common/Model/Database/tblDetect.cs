using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Information on HW and SW detections in the computers.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html"/>
[Table("dbo.tblDetect")]
public class tblDetect {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_DetectSourceMethod"/>
    public virtual int? DetectSourceMethod { get; set; }
    /// <summary>If the value is 1, the request was created manually with the activated Detect and evaluate immediately option.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_ManualRq"/>
    public virtual bool ManualRq { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_dUpdated"/>
    public virtual DateTime? dUpdated { get; set; }
    /// <summary>Time at which the detection is performed.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_dteCreated"/>
    public virtual DateTime? dteCreated { get; set; }
    /// <summary>Time at which the detection is loaded to the database</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_dteImported"/>
    public virtual DateTime? dteImported { get; set; }
    /// <summary>Time at which the request (manual or automatic) was created. The request will be created once the detection is loaded from the file to the Asset Management. The time of the detection is written to dteRqCreated.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_dteRqCreated"/>
    public virtual DateTime? dteRqCreated { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_intDetectId"/>
    [Key]
    public virtual int intDetectId { get; set; }
    /// <summary>The user that created this request, see tPerson.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_liRqCreatedPersonId"/>
    public virtual int liRqCreatedPersonId { get; set; }
    /// <summary>Computer designated for detection (tblNode).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_lintComputerNodeId"/>
    public virtual int lintComputerNodeId { get; set; }
    /// <summary>1=hw, 2=sw (see tblDetectKind, tblDict)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_lintDetectKindId"/>
    public virtual int lintDetectKindId { get; set; }
    /// <summary>1 = &quot;no response so far&quot; 2 = &quot;ok&quot; - carried out without warnings and errors. 3 = &quot;warning&quot; - Warnings were encountered during the detection process, but no errors. 4 = &quot;error&quot; - At least one error was encountered during the detection.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_lintDetectStatusId"/>
    public virtual int lintDetectStatusId { get; set; }
    /// <summary>Name of server on which the AM Collector that reserved the request resolution is running.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_txtCollector"/>
    public virtual string txtCollector { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_txtDescription"/>
    public virtual string txtDescription { get; set; }
    /// <summary>Name of request sub-folder for detection via shared folder.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_txtShareRq"/>
    public virtual string txtShareRq { get; set; }
}
