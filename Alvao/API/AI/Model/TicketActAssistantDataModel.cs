namespace Alvao.API.AI.Model;

/// <summary>Represents assistant data for a ticket act, including the associated act identifier.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Model.TicketActAssistantDataModel.html"/>
public class TicketActAssistantDataModel : TicketAssistantDataModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Model.TicketActAssistantDataModel.html#Alvao_API_AI_Model_TicketActAssistantDataModel_ActId"/>
    public int ActId { get; set; }
}
