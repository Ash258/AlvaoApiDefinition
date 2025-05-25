using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>ID of the types of detection (HW, SW). Texts in tblDict.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectKind.html"/>
[Table("dbo.tblDetectKind")]
public class tblDetectKind {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectKind.html#Alvao_API_Common_Model_Database_tblDetectKind_intDetectKindId"/>
    [ExplicitKey]
    public virtual int intDetectKindId { get; set; }
}
