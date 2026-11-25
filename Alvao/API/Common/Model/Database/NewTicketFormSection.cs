using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Section order on a New Ticket Form</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormSection.html"/>
[Table("dbo.NewTicketFormSection")]
public class NewTicketFormSection {
    /// <summary>
    /// 1 = when the form for submitting a new ticket is displayed, the section will be expanded. 0 = the section will
    /// be collapsed
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormSection.html#Alvao_API_Common_Model_Database_NewTicketFormSection_Expand"/>
    /// <remarks>Column <c>Expand</c>: bit, not null.</remarks>
    public virtual bool Expand { get; set; }
    /// <summary>Section name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormSection.html#Alvao_API_Common_Model_Database_NewTicketFormSection_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(255), not null.</remarks>
    public virtual string Name { get; set; }
    /// <summary>Row on which the item is displayed</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormSection.html#Alvao_API_Common_Model_Database_NewTicketFormSection_Order"/>
    /// <remarks>Column <c>Order</c>: int, not null.</remarks>
    public virtual int Order { get; set; }
    /// <summary>Id of the service (tHdSection.iHdSectionId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormSection.html#Alvao_API_Common_Model_Database_NewTicketFormSection_SectionId"/>
    /// <remarks>Column <c>SectionId</c>: int, not null. References <see cref="tHdSection"/>.</remarks>
    public virtual int SectionId { get; set; }
    /// <summary>Entity ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormSection.html#Alvao_API_Common_Model_Database_NewTicketFormSection_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
