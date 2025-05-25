using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Numeric sequence types.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.IdSeqType.html"/>
[Table("dbo.IdSeqType")]
public class IdSeqType {
    /// <summary>Numeric sequence type.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.IdSeqType.html#Alvao_API_Common_Model_Database_IdSeqType__IdSeqType"/>
    public virtual string _IdSeqType { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.IdSeqType.html#Alvao_API_Common_Model_Database_IdSeqType_id"/>
    [ExplicitKey]
    public virtual int id { get; set; }
}
