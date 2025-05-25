using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>ID of the detections statuses. Texts in tblDict.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectStatus.html"/>
[Table("dbo.tblDetectStatus")]
public class tblDetectStatus {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectStatus.html#Alvao_API_Common_Model_Database_tblDetectStatus_intDetectStatusId"/>
    [ExplicitKey]
    public virtual int intDetectStatusId { get; set; }
}
