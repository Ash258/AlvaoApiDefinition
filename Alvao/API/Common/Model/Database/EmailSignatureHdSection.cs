using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Assigning signatures to services.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.EmailSignatureHdSection.html"/>
[Table("dbo.EmailSignatureHdSection")]
public class EmailSignatureHdSection {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.EmailSignatureHdSection.html#Alvao_API_Common_Model_Database_EmailSignatureHdSection_EmailSignatureId"/>
    [ExplicitKey]
    public virtual int EmailSignatureId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.EmailSignatureHdSection.html#Alvao_API_Common_Model_Database_EmailSignatureHdSection_HdSectionId"/>
    public virtual int? HdSectionId { get; set; }
}
