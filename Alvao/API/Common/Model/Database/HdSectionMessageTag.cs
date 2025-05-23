using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Unique service prefix and suffix pair.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_HdSectionMessageTag.htm"/>
[TableAttribute("dbo.HdSectionMessageTag")]
public class HdSectionMessageTag {
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionMessageTag_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Prefix</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionMessageTag_Prefix.htm"/>
    public virtual string Prefix { get; set; }
    /// <summary>Suffix</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionMessageTag_Suffix.htm"/>
    public virtual string Suffix { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_HdSectionMessageTag__ctor.htm"/>
    public HdSectionMessageTag() { }
}
