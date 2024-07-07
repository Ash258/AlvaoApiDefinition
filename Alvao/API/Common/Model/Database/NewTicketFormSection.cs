using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary></summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_NewTicketFormSection.htm"/>
[TableAttribute("dbo.NewTicketFormSection")]
public class NewTicketFormSection
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NewTicketFormSection_Expand.htm"/>
    public virtual bool Expand { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NewTicketFormSection_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NewTicketFormSection_Name.htm"/>
    public virtual string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NewTicketFormSection_Order.htm"/>
    public virtual int Order { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NewTicketFormSection_SectionId.htm"/>
    public virtual int SectionId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_NewTicketFormSection__ctor.htm"/>
    public NewTicketFormSection() { }
}
