using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Types of detections (HW, SW).</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetectKind.html"/>
[Table("dbo.vDetectKind")]
public class vDetectKind {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetectKind.html#Alvao_API_Common_Model_Database_vDetectKind_intDetectKindId"/>
    public virtual int intDetectKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vDetectKind.html#Alvao_API_Common_Model_Database_vDetectKind_txtDetectKind"/>
    public virtual string txtDetectKind { get; set; }
}
