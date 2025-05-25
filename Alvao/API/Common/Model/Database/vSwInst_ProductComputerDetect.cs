using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>SW detected in the computers.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst_ProductComputerDetect.html"/>
[Table("dbo.vSwInst_ProductComputerDetect")]
public class vSwInst_ProductComputerDetect {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst_ProductComputerDetect.html#Alvao_API_Common_Model_Database_vSwInst_ProductComputerDetect_intDetectId"/>
    public virtual int intDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst_ProductComputerDetect.html#Alvao_API_Common_Model_Database_vSwInst_ProductComputerDetect_intInstHistId"/>
    public virtual int intInstHistId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst_ProductComputerDetect.html#Alvao_API_Common_Model_Database_vSwInst_ProductComputerDetect_lintComputerNodeId"/>
    public virtual int lintComputerNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst_ProductComputerDetect.html#Alvao_API_Common_Model_Database_vSwInst_ProductComputerDetect_lintProductId"/>
    public virtual int lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst_ProductComputerDetect.html#Alvao_API_Common_Model_Database_vSwInst_ProductComputerDetect_txtDetCDKey"/>
    public virtual string txtDetCDKey { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst_ProductComputerDetect.html#Alvao_API_Common_Model_Database_vSwInst_ProductComputerDetect_txtDetProductVersion"/>
    public virtual string txtDetProductVersion { get; set; }
}
