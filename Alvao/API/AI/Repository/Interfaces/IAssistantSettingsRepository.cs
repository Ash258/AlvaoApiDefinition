using Alvao.API.AI.Model;

namespace Alvao.API.AI.Repository.Interfaces;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Repository.Interfaces.IAssistantSettingsRepository.html"/>
public interface IAssistantSettingsRepository {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Repository.Interfaces.IAssistantSettingsRepository.html#Alvao_API_AI_Repository_Interfaces_IAssistantSettingsRepository_Get"/>
    AssistantSettings Get();
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Repository.Interfaces.IAssistantSettingsRepository.html#Alvao_API_AI_Repository_Interfaces_IAssistantSettingsRepository_IsAssistantFindTicketsSolutionEnabled"/>
    bool IsAssistantFindTicketsSolutionEnabled();
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Repository.Interfaces.IAssistantSettingsRepository.html#Alvao_API_AI_Repository_Interfaces_IAssistantSettingsRepository_IsDbSemanticSearchAvailable"/>
    bool IsDbSemanticSearchAvailable();
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Repository.Interfaces.IAssistantSettingsRepository.html#Alvao_API_AI_Repository_Interfaces_IAssistantSettingsRepository_IsSettingsFromSectionCustEnabled_System_Int32_System_String_"/>
    bool IsSettingsFromSectionCustEnabled(int serviceId, string columnName);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Repository.Interfaces.IAssistantSettingsRepository.html#Alvao_API_AI_Repository_Interfaces_IAssistantSettingsRepository_IsSettingsFromTicketCustEnabled_System_Int32_System_String_"/>
    bool IsSettingsFromTicketCustEnabled(int ticketId, string columnName);
}
