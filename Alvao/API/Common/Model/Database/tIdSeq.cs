using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Numeric sequences - definitions for types of objects.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tIdSeqClass.htm"/>
[TableAttribute("dbo.tIdSeqClass")]
public class tIdSeqClass
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tIdSeqClass_liClassId.htm"/>
    public virtual int? liClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tIdSeqClass_liIdSeqId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int liIdSeqId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tIdSeqClass__ctor.htm"/>
    public tIdSeqClass() { }
}
