namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.html"/>
public class AssistantSettings {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.html#Alvao_API_AI_Model_AssistantSettings_ApiVersion"/>
    public string ApiVersion { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.html#Alvao_API_AI_Model_AssistantSettings_EmbeddingsModel"/>
    public string EmbeddingsModel { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.html#Alvao_API_AI_Model_AssistantSettings_GptModel"/>
    public string GptModel { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.html#Alvao_API_AI_Model_AssistantSettings_MajorIncidentDetection"/>
    public AssistantSettings.MajorIncidentDetectionSettings MajorIncidentDetection { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.html#Alvao_API_AI_Model_AssistantSettings_NewKnowledge"/>
    public AssistantSettings.NewKnowledgeSettings NewKnowledge { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.html#Alvao_API_AI_Model_AssistantSettings_SimilarKnowledges"/>
    public AssistantSettings.SimilarKnowledgesSettings SimilarKnowledges { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.html#Alvao_API_AI_Model_AssistantSettings_SimilarTickets"/>
    public AssistantSettings.SimilarTicketsSettings SimilarTickets { get; set; }


    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.MajorIncidentDetectionSettings.html"/>
    public class MajorIncidentDetectionSettings {
        /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.MajorIncidentDetectionSettings.html#Alvao_API_AI_Model_AssistantSettings_MajorIncidentDetectionSettings_BadHealthWeight"/>
        public double BadHealthWeight { get; set; }

        /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.MajorIncidentDetectionSettings.html#Alvao_API_AI_Model_AssistantSettings_MajorIncidentDetectionSettings_CriticalServiceWeight"/>
        public double CriticalServiceWeight { get; set; }

        /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.MajorIncidentDetectionSettings.html#Alvao_API_AI_Model_AssistantSettings_MajorIncidentDetectionSettings_MinimumRecentIncidentScore"/>
        public double MinimumRecentIncidentScore { get; set; }

        /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.MajorIncidentDetectionSettings.html#Alvao_API_AI_Model_AssistantSettings_MajorIncidentDetectionSettings_RecentChangeDays"/>
        public double RecentChangeDays { get; set; }

        /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.MajorIncidentDetectionSettings.html#Alvao_API_AI_Model_AssistantSettings_MajorIncidentDetectionSettings_RecentChangesScore"/>
        public double RecentChangesScore { get; set; }

        /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.MajorIncidentDetectionSettings.html#Alvao_API_AI_Model_AssistantSettings_MajorIncidentDetectionSettings_RecentChangesWeight"/>
        public double RecentChangesWeight { get; set; }

        /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.MajorIncidentDetectionSettings.html#Alvao_API_AI_Model_AssistantSettings_MajorIncidentDetectionSettings_RecentIncidentHours"/>
        public double RecentIncidentHours { get; set; }

        /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.MajorIncidentDetectionSettings.html#Alvao_API_AI_Model_AssistantSettings_MajorIncidentDetectionSettings_RecentIncidentScore"/>
        public double RecentIncidentScore { get; set; }

        /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.MajorIncidentDetectionSettings.html#Alvao_API_AI_Model_AssistantSettings_MajorIncidentDetectionSettings_RecentIncidentSimilarity"/>
        public double RecentIncidentSimilarity { get; set; }

        /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.MajorIncidentDetectionSettings.html#Alvao_API_AI_Model_AssistantSettings_MajorIncidentDetectionSettings_RecentIncidentWeight"/>
        public double RecentIncidentWeight { get; set; }

        /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.MajorIncidentDetectionSettings.html#Alvao_API_AI_Model_AssistantSettings_MajorIncidentDetectionSettings_SimilarIncidentWeight"/>
        public double SimilarIncidentWeight { get; set; }

    }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.NewKnowledgeSettings.html"/>
    public class NewKnowledgeSettings {
        /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.NewKnowledgeSettings.html#Alvao_API_AI_Model_AssistantSettings_NewKnowledgeSettings_AnalyseTicketCount"/>
        public int AnalyseTicketCount { get; set; }

        /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.NewKnowledgeSettings.html#Alvao_API_AI_Model_AssistantSettings_NewKnowledgeSettings_MinSimilarTicketCount"/>
        public int MinSimilarTicketCount { get; set; }

        /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.NewKnowledgeSettings.html#Alvao_API_AI_Model_AssistantSettings_NewKnowledgeSettings_MinTicketSimilarity"/>
        public double MinTicketSimilarity { get; set; }

        /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.NewKnowledgeSettings.html#Alvao_API_AI_Model_AssistantSettings_NewKnowledgeSettings_ShowRelatedTickets"/>
        public bool ShowRelatedTickets { get; set; }

    }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.SimilarKnowledgesSettings.html"/>
    public class SimilarKnowledgesSettings {
        /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.SimilarKnowledgesSettings.html#Alvao_API_AI_Model_AssistantSettings_SimilarKnowledgesSettings_Similarity"/>
        public double Similarity { get; set; }

    }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.SimilarTicketsSettings.html"/>
    public class SimilarTicketsSettings {
        /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.SimilarTicketsSettings.html#Alvao_API_AI_Model_AssistantSettings_SimilarTicketsSettings_CommunicationVectorWeight"/>
        public double CommunicationVectorWeight { get; set; }

        /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.SimilarTicketsSettings.html#Alvao_API_AI_Model_AssistantSettings_SimilarTicketsSettings_FieldsVectorWeight"/>
        public double FieldsVectorWeight { get; set; }

        /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.SimilarTicketsSettings.html#Alvao_API_AI_Model_AssistantSettings_SimilarTicketsSettings_ObjectsVectorWeight"/>
        public double ObjectsVectorWeight { get; set; }

        /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.AssistantSettings.SimilarTicketsSettings.html#Alvao_API_AI_Model_AssistantSettings_SimilarTicketsSettings_Similarity"/>
        public double Similarity { get; set; }

    }
}
