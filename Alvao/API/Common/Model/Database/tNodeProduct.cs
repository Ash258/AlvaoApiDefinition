using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Software profiles - exceptions for the computer.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tNodeProduct.htm"/>
[TableAttribute("dbo.tNodeProduct")]
public class tNodeProduct {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tNodeProduct_liNodeId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int? liNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tNodeProduct_liProductId.htm"/>
    public virtual int? liProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tNodeProduct_liSwPresenceId.htm"/>
    public virtual int liSwPresenceId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tNodeProduct__ctor.htm"/>
    public tNodeProduct() { }
}
