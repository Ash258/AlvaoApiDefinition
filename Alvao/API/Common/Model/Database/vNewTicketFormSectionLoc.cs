using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary></summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vNewTicketFormSectionLoc.htm"/>
[TableAttribute("dbo.vNewTicketFormSectionLoc")]
public class vNewTicketFormSectionLoc {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNewTicketFormSectionLoc_Expand.htm"/>
    public virtual bool Expand { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNewTicketFormSectionLoc_id.htm"/>
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNewTicketFormSectionLoc_LocaleId.htm"/>
    public virtual int LocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNewTicketFormSectionLoc_Name.htm"/>
    public virtual string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNewTicketFormSectionLoc_Order.htm"/>
    public virtual int Order { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNewTicketFormSectionLoc_SectionId.htm"/>
    public virtual int SectionId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vNewTicketFormSectionLoc__ctor.htm"/>
    public vNewTicketFormSectionLoc() { }
}
