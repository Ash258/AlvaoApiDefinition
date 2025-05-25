using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>For each service, it returns a string which guarantees queueing being the same as that in the tree.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSectionWithTreeOrder.html"/>
[Table("dbo.vSectionWithTreeOrder")]
public class vSectionWithTreeOrder {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSectionWithTreeOrder.html#Alvao_API_Common_Model_Database_vSectionWithTreeOrder_TreeSorting"/>
    public virtual string TreeSorting { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSectionWithTreeOrder.html#Alvao_API_Common_Model_Database_vSectionWithTreeOrder_iHdSectionId"/>
    public virtual int? iHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSectionWithTreeOrder.html#Alvao_API_Common_Model_Database_vSectionWithTreeOrder_nHdSectionOrder"/>
    public virtual double? nHdSectionOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSectionWithTreeOrder.html#Alvao_API_Common_Model_Database_vSectionWithTreeOrder_sHdSection"/>
    public virtual string sHdSection { get; set; }
}
