using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Last detection of the computers.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputerDetectLast.html"/>
[Table("dbo.vComputerDetectLast")]
public class vComputerDetectLast {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputerDetectLast.html#Alvao_API_Common_Model_Database_vComputerDetectLast_lintComputerNodeId"/>
    public virtual int lintComputerNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputerDetectLast.html#Alvao_API_Common_Model_Database_vComputerDetectLast_lintDetectId"/>
    public virtual int? lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vComputerDetectLast.html#Alvao_API_Common_Model_Database_vComputerDetectLast_lintDetectKindId"/>
    public virtual int lintDetectKindId { get; set; }
}
