using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormSection.html"/>
[Table("dbo.TicketStatusTransitionFormSection")]
public class TicketStatusTransitionFormSection {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormSection.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormSection_Expand"/>
    /// <remarks>Column <c>Expand</c>: bit, not null.</remarks>
    public virtual bool Expand { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormSection.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormSection_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [Key]
    public virtual int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormSection.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormSection_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(255), not null.</remarks>
    public virtual string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormSection.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormSection_Order"/>
    /// <remarks>Column <c>Order</c>: int, not null.</remarks>
    public virtual int Order { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormSection.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormSection_StatusId"/>
    /// <remarks>Column <c>StatusId</c>: int, not null. References <see cref="TicketState"/>.</remarks>
    public virtual int StatusId { get; set; }
}
