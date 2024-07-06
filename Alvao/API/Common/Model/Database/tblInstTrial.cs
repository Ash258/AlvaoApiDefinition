using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Special installation.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblInstTrial.htm"/>
[TableAttribute("dbo.tblInstTrial")]
public class tblInstTrial
{
    /// <summary>Computer - tblNode</summary>
    public virtual int lintComputerNodeId { get; set; }
    /// <summary>Product - tblProduct</summary>
    [ExplicitKeyAttribute]
    public virtual int lintProductId { get; set; }
    /// <summary>Note</summary>
    public virtual string txtDesc { get; set; }
    /// <summary>Date of expiration</summary>
    public virtual DateTime? ValidUntil { get; set; }

    public tblInstTrial() { }
}
