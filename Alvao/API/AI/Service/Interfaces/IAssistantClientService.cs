using Alvao.API.AI.Infrastructure;
using Alvao.API.AI.Infrastructure.Interfaces;

namespace Alvao.API.AI.Service.Interfaces;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAssistantClientService.html"/>
public interface IAssistantClientService {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAssistantClientService.html#Alvao_API_AI_Service_Interfaces_IAssistantClientService_GetAIClient"/>
    AIClient GetAIClient();
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAssistantClientService.html#Alvao_API_AI_Service_Interfaces_IAssistantClientService_GetFoundryAIClient"/>
    IAIClient GetFoundryAIClient();
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAssistantClientService.html#Alvao_API_AI_Service_Interfaces_IAssistantClientService_TestChatConnectionAsync_System_String_System_String_System_String_System_String_System_Threading_CancellationToken_"/>
    Task<string> TestChatConnectionAsync(string chatModelName, string chatDeploymentName, string azureUrl, string azureKey, CancellationToken cancellationToken);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAssistantClientService.html#Alvao_API_AI_Service_Interfaces_IAssistantClientService_TestEmbeddingConnectionAsync_System_String_System_String_System_String_System_String_System_Threading_CancellationToken_"/>
    Task<string> TestEmbeddingConnectionAsync(string embeddingsModelName, string embeddingsDeploymentName, string azureUrl, string azureKey, CancellationToken cancellationToken);
}
