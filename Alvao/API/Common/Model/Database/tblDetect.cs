using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Information on HW and SW detections in the computers.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html"/>
[Table("dbo.tblDetect")]
public class tblDetect {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_DetectSourceMethod"/>
    /// <remarks>Column <c>DetectSourceMethod</c>: int, null. References <see cref="DetectMethod"/>.</remarks>
    public virtual int? DetectSourceMethod { get; set; }
    /// <summary>
    /// If the value is 1, the request was created manually with the activated Detect and evaluate immediately option.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_ManualRq"/>
    /// <remarks>Column <c>ManualRq</c>: bit, not null.</remarks>
    public virtual bool ManualRq { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_dUpdated"/>
    /// <remarks>Column <c>dUpdated</c>: datetime, null.</remarks>
    public virtual DateTime? dUpdated { get; set; }
    /// <summary>Time at which the detection is performed.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_dteCreated"/>
    /// <remarks>Column <c>dteCreated</c>: datetime, null.</remarks>
    public virtual DateTime? dteCreated { get; set; }
    /// <summary>Time at which the detection is loaded to the database</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_dteImported"/>
    /// <remarks>Column <c>dteImported</c>: datetime, null.</remarks>
    public virtual DateTime? dteImported { get; set; }
    /// <summary>
    /// Time at which the request (manual or automatic) was created. The request will be created once the detection is
    /// loaded from the file to the Asset Management. The time of the detection is written to dteRqCreated.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_dteRqCreated"/>
    /// <remarks>Column <c>dteRqCreated</c>: datetime, null.</remarks>
    public virtual DateTime? dteRqCreated { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_intDetectId"/>
    /// <remarks>Column <c>intDetectId</c>: int, not null.</remarks>
    [Key]
    public virtual int intDetectId { get; set; }
    /// <summary>The user that created this request, see tPerson.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_liRqCreatedPersonId"/>
    /// <remarks>Column <c>liRqCreatedPersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int liRqCreatedPersonId { get; set; }
    /// <summary>Computer designated for detection (tblNode).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_lintComputerNodeId"/>
    /// <remarks>Column <c>lintComputerNodeId</c>: int, not null. References <see cref="tblNode"/>.</remarks>
    public virtual int lintComputerNodeId { get; set; }
    /// <summary>1=hw, 2=sw (see tblDetectKind, tblDict)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_lintDetectKindId"/>
    /// <remarks>Column <c>lintDetectKindId</c>: int, not null. References <see cref="tblDetectKind"/>.</remarks>
    public virtual int lintDetectKindId { get; set; }
    /// <summary>
    /// 1 = &quot;no response so far&quot; 2 = &quot;ok&quot; - carried out without warnings and errors. 3 =
    /// &quot;warning&quot; - Warnings were encountered during the detection process, but no errors. 4 =
    /// &quot;error&quot; - At least one error was encountered during the detection.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_lintDetectStatusId"/>
    /// <remarks>Column <c>lintDetectStatusId</c>: int, not null. References <see cref="tblDetectStatus"/>.</remarks>
    public virtual int lintDetectStatusId { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetect.html#Alvao_API_Common_Model_Database_tblDetect_txtDescription"/>
    /// <remarks>Column <c>txtDescription</c>: nvarchar(255), null.</remarks>
    public virtual string txtDescription { get; set; }
}
