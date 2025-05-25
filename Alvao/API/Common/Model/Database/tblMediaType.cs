using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>ID of the media types. Texts in tblDict.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblMediaType.html"/>
[Table("dbo.tblMediaType")]
public class tblMediaType {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblMediaType.html#Alvao_API_Common_Model_Database_tblMediaType_intMediaTypeId"/>
    [ExplicitKey]
    public virtual int intMediaTypeId { get; set; }
}
