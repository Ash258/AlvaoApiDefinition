using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>View for effective viewing of the "View in the Service catalog" option. Takes into account settings in parent services.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vHdSectionEffectiveShowInServiceCatalog.htm"/>
[TableAttribute("dbo.vHdSectionEffectiveShowInServiceCatalog")]
public class vHdSectionEffectiveShowInServiceCatalog {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionEffectiveShowInServiceCatalog_EffectiveShowInServiceCatalog.htm"/>
    public virtual bool? EffectiveShowInServiceCatalog { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionEffectiveShowInServiceCatalog_iHdSectionId.htm"/>
    public virtual int? iHdSectionId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vHdSectionEffectiveShowInServiceCatalog__ctor.htm"/>
    public vHdSectionEffectiveShowInServiceCatalog() { }
}
