using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Assigning signatures to services.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_EmailSignatureHdSection.htm"/>
[TableAttribute("dbo.EmailSignatureHdSection")]
public class EmailSignatureHdSection {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_EmailSignatureHdSection_EmailSignatureId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int EmailSignatureId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_EmailSignatureHdSection_HdSectionId.htm"/>
    public virtual int? HdSectionId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_EmailSignatureHdSection__ctor.htm"/>
    public EmailSignatureHdSection() { }
}
