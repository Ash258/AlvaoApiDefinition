using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Rights in the object tree - the right to "Change".
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vPersonNodeRight_Write.htm"/>
[TableAttribute("dbo.vPersonNodeRight_Write")]
public class vPersonNodeRight_Write
{
    public virtual int? liNodeId { get; set; }
    public virtual int? liPersonId { get; set; }

    public vPersonNodeRight_Write() { }
}
