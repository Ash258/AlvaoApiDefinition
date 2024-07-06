using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Software profiles - exceptions for the computer.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tNodeProduct.htm"/>
[TableAttribute("dbo.tNodeProduct")]
public class tNodeProduct
{
    [ExplicitKeyAttribute]
    public virtual int? liNodeId { get; set; }
    public virtual int? liProductId { get; set; }
    public virtual int liSwPresenceId { get; set; }

    public tNodeProduct() { }
}
