using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Types of media.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vMediaType.html"/>
[Table("dbo.vMediaType")]
public class vMediaType {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vMediaType.html#Alvao_API_Common_Model_Database_vMediaType_intMediaTypeId"/>
    public virtual int intMediaTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vMediaType.html#Alvao_API_Common_Model_Database_vMediaType_txtMediaType"/>
    public virtual string txtMediaType { get; set; }
}
