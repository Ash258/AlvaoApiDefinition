using Alvao.API.AI.Model;

namespace Alvao.API.AI.Service.Interfaces;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAssistantActivationService.html"/>
public interface IAssistantActivationService {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAssistantActivationService.html#Alvao_API_AI_Service_Interfaces_IAssistantActivationService_CheckSdAiAssistantEnabled_System_Boolean_"/>
    bool CheckSdAiAssistantEnabled(bool throwOnMissingModule = true);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAssistantActivationService.html#Alvao_API_AI_Service_Interfaces_IAssistantActivationService_GetTicketAssistantActivationModel_System_Int32_"/>
    TicketAssistantActivationModel GetTicketAssistantActivationModel(int sectionId);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAssistantActivationService.html#Alvao_API_AI_Service_Interfaces_IAssistantActivationService_GetTicketsAssistantDataModels_System_Collections_Generic_IEnumerable_System_Int32__"/>
    IEnumerable<TicketAssistantDataModel> GetTicketsAssistantDataModels(IEnumerable<int> ticketIds);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAssistantActivationService.html#Alvao_API_AI_Service_Interfaces_IAssistantActivationService_IsArticleVectorEnabled"/>
    bool IsArticleVectorEnabled();
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAssistantActivationService.html#Alvao_API_AI_Service_Interfaces_IAssistantActivationService_IsAssistantEnabled_System_Int32_"/>
    bool IsAssistantEnabled(int sectionId);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAssistantActivationService.html#Alvao_API_AI_Service_Interfaces_IAssistantActivationService_IsAssistantVectorsEnabled_System_Int32_"/>
    bool IsAssistantVectorsEnabled(int ticketId);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Service.Interfaces.IAssistantActivationService.html#Alvao_API_AI_Service_Interfaces_IAssistantActivationService_IsComputionOfSearchingVectorEnabled"/>
    bool IsComputionOfSearchingVectorEnabled();
}
