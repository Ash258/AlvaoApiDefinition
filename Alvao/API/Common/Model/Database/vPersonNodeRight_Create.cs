using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Rights in the objects tree - the right to "Create any objects".</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vPersonNodeRight_Create.htm"/>
[TableAttribute("dbo.vPersonNodeRight_Create")]
public class vPersonNodeRight_Create {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPersonNodeRight_Create_liNodeId.htm"/>
    public virtual int? liNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPersonNodeRight_Create_liPersonId.htm"/>
    public virtual int? liPersonId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vPersonNodeRight_Create__ctor.htm"/>
    public vPersonNodeRight_Create() { }
}
