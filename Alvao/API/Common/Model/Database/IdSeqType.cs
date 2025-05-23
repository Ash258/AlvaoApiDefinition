using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Numeric sequence types.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_IdSeqType.htm"/>
[TableAttribute("dbo.IdSeqType")]
public class IdSeqType
{
    /// <summary>Numeric sequence type.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_IdSeqType__IdSeqType.htm"/>
    public virtual string _IdSeqType { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_IdSeqType_id.htm"/>
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_IdSeqType__ctor.htm"/>
    public IdSeqType() { }
}
