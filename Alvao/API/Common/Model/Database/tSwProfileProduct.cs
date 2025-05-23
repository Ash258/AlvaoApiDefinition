using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Software profiles - membership of products in profiles.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tSwProfileProduct.htm"/>
[TableAttribute("dbo.tSwProfileProduct")]
public class tSwProfileProduct {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwProfileProduct_liMemberSwProfileId.htm"/>
    public virtual int? liMemberSwProfileId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwProfileProduct_liProductId.htm"/>
    public virtual int liProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwProfileProduct_liSwPresenceId.htm"/>
    public virtual int liSwPresenceId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwProfileProduct_liSwProfileId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int liSwProfileId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tSwProfileProduct__ctor.htm"/>
    public tSwProfileProduct() { }
}
