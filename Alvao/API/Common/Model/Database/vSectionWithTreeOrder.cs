using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>For each service, it returns a string which guarantees queueing being the same as that in the tree.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSectionWithTreeOrder.htm"/>
[TableAttribute("dbo.vSectionWithTreeOrder")]
public class vSectionWithTreeOrder
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSectionWithTreeOrder_iHdSectionId.htm"/>
    public virtual int? iHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSectionWithTreeOrder_nHdSectionOrder.htm"/>
    public virtual double? nHdSectionOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSectionWithTreeOrder_sHdSection.htm"/>
    public virtual string sHdSection { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSectionWithTreeOrder_TreeSorting.htm"/>
    public virtual string TreeSorting { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vSectionWithTreeOrder__ctor.htm"/>
    public vSectionWithTreeOrder() { }
}
