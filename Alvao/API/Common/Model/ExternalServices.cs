namespace Alvao.API.Common.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ExternalServices.html"/>
public class ExternalServices {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ExternalServices.ExternalServiceType.html#fields"/>
    public enum ExternalServiceType {
        AutomaticContentTranslation = 1,
        AzureOpenAI = 2,
        AzureComputerVision = 3,
        ConversationalLanguageUnderstanding = 4,
        DocumentIntelligence = 5,
    }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ExternalServices.html#Alvao_API_Common_Model_ExternalServices_AutomaticContentTranslation_Key"/>
    public const string AutomaticContentTranslation_Key = "AutomaticContentTranslationKey";
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ExternalServices.html#Alvao_API_Common_Model_ExternalServices_AutomaticContentTranslation_Location"/>
    public const string AutomaticContentTranslation_Location = "AutomaticContentTranslationLocation";
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ExternalServices.html#Alvao_API_Common_Model_ExternalServices_AzureComputerVision_EndpointUrl"/>
    public const string AzureComputerVision_EndpointUrl = "AzureComputerVisionEndpointUrl";
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ExternalServices.html#Alvao_API_Common_Model_ExternalServices_AzureComputerVision_Key"/>
    public const string AzureComputerVision_Key = "AzureComputerVisionKey";
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ExternalServices.html#Alvao_API_Common_Model_ExternalServices_AzureOpenAI_Key"/>
    public const string AzureOpenAI_Key = "AzureOpenAIKey";
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ExternalServices.html#Alvao_API_Common_Model_ExternalServices_AzureOpenAI_Url"/>
    public const string AzureOpenAI_Url = "AzureOpenAIUrl";
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ExternalServices.html#Alvao_API_Common_Model_ExternalServices_ConversationalLanguageUnderstanding_EndpointUrl"/>
    public const string ConversationalLanguageUnderstanding_EndpointUrl = "ConversationalLanguageUnderstandingEndpointUrl";
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ExternalServices.html#Alvao_API_Common_Model_ExternalServices_ConversationalLanguageUnderstanding_Key"/>
    public const string ConversationalLanguageUnderstanding_Key = "ConversationalLanguageUnderstandingKey";
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ExternalServices.html#Alvao_API_Common_Model_ExternalServices_DocumentIntelligence_EndpointUrl"/>
    public const string DocumentIntelligence_EndpointUrl = "DocumentIntelligenceEndpointUrl";
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ExternalServices.html#Alvao_API_Common_Model_ExternalServices_DocumentIntelligence_Key"/>
    public const string DocumentIntelligence_Key = "DocumentIntelligenceKey";
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ExternalServices.html#Alvao_API_Common_Model_ExternalServices_PropertyLength"/>
    public const int PropertyLength = 2048;
}
