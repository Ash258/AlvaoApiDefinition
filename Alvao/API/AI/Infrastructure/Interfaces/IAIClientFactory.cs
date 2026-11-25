using Alvao.API.AI.Model;

namespace Alvao.API.AI.Infrastructure.Interfaces;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.Interfaces.IAIClientFactory.html"/>
public interface IAIClientFactory {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.Interfaces.IAIClientFactory.html#Alvao_API_AI_Infrastructure_Interfaces_IAIClientFactory_Create_Alvao_API_AI_Model_AssistantSettings_System_String_System_String_"/>
    [Obsolete("Use CreateFoundry instead. This method is retained for backward compatibility with custom applications.")]
    AIClient Create(AssistantSettings settings, string azureUrl, string azureKey);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.Interfaces.IAIClientFactory.html#Alvao_API_AI_Infrastructure_Interfaces_IAIClientFactory_CreateFoundry_Alvao_API_AI_Model_AssistantSettings_System_String_System_String_"/>
    IAIClient CreateFoundry(AssistantSettings settings, string azureUrl, string azureKey);
}
