using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// For each service, it returns a string which guarantees queueing being the same as that in the tree.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSectionWithTreeOrder.htm"/>
[TableAttribute("dbo.vSectionWithTreeOrder")]
public class vSectionWithTreeOrder
{
    public virtual int? iHdSectionId { get; set; }
    public virtual double? nHdSectionOrder { get; set; }
    public virtual string sHdSection { get; set; }
    public virtual string TreeSorting { get; set; }

    public vSectionWithTreeOrder() { }
}
