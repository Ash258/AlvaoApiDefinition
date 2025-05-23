using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Rights in the object tree - the right to "Remove".</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vPersonNodeRight_Delete.htm"/>
[TableAttribute("dbo.vPersonNodeRight_Delete")]
public class vPersonNodeRight_Delete {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPersonNodeRight_Delete_liNodeId.htm"/>
    public virtual int? liNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPersonNodeRight_Delete_liPersonId.htm"/>
    public virtual int? liPersonId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vPersonNodeRight_Delete__ctor.htm"/>
    public vPersonNodeRight_Delete() { }
}
