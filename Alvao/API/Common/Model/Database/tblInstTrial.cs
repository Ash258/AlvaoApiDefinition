using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Special installation.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstTrial.html"/>
[Table("dbo.tblInstTrial")]
public class tblInstTrial {
    /// <summary>Date of expiration</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstTrial.html#Alvao_API_Common_Model_Database_tblInstTrial_ValidUntil"/>
    /// <remarks>Column <c>ValidUntil</c>: datetime, null.</remarks>
    public virtual DateTime? ValidUntil { get; set; }
    /// <summary>Computer - tblNode</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstTrial.html#Alvao_API_Common_Model_Database_tblInstTrial_lintComputerNodeId"/>
    /// <remarks>Column <c>lintComputerNodeId</c>: int, not null. References <see cref="tblNode"/>.</remarks>
    public virtual int lintComputerNodeId { get; set; }
    /// <summary>Product - tblProduct</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstTrial.html#Alvao_API_Common_Model_Database_tblInstTrial_lintProductId"/>
    /// <remarks>Column <c>lintProductId</c>: int, not null. References <see cref="tblProduct"/>.</remarks>
    [ExplicitKey]
    public virtual int lintProductId { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblInstTrial.html#Alvao_API_Common_Model_Database_tblInstTrial_txtDesc"/>
    /// <remarks>Column <c>txtDesc</c>: nvarchar(255), null.</remarks>
    public virtual string txtDesc { get; set; }
}
