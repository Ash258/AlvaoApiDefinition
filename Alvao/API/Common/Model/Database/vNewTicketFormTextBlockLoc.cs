using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNewTicketFormTextBlockLoc.html"/>
[Table("dbo.vNewTicketFormTextBlockLoc")]
public class vNewTicketFormTextBlockLoc {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNewTicketFormTextBlockLoc.html#Alvao_API_Common_Model_Database_vNewTicketFormTextBlockLoc_ColSpan"/>
    public virtual int? ColSpan { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNewTicketFormTextBlockLoc.html#Alvao_API_Common_Model_Database_vNewTicketFormTextBlockLoc_Column"/>
    public virtual int? Column { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNewTicketFormTextBlockLoc.html#Alvao_API_Common_Model_Database_vNewTicketFormTextBlockLoc_LocaleId"/>
    public virtual int LocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNewTicketFormTextBlockLoc.html#Alvao_API_Common_Model_Database_vNewTicketFormTextBlockLoc_Order"/>
    public virtual int Order { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNewTicketFormTextBlockLoc.html#Alvao_API_Common_Model_Database_vNewTicketFormTextBlockLoc_SectionId"/>
    public virtual int SectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNewTicketFormTextBlockLoc.html#Alvao_API_Common_Model_Database_vNewTicketFormTextBlockLoc_TextHtml"/>
    public virtual string TextHtml { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNewTicketFormTextBlockLoc.html#Alvao_API_Common_Model_Database_vNewTicketFormTextBlockLoc_id"/>
    public virtual int id { get; set; }
}
