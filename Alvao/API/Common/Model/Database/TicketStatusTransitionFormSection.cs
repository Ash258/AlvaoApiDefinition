using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormSection.html"/>
[Table("dbo.TicketStatusTransitionFormSection")]
public class TicketStatusTransitionFormSection {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormSection.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormSection_Expand"/>
    public virtual bool Expand { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormSection.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormSection_Id"/>
    [Key]
    public virtual int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormSection.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormSection_Name"/>
    public virtual string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormSection.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormSection_Order"/>
    public virtual int Order { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormSection.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormSection_StatusId"/>
    public virtual int StatusId { get; set; }
}
