using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Section order on a New Ticket Form</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormSection.html"/>
[Table("dbo.NewTicketFormSection")]
public class NewTicketFormSection {
    /// <summary>1 = when the form for submitting a new ticket is displayed, the section will be expanded. 0 = the section will be collapsed</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormSection.html#Alvao_API_Common_Model_Database_NewTicketFormSection_Expand"/>
    public virtual bool Expand { get; set; }
    /// <summary>Section name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormSection.html#Alvao_API_Common_Model_Database_NewTicketFormSection_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Row on which the item is displayed</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormSection.html#Alvao_API_Common_Model_Database_NewTicketFormSection_Order"/>
    public virtual int Order { get; set; }
    /// <summary>Id of the service (tHdSection.iHdSectionId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormSection.html#Alvao_API_Common_Model_Database_NewTicketFormSection_SectionId"/>
    public virtual int SectionId { get; set; }
    /// <summary>Entity ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormSection.html#Alvao_API_Common_Model_Database_NewTicketFormSection_id"/>
    [Key]
    public virtual int id { get; set; }
}
