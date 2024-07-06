using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Rights in the object tree - main view.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vPersonNodeRight.htm"/>
[TableAttribute("dbo.vPersonNodeRight")]
public class vPersonNodeRight
{
    public virtual int? bDelete { get; set; }
    public virtual int? bMove { get; set; }
    public virtual int? bRead { get; set; }
    public virtual int? bWrite { get; set; }
    public virtual int? CreateObj { get; set; }
    public virtual int? liNodeId { get; set; }
    public virtual int? liPersonId { get; set; }

    public vPersonNodeRight() { }
}
