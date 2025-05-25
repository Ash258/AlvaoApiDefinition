using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Software installed on the computers.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst_ProductComputer.html"/>
[Table("dbo.vSwInst_ProductComputer")]
public class vSwInst_ProductComputer {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst_ProductComputer.html#Alvao_API_Common_Model_Database_vSwInst_ProductComputer_ProductStateId"/>
    public virtual int ProductStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst_ProductComputer.html#Alvao_API_Common_Model_Database_vSwInst_ProductComputer_intInstHistId"/>
    public virtual int intInstHistId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst_ProductComputer.html#Alvao_API_Common_Model_Database_vSwInst_ProductComputer_lintComputerNodeId"/>
    public virtual int lintComputerNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst_ProductComputer.html#Alvao_API_Common_Model_Database_vSwInst_ProductComputer_lintProductId"/>
    public virtual int lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst_ProductComputer.html#Alvao_API_Common_Model_Database_vSwInst_ProductComputer_txtDetCDKey"/>
    public virtual string txtDetCDKey { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst_ProductComputer.html#Alvao_API_Common_Model_Database_vSwInst_ProductComputer_txtDetProductVersion"/>
    public virtual string txtDetProductVersion { get; set; }
}
