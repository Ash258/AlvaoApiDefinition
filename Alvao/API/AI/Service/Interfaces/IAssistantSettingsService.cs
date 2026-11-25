using Alvao.API.AI.Model;

namespace Alvao.API.AI.Service.Interfaces;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAssistantSettingsService.html"/>
public interface IAssistantSettingsService {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAssistantSettingsService.html#Alvao_API_AI_Service_Interfaces_IAssistantSettingsService_GetSettings"/>
    AssistantSettings GetSettings();
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAssistantSettingsService.html#Alvao_API_AI_Service_Interfaces_IAssistantSettingsService_IsDbSemanticSearchAvailable"/>
    bool IsDbSemanticSearchAvailable();
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAssistantSettingsService.html#Alvao_API_AI_Service_Interfaces_IAssistantSettingsService_IsSemanticSearchAvailable"/>
    bool IsSemanticSearchAvailable();
}
