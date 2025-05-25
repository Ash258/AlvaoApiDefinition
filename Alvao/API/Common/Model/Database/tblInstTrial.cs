using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Special installation.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstTrial.html"/>
[Table("dbo.tblInstTrial")]
public class tblInstTrial {
    /// <summary>Date of expiration</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstTrial.html#Alvao_API_Common_Model_Database_tblInstTrial_ValidUntil"/>
    public virtual DateTime? ValidUntil { get; set; }
    /// <summary>Computer - tblNode</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstTrial.html#Alvao_API_Common_Model_Database_tblInstTrial_lintComputerNodeId"/>
    public virtual int lintComputerNodeId { get; set; }
    /// <summary>Product - tblProduct</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstTrial.html#Alvao_API_Common_Model_Database_tblInstTrial_lintProductId"/>
    [ExplicitKey]
    public virtual int lintProductId { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblInstTrial.html#Alvao_API_Common_Model_Database_tblInstTrial_txtDesc"/>
    public virtual string txtDesc { get; set; }
}
