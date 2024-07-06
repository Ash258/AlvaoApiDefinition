namespace Alvao.API.Common;

/// <summary>
/// Facade class grouping tProperty methods.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_DbProperty.htm"/>
public static class DbProperty
{
    public static string AddinWebUrl { get; set; }
    public static string AlvaoStandardSenderAddress { get; set; }
    public static string AM_MyDocumentsWorkflowText { get; set; }
    public static string AM_Query_PreferredProperties { get; set; }
    public static bool AM_Scim_ImportUsers { get; set; }
    public static int AMDefaultComputerClass { get; set; }
    public static string AnalysisDatabase { get; set; }
    public static bool AnalysisEnabled { get; set; }
    public static string AnalysisServer { get; set; }
    public static bool AssetManagement_Agent_CreateNewComputers { get; set; }
    public static string AssetManagement_PrintTemplateHtml { get; set; }
    public static string AssetManagement_TransferProtocol_PageSettings { get; set; }
    public static string AssetManagement_WebServiceAgentAuthCode { get; set; }
    public static string AssetWebService_Url { get; set; }
    public static string Authentication_DefaultDomain { get; set; }
    public static string Authentication_LdapServer { get; set; }
    public static int AutoLogoutMinutes { get; set; }
    public static string ContextHelpUrl { get; set; }
    public static bool Create_Doc { get; set; }
    public static string CustomAppsWebServiceUrl { get; set; }
    public static string DbOptimization_LastErrorMessage { get; set; }
    public static DateTime? DbOptimization_LastRequestCreated { get; set; }
    public static DateTime? DbOptimization_LastRequestFinished { get; set; }
    public static string DefaultTimeZone { get; set; }
    public static string Documents_Path { get; set; }
    public static bool Documents_SaveToDb { get; set; }
    public static string GlobalAttachmentBlacklist { get; set; }
    public static string GlobalAttachmentWhitelist { get; set; }
    public static string HTMLHeader { get; set; }
    public static string ImportCSVColumnSeparator { get; }
    public static bool InsiderPreview { get; set; }
    public static string Inventory_SenderAddress { get; set; }
    public static DateTime LicenceExpirationLastSend { get; set; }
    public static string MailerDaemons { get; set; }
    public static int MailSendIntervalSeconds { get; set; }
    public static int MailSendMaxAttempts { get; set; }
    public static int MailSendRetryIntervalMinutes { get; set; }
    public static bool NonClasProdStateWarn { get; set; }
    public static string RestApiUrl { get; set; }
    public static string ServiceDesk_HtmlStyle { get; set; }
    public static string ServiceDesk_OperatorsNotificationsSubject { get; set; }
    public static string ServiceDesk_RecommendedColors { get; set; }
    public static int ServiceDesk_SubmissionMethod { get; set; }
    public static bool Show_Domain { get; set; }
    public static string SlaAlert_FromEmail { get; set; }
    public static bool Transfer_Generate_New_Doc { get; set; }
    public static int WebApp_CompanyLogo_BackgroundImageDocumentId { get; set; }
    public static int WebApp_HomePage_BackgroundImageDocumentId { get; set; }
    public static string WebApp_MainMenu_CustomHead { get; set; }
    public static string WebApp_MainMenu_CustomTail { get; set; }
    public static bool WebApp_Settings_InstallApplications_ShowAmAgentLink { get; set; }
    public static bool WebApp_ShowWarningForAdmins { get; set; }
    public static string WebAppUrl { get; set; }

}
