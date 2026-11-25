using Alvao.API.AI.Model;

namespace Alvao.API.AI.Service.Interfaces;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAssistantService.html"/>
public interface IAssistantService {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAssistantService.html#Alvao_API_AI_Service_Interfaces_IAssistantService_DetectMajorIncidentsAsync_System_Int32_System_Threading_CancellationToken_"/>
    Task<MajorIncidentModel> DetectMajorIncidentsAsync(int ticketId, CancellationToken cancellationToken = default);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAssistantService.html#Alvao_API_AI_Service_Interfaces_IAssistantService_GetGenericResponseJsonAsync_System_String_System_String_System_String_System_Object_System_Object_System_String_"/>
    Task<string> GetGenericResponseJsonAsync(string text, string systemMessage, string instructions, object functions = null, object functionCall = null, string model = null);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAssistantService.html#Alvao_API_AI_Service_Interfaces_IAssistantService_GetModelAsync_System_Int32_System_Threading_CancellationToken_"/>
    Task<AssistantTicketTabModel> GetModelAsync(int ticketId, CancellationToken cancellationToken = default);
}
