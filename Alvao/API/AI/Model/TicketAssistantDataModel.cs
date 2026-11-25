using Alvao.API.Common.Model.Database;

namespace Alvao.API.AI.Model;

/// <summary>
/// Data model for the ticket assistant containing all relevant information about the ticket, section, acts and
/// activation details.
/// </summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Model.TicketAssistantDataModel.html"/>
public class TicketAssistantDataModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Model.TicketAssistantDataModel.html#Alvao_API_AI_Model_TicketAssistantDataModel_Activation"/>
    public TicketAssistantActivationModel Activation { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Model.TicketAssistantDataModel.html#Alvao_API_AI_Model_TicketAssistantDataModel_ResponseLanguage"/>
    public string ResponseLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Model.TicketAssistantDataModel.html#Alvao_API_AI_Model_TicketAssistantDataModel_Section"/>
    public tHdSection Section { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Model.TicketAssistantDataModel.html#Alvao_API_AI_Model_TicketAssistantDataModel_Ticket"/>
    public tHdTicket Ticket { get; set; }
}
