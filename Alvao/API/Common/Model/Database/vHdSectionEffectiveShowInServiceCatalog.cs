using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>View for effective viewing of the &quot;View in the Service catalog&quot; option. Takes into account settings in parent services.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionEffectiveShowInServiceCatalog.html"/>
[Table("dbo.vHdSectionEffectiveShowInServiceCatalog")]
public class vHdSectionEffectiveShowInServiceCatalog {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionEffectiveShowInServiceCatalog.html#Alvao_API_Common_Model_Database_vHdSectionEffectiveShowInServiceCatalog_EffectiveShowInServiceCatalog"/>
    public virtual bool? EffectiveShowInServiceCatalog { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionEffectiveShowInServiceCatalog.html#Alvao_API_Common_Model_Database_vHdSectionEffectiveShowInServiceCatalog_iHdSectionId"/>
    public virtual int? iHdSectionId { get; set; }
}
