using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Address
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tAddress.htm"/>
[TableAttribute("dbo.tAddress")]
public class tAddress
{
    /// <summary>City</summary>
    public virtual string City { get; set; }
    /// <summary>Country</summary>
    public virtual string Country { get; set; }
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Street</summary>
    public virtual string Street { get; set; }
    /// <summary>ZIP code</summary>
    public virtual string ZIP { get; set; }

    public tAddress() { }
}
