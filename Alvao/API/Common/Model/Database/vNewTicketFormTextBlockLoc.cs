using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vNewTicketFormTextBlockLoc.htm"/>
[TableAttribute("dbo.vNewTicketFormTextBlockLoc")]
public class vNewTicketFormTextBlockLoc
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNewTicketFormTextBlockLoc_id.htm"/>
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNewTicketFormTextBlockLoc_iLocaleId.htm"/>
    public virtual int iLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNewTicketFormTextBlockLoc_Order.htm"/>
    public virtual int Order { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNewTicketFormTextBlockLoc_SectionId.htm"/>
    public virtual int SectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNewTicketFormTextBlockLoc_TextHtml.htm"/>
    public virtual string TextHtml { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vNewTicketFormTextBlockLoc__ctor.htm"/>
    public vNewTicketFormTextBlockLoc() { }
}
