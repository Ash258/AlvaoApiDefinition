using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SectionSequence.html"/>
[Table("dbo.SectionSequence")]
public class SectionSequence {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SectionSequence.html#Alvao_API_Common_Model_Database_SectionSequence_NextSectionId"/>
    public virtual int NextSectionId { get; set; }
}
