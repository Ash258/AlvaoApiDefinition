using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Assigning signatures to services.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_EmailSignatureHdSection.htm"/>
[TableAttribute("dbo.EmailSignatureHdSection")]
public class EmailSignatureHdSection
{
    [ExplicitKeyAttribute]
    public virtual int EmailSignatureId { get; set; }
    public virtual int? HdSectionId { get; set; }

    public EmailSignatureHdSection() { }
}
