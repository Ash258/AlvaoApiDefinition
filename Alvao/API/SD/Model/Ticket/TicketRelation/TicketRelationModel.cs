namespace Alvao.API.SD.Model.Ticket.TicketRelation;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Ticket.TicketRelation.TicketRelationModel.html"/>
public class TicketRelationModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Ticket.TicketRelation.TicketRelationModel.html#Alvao_API_SD_Model_Ticket_TicketRelation_TicketRelationModel_BeginTicketId"/>
    public int? BeginTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Ticket.TicketRelation.TicketRelationModel.html#Alvao_API_SD_Model_Ticket_TicketRelation_TicketRelationModel_EndTicketId"/>
    public int? EndTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Ticket.TicketRelation.TicketRelationModel.html#Alvao_API_SD_Model_Ticket_TicketRelation_TicketRelationModel_EndTicketName"/>
    public string EndTicketName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Ticket.TicketRelation.TicketRelationModel.html#Alvao_API_SD_Model_Ticket_TicketRelation_TicketRelationModel_RelationBeginName"/>
    public string RelationBeginName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Ticket.TicketRelation.TicketRelationModel.html#Alvao_API_SD_Model_Ticket_TicketRelation_TicketRelationModel_RelationId"/>
    public int? RelationId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Ticket.TicketRelation.TicketRelationModel.html#Alvao_API_SD_Model_Ticket_TicketRelation_TicketRelationModel_RelationTypeId"/>
    public int RelationTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.Ticket.TicketRelation.TicketRelationModel.html#Alvao_API_SD_Model_Ticket_TicketRelation_TicketRelationModel_RelationTypeItems"/>
    public IEnumerable<TicketRelationTypeItemModel> RelationTypeItems { get; set; }
}
