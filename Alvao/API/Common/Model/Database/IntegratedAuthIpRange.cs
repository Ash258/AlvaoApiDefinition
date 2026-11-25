using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>IP address range for Integrated Windows Authentication.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.IntegratedAuthIpRange.html"/>
[Table("dbo.IntegratedAuthIpRange")]
public class IntegratedAuthIpRange {
    /// <summary>Beginning of the range of IP addresses, including.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.IntegratedAuthIpRange.html#Alvao_API_Common_Model_Database_IntegratedAuthIpRange_FromIP"/>
    /// <remarks>Column <c>FromIP</c>: bigint, null.</remarks>
    public virtual long? FromIP { get; set; }
    /// <summary>End of the range of IP addresses, including endpoint.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.IntegratedAuthIpRange.html#Alvao_API_Common_Model_Database_IntegratedAuthIpRange_ToIP"/>
    /// <remarks>Column <c>ToIP</c>: bigint, null.</remarks>
    public virtual long? ToIP { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.IntegratedAuthIpRange.html#Alvao_API_Common_Model_Database_IntegratedAuthIpRange_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
