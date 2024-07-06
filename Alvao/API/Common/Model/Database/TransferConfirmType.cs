using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Method of the assets takeover signing.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TransferConfirmType.htm"/>
[TableAttribute("dbo.TransferConfirmType")]
public class TransferConfirmType
{
    /// <summary>Item ID.</summary>
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Name.</summary>
    public virtual string Name { get; set; }

    public TransferConfirmType() { }
}
