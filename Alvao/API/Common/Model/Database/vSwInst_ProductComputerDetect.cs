using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>SW detected in the computers.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSwInst_ProductComputerDetect.htm"/>
[TableAttribute("dbo.vSwInst_ProductComputerDetect")]
public class vSwInst_ProductComputerDetect
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_ProductComputerDetect_intDetectId.htm"/>
    public virtual int intDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_ProductComputerDetect_intInstHistId.htm"/>
    public virtual int intInstHistId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_ProductComputerDetect_lintComputerNodeId.htm"/>
    public virtual int lintComputerNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_ProductComputerDetect_lintProductId.htm"/>
    public virtual int lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_ProductComputerDetect_txtDetCDKey.htm"/>
    public virtual string txtDetCDKey { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_ProductComputerDetect_txtDetProductVersion.htm"/>
    public virtual string txtDetProductVersion { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vSwInst_ProductComputerDetect__ctor.htm"/>
    public vSwInst_ProductComputerDetect() { }
}
