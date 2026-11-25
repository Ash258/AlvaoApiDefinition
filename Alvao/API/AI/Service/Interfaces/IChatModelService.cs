using Alvao.API.AI.Model;
using Alvao.API.Common.Model.Database;

namespace Alvao.API.AI.Service.Interfaces;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IChatModelService.html"/>
public interface IChatModelService {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IChatModelService.html#Alvao_API_AI_Service_Interfaces_IChatModelService_GetDeploymentName"/>
    string GetDeploymentName();
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IChatModelService.html#Alvao_API_AI_Service_Interfaces_IChatModelService_GetEnabledModel"/>
    ChatModel GetEnabledModel();
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IChatModelService.html#Alvao_API_AI_Service_Interfaces_IChatModelService_GetPromptText_Alvao_API_AI_Model_ChatPrompt_"/>
    string GetPromptText(ChatPrompt chatPrompt);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IChatModelService.html#Alvao_API_AI_Service_Interfaces_IChatModelService_GetPromptWithVariables_Alvao_API_AI_Model_ChatPrompt_Alvao_API_AI_Model_PromptVariables_"/>
    string GetPromptWithVariables(ChatPrompt chatPrompt, PromptVariables variables);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IChatModelService.html#Alvao_API_AI_Service_Interfaces_IChatModelService_SaveModelAsync_System_String_System_String_System_Threading_CancellationToken_"/>
    Task SaveModelAsync(string modelName, string deploymentName, CancellationToken cancellationToken);
}
