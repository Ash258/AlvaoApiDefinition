using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNewTicketFormSectionLoc.html"/>
[Table("dbo.vNewTicketFormSectionLoc")]
public class vNewTicketFormSectionLoc {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNewTicketFormSectionLoc.html#Alvao_API_Common_Model_Database_vNewTicketFormSectionLoc_Expand"/>
    public virtual bool Expand { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNewTicketFormSectionLoc.html#Alvao_API_Common_Model_Database_vNewTicketFormSectionLoc_LocaleId"/>
    public virtual int LocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNewTicketFormSectionLoc.html#Alvao_API_Common_Model_Database_vNewTicketFormSectionLoc_Name"/>
    public virtual string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNewTicketFormSectionLoc.html#Alvao_API_Common_Model_Database_vNewTicketFormSectionLoc_Order"/>
    public virtual int Order { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNewTicketFormSectionLoc.html#Alvao_API_Common_Model_Database_vNewTicketFormSectionLoc_SectionId"/>
    public virtual int SectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNewTicketFormSectionLoc.html#Alvao_API_Common_Model_Database_vNewTicketFormSectionLoc_id"/>
    public virtual int id { get; set; }
}
