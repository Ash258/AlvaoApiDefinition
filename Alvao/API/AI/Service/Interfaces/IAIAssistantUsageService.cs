using Alvao.API.AI.Model;

namespace Alvao.API.AI.Service.Interfaces;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAIAssistantUsageService.html"/>
public interface IAIAssistantUsageService {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAIAssistantUsageService.html#Alvao_API_AI_Service_Interfaces_IAIAssistantUsageService_IsDailyEmbeddingLimitExceeded"/>
    bool IsDailyEmbeddingLimitExceeded();
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAIAssistantUsageService.html#Alvao_API_AI_Service_Interfaces_IAIAssistantUsageService_IsDailyLimitExceeded"/>
    bool IsDailyLimitExceeded();
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAIAssistantUsageService.html#Alvao_API_AI_Service_Interfaces_IAIAssistantUsageService_UpdateEmbeddingUsage_Alvao_API_AI_Model_UsageResponse_System_String_System_String_"/>
    void UpdateEmbeddingUsage(UsageResponse usage, string feature, string groupName);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAIAssistantUsageService.html#Alvao_API_AI_Service_Interfaces_IAIAssistantUsageService_UpdateTicketDescriptionMetrics_Alvao_API_AI_Model_UsageResponse_"/>
    void UpdateTicketDescriptionMetrics(UsageResponse usage);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAIAssistantUsageService.html#Alvao_API_AI_Service_Interfaces_IAIAssistantUsageService_UpdateUsage_Alvao_API_AI_Model_UsageResponse_System_String_System_String_"/>
    void UpdateUsage(UsageResponse usage, string feature, string groupName);
}
