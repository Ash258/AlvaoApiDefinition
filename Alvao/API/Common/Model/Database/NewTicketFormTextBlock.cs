using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary></summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_NewTicketFormTextBlock.htm"/>
[TableAttribute("dbo.NewTicketFormTextBlock")]
public class NewTicketFormTextBlock
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NewTicketFormTextBlock_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NewTicketFormTextBlock_Order.htm"/>
    public virtual int Order { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NewTicketFormTextBlock_SectionId.htm"/>
    public virtual int SectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NewTicketFormTextBlock_TextHtml.htm"/>
    public virtual string TextHtml { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_NewTicketFormTextBlock__ctor.htm"/>
    public NewTicketFormTextBlock() { }
}
