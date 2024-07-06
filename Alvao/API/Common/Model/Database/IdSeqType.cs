using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Numeric sequence types.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_IdSeqType.htm"/>
[TableAttribute("dbo.IdSeqType")]
public class IdSeqType
{
    /// <summary>Numeric sequence type.</summary>
    public virtual string _IdSeqType { get; set; }
    /// <summary>Record ID.</summary>
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }

    public IdSeqType() { }
}
