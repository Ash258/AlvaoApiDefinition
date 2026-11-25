using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoModule.html"/>
[Table("dbo.AlvaoModule")]
public class AlvaoModule {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoModule.ModuleId.html#fields"/>
    public enum ModuleId {
        AM = 1,
        SD = 2,
        SDCombined = 3,
        OA = 4,
        MON = 5,
        Feedback = 6,
        SwLib = 7,
        UsageMonitoring = 8,
        Attendance = 9,
        SAMAssistant = 10,
        CallCentre = 11,
        ConfigurationManagement = 12,
        Dashboard = 13,
        EmployeeManager = 14,
        ISOReporting = 15,
        MobileInventory = 16,
        WebBasedAssignedAssetCheck = 17,
        SCCMConnector = 18,
        RequestForms = 19,
        AccountCreator = 20,
        ElectronicHandoverForms = 21,
        SDCustomApps = 22,
        SDEnterpriseApi = 23,
        AMCustomApps = 24,
        AMEnterpriseApi = 25,
        DevOpsConnector = 26,
        SDAdvancedWorkflow = 27,
        InventoryAudits = 28,
        AMAutopilot = 29,
        TeamsAddin = 30,
        EndpointManagementConnectors = 31,
        SNMPNetworkDiscovery = 32,
        ServiceDeskAIAssistant = 33,
        JiraConnector = 34,
        AutomaticContentTranslation = 35,
        MicrosoftMultidomainAuthentication = 36,
        KnowledgeBaseAIAssistant = 37,
        KnowledgeBaseSharepointConnector = 38,
        SoftwareAssetManagement = 39,
        DiscoveryAgent = 40,
        DevOpsConnectors = 41,
        TicketingConnectors = 42,
        MonitoringConnectors = 43,
        IntelligenceAI = 44,
        AIAgent = 45,
        AMMcpServer = 46,
        SDMcpServer = 47,
        CopilotConnector = 48,
    }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoModule.html#Alvao_API_Common_Model_Database_AlvaoModule_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AlvaoModule.html#Alvao_API_Common_Model_Database_AlvaoModule_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(255), not null.</remarks>
    public virtual string Name { get; set; }
}
