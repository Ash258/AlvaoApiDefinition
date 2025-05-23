using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Rights in the object tree - main view.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vPersonNodeRight.htm"/>
[TableAttribute("dbo.vPersonNodeRight")]
public class vPersonNodeRight {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPersonNodeRight_bDelete.htm"/>
    public virtual int? bDelete { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPersonNodeRight_bMove.htm"/>
    public virtual int? bMove { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPersonNodeRight_bRead.htm"/>
    public virtual int? bRead { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPersonNodeRight_bWrite.htm"/>
    public virtual int? bWrite { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPersonNodeRight_CreateObj.htm"/>
    public virtual int? CreateObj { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPersonNodeRight_liNodeId.htm"/>
    public virtual int? liNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vPersonNodeRight_liPersonId.htm"/>
    public virtual int? liPersonId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vPersonNodeRight__ctor.htm"/>
    public vPersonNodeRight() { }
}
