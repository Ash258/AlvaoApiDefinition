using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Installations covered by &quot;special installation&quot;, including the coverage for package components.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vInstTrial.html"/>
[Table("dbo.vInstTrial")]
public class vInstTrial {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vInstTrial.html#Alvao_API_Common_Model_Database_vInstTrial_lintComputerNodeId"/>
    public virtual int lintComputerNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vInstTrial.html#Alvao_API_Common_Model_Database_vInstTrial_lintProductId"/>
    public virtual int lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vInstTrial.html#Alvao_API_Common_Model_Database_vInstTrial_txtDesc"/>
    public virtual string txtDesc { get; set; }
}
