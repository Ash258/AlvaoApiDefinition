using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Definition of software products packages (software products library).
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblProductPack.htm"/>
[TableAttribute("dbo.tblProductPack")]
public class tblProductPack
{
    public virtual bool bolValid { get; set; }
    public virtual DateTime dteTimeStamp { get; set; }
    public virtual int? intFlags { get; set; }
    [ExplicitKeyAttribute]
    public virtual int lintProductId { get; set; }
    public virtual int lintProductPackId { get; set; }
    public virtual string txtCertifiedBy { get; set; }

    public tblProductPack() { }
}
