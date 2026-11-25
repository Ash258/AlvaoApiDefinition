namespace Alvao.API.SD.Model.Ticket.TicketRelation;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Ticket.TicketRelation.TicketRelationTypeItemModel.html"/>
public class TicketRelationTypeItemModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Ticket.TicketRelation.TicketRelationTypeItemModel.html#Alvao_API_SD_Model_Ticket_TicketRelation_TicketRelationTypeItemModel_CompositeId"/>
    public int CompositeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Ticket.TicketRelation.TicketRelationTypeItemModel.html#Alvao_API_SD_Model_Ticket_TicketRelation_TicketRelationTypeItemModel_Directional"/>
    public bool Directional { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Ticket.TicketRelation.TicketRelationTypeItemModel.html#Alvao_API_SD_Model_Ticket_TicketRelation_TicketRelationTypeItemModel_Id"/>
    public int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Ticket.TicketRelation.TicketRelationTypeItemModel.html#Alvao_API_SD_Model_Ticket_TicketRelation_TicketRelationTypeItemModel_LocalizedName"/>
    public string LocalizedName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Ticket.TicketRelation.TicketRelationTypeItemModel.html#Alvao_API_SD_Model_Ticket_TicketRelation_TicketRelationTypeItemModel_Name"/>
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Ticket.TicketRelation.TicketRelationTypeItemModel.html#Alvao_API_SD_Model_Ticket_TicketRelation_TicketRelationTypeItemModel_OtherSide"/>
    public string OtherSide { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Ticket.TicketRelation.TicketRelationTypeItemModel.html#Alvao_API_SD_Model_Ticket_TicketRelation_TicketRelationTypeItemModel_Side"/>
    public int Side { get; set; }
}
