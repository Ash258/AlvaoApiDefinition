using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Software installed on the computers.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSwInst_ProductComputer.htm"/>
[TableAttribute("dbo.vSwInst_ProductComputer")]
public class vSwInst_ProductComputer {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_ProductComputer_intInstHistId.htm"/>
    public virtual int intInstHistId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_ProductComputer_lintComputerNodeId.htm"/>
    public virtual int lintComputerNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_ProductComputer_lintProductId.htm"/>
    public virtual int lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_ProductComputer_ProductStateId.htm"/>
    public virtual int ProductStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_ProductComputer_txtDetCDKey.htm"/>
    public virtual string txtDetCDKey { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_ProductComputer_txtDetProductVersion.htm"/>
    public virtual string txtDetProductVersion { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vSwInst_ProductComputer__ctor.htm"/>
    public vSwInst_ProductComputer() { }
}
