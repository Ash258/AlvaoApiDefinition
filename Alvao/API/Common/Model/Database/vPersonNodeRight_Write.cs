using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Rights in the object tree - the right to "Change".
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vPersonNodeRight_Write.htm"/>
[TableAttribute("dbo.vPersonNodeRight_Write")]
public class vPersonNodeRight_Write
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPersonNodeRight_Write_liNodeId.htm"/>
    public virtual int? liNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPersonNodeRight_Write_liPersonId.htm"/>
    public virtual int? liPersonId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vPersonNodeRight_Write__ctor.htm"/>
    public vPersonNodeRight_Write() { }
}
