using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Address</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tAddress.htm"/>
[TableAttribute("dbo.tAddress")]
public class tAddress {
    /// <summary>City</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAddress_City.htm"/>
    public virtual string City { get; set; }
    /// <summary>Country</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAddress_Country.htm"/>
    public virtual string Country { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAddress_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Street</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAddress_Street.htm"/>
    public virtual string Street { get; set; }
    /// <summary>ZIP code</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAddress_ZIP.htm"/>
    public virtual string ZIP { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tAddress__ctor.htm"/>
    public tAddress() { }
}
