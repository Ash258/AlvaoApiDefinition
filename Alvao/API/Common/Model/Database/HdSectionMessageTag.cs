using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Unique service prefix and suffix pair.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionMessageTag.html"/>
[Table("dbo.HdSectionMessageTag")]
public class HdSectionMessageTag {
    /// <summary>Prefix</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionMessageTag.html#Alvao_API_Common_Model_Database_HdSectionMessageTag_Prefix"/>
    /// <remarks>Column <c>Prefix</c>: nvarchar(255), null.</remarks>
    public virtual string Prefix { get; set; }
    /// <summary>Suffix</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionMessageTag.html#Alvao_API_Common_Model_Database_HdSectionMessageTag_Suffix"/>
    /// <remarks>Column <c>Suffix</c>: nvarchar(255), null.</remarks>
    public virtual string Suffix { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionMessageTag.html#Alvao_API_Common_Model_Database_HdSectionMessageTag_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
