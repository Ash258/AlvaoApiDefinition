using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Unique service prefix and suffix pair.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionMessageTag.html"/>
[Table("dbo.HdSectionMessageTag")]
public class HdSectionMessageTag {
    /// <summary>Prefix</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionMessageTag.html#Alvao_API_Common_Model_Database_HdSectionMessageTag_Prefix"/>
    public virtual string Prefix { get; set; }
    /// <summary>Suffix</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionMessageTag.html#Alvao_API_Common_Model_Database_HdSectionMessageTag_Suffix"/>
    public virtual string Suffix { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionMessageTag.html#Alvao_API_Common_Model_Database_HdSectionMessageTag_id"/>
    [Key]
    public virtual int id { get; set; }
}
