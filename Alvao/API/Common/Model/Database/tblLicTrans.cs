using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// License - shared licenses.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblLicTrans.htm"/>
[TableAttribute("dbo.tblLicTrans")]
public class tblLicTrans
{
    /// <summary>Computer from which the license is shared - tblNode</summary>
    public virtual int LicNodeId { get; set; }
    /// <summary>Product - tblProduct</summary>
    [ExplicitKeyAttribute]
    public virtual int lintProductId { get; set; }
    /// <summary>Computer - tblNode</summary>
    public virtual int NodeId { get; set; }
    /// <summary>Note</summary>
    public virtual string txtDesc { get; set; }

    public tblLicTrans() { }
}
