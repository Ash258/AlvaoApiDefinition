using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Definition of software products packages (software products library).</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblProductPack.htm"/>
[TableAttribute("dbo.tblProductPack")]
public class tblProductPack
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProductPack_bolValid.htm"/>
    public virtual bool bolValid { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProductPack_dteTimeStamp.htm"/>
    public virtual DateTime dteTimeStamp { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProductPack_intFlags.htm"/>
    public virtual int? intFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProductPack_lintProductId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProductPack_lintProductPackId.htm"/>
    public virtual int lintProductPackId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProductPack_txtCertifiedBy.htm"/>
    public virtual string txtCertifiedBy { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblProductPack__ctor.htm"/>
    public tblProductPack() { }
}
