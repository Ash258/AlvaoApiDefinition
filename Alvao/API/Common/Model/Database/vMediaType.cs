using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Types of media.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vMediaType.htm"/>
[TableAttribute("dbo.vMediaType")]
public class vMediaType {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vMediaType_intMediaTypeId.htm"/>
    public virtual int intMediaTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vMediaType_txtMediaType.htm"/>
    public virtual string txtMediaType { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vMediaType__ctor.htm"/>
    public vMediaType() { }
}
