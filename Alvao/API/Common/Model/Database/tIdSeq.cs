using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Numeric sequences - definitions for types of objects.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tIdSeqClass.htm"/>
[TableAttribute("dbo.tIdSeqClass")]
public class tIdSeqClass
{
    public virtual int? liClassId { get; set; }
    [ExplicitKeyAttribute]
    public virtual int liIdSeqId { get; set; }

    public tIdSeqClass() { }
}
