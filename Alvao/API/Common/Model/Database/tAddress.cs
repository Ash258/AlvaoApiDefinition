using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Address</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAddress.html"/>
[Table("dbo.tAddress")]
public class tAddress {
    /// <summary>City</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAddress.html#Alvao_API_Common_Model_Database_tAddress_City"/>
    /// <remarks>Column <c>City</c>: nvarchar(100), not null.</remarks>
    public virtual string City { get; set; }
    /// <summary>Country</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAddress.html#Alvao_API_Common_Model_Database_tAddress_Country"/>
    /// <remarks>Column <c>Country</c>: nvarchar(100), null.</remarks>
    public virtual string Country { get; set; }
    /// <summary>Street</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAddress.html#Alvao_API_Common_Model_Database_tAddress_Street"/>
    /// <remarks>Column <c>Street</c>: nvarchar(max), not null.</remarks>
    public virtual string Street { get; set; }
    /// <summary>ZIP code</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAddress.html#Alvao_API_Common_Model_Database_tAddress_ZIP"/>
    /// <remarks>Column <c>ZIP</c>: nvarchar(20), null.</remarks>
    public virtual string ZIP { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAddress.html#Alvao_API_Common_Model_Database_tAddress_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
