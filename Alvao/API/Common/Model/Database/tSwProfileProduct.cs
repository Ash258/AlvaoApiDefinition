using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Software profiles - membership of products in profiles.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tSwProfileProduct.htm"/>
[TableAttribute("dbo.tSwProfileProduct")]
public class tSwProfileProduct
{
    public virtual int? liMemberSwProfileId { get; set; }
    public virtual int liProductId { get; set; }
    public virtual int liSwPresenceId { get; set; }
    [ExplicitKeyAttribute]
    public virtual int liSwProfileId { get; set; }

    public tSwProfileProduct() { }
}
