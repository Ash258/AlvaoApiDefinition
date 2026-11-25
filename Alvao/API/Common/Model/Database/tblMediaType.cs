using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>ID of the media types. Texts in tblDict.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblMediaType.html"/>
[Table("dbo.tblMediaType")]
public class tblMediaType {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblMediaType.html#Alvao_API_Common_Model_Database_tblMediaType_intMediaTypeId"/>
    /// <remarks>Column <c>intMediaTypeId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int intMediaTypeId { get; set; }
}
