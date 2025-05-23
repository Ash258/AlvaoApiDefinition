using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>ID of the media types. Texts in tblDict.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblMediaType.htm"/>
[TableAttribute("dbo.tblMediaType")]
public class tblMediaType
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblMediaType_intMediaTypeId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int intMediaTypeId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblMediaType__ctor.htm"/>
    public tblMediaType() { }
}
