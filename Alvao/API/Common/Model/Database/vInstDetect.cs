using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Installed software, detected version and activation code.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vInstDetect.html"/>
[Table("dbo.vInstDetect")]
public class vInstDetect {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vInstDetect.html#Alvao_API_Common_Model_Database_vInstDetect_intDetectId"/>
    public virtual int? intDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vInstDetect.html#Alvao_API_Common_Model_Database_vInstDetect_lintComputerNodeId"/>
    public virtual int lintComputerNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vInstDetect.html#Alvao_API_Common_Model_Database_vInstDetect_lintProductId"/>
    public virtual int? lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vInstDetect.html#Alvao_API_Common_Model_Database_vInstDetect_txtDetCDKey"/>
    public virtual string txtDetCDKey { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vInstDetect.html#Alvao_API_Common_Model_Database_vInstDetect_txtProductVersion"/>
    public virtual string txtProductVersion { get; set; }
}
