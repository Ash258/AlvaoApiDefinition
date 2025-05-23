using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Special installation.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblInstTrial.htm"/>
[TableAttribute("dbo.tblInstTrial")]
public class tblInstTrial {
    /// <summary>Computer - tblNode</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInstTrial_lintComputerNodeId.htm"/>
    public virtual int lintComputerNodeId { get; set; }
    /// <summary>Product - tblProduct</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInstTrial_lintProductId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int lintProductId { get; set; }
    /// <summary>Note</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInstTrial_txtDesc.htm"/>
    public virtual string txtDesc { get; set; }
    /// <summary>Date of expiration</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblInstTrial_ValidUntil.htm"/>
    public virtual DateTime? ValidUntil { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblInstTrial__ctor.htm"/>
    public tblInstTrial() { }
}
