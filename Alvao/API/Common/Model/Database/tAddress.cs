using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Address</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAddress.html"/>
[Table("dbo.tAddress")]
public class tAddress {
    /// <summary>City</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAddress.html#Alvao_API_Common_Model_Database_tAddress_City"/>
    public virtual string City { get; set; }
    /// <summary>Country</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAddress.html#Alvao_API_Common_Model_Database_tAddress_Country"/>
    public virtual string Country { get; set; }
    /// <summary>Street</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAddress.html#Alvao_API_Common_Model_Database_tAddress_Street"/>
    public virtual string Street { get; set; }
    /// <summary>ZIP code</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAddress.html#Alvao_API_Common_Model_Database_tAddress_ZIP"/>
    public virtual string ZIP { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAddress.html#Alvao_API_Common_Model_Database_tAddress_id"/>
    [Key]
    public virtual int id { get; set; }
}
