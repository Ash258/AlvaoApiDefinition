using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>ALVAO Service Desk product services.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html"/>
[Table("dbo.tHdSection")]
public class tHdSection {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_CreateNewFollowingRequest"/>
    /// <remarks>Column <c>CreateNewFollowingRequest</c>: bit, not null.</remarks>
    public virtual bool CreateNewFollowingRequest { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_CreateNewFollowingRequestToSection"/>
    /// <remarks>Column <c>CreateNewFollowingRequestToSection</c>: int, null.</remarks>
    public virtual int? CreateNewFollowingRequestToSection { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_CustomFeedbackUrl"/>
    /// <remarks>Column <c>CustomFeedbackUrl</c>: nvarchar(max), null.</remarks>
    public virtual string CustomFeedbackUrl { get; set; }
    /// <summary>Service local language.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_DefaultLanguageId"/>
    /// <remarks>Column <c>DefaultLanguageId</c>: int, null.</remarks>
    public virtual int? DefaultLanguageId { get; set; }
    /// <summary>Default ticket template.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_DefaultTicketTemplateId"/>
    /// <remarks>Column <c>DefaultTicketTemplateId</c>: int, null. References <see cref="TicketTemplate"/>.</remarks>
    public virtual int? DefaultTicketTemplateId { get; set; }
    /// <summary>Service local time zone.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_DefaultTimeZone"/>
    /// <remarks>Column <c>DefaultTimeZone</c>: nvarchar(64), null.</remarks>
    public virtual string DefaultTimeZone { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_DescriptionFieldName"/>
    /// <remarks>Column <c>DescriptionFieldName</c>: nvarchar(255), null.</remarks>
    public virtual string DescriptionFieldName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_DescriptionHtml"/>
    /// <remarks>Column <c>DescriptionHtml</c>: nvarchar(max), null.</remarks>
    public virtual string DescriptionHtml { get; set; }
    /// <summary>Application ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_EwsClientId"/>
    /// <remarks>Column <c>EwsClientId</c>: nvarchar(255), null.</remarks>
    public virtual string EwsClientId { get; set; }
    /// <summary>Secret client code.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_EwsClientSecret"/>
    /// <remarks>Column <c>EwsClientSecret</c>: nvarchar(255), null.</remarks>
    public virtual string EwsClientSecret { get; set; }
    /// <summary>Name of Exchange server.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_EwsServerName"/>
    /// <remarks>Column <c>EwsServerName</c>: nvarchar(255), null.</remarks>
    public virtual string EwsServerName { get; set; }
    /// <summary>Folder ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_EwsTenantId"/>
    /// <remarks>Column <c>EwsTenantId</c>: nvarchar(255), null.</remarks>
    public virtual string EwsTenantId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_ForceUseSolverLicense"/>
    /// <remarks>Column <c>ForceUseSolverLicense</c>: bit, not null.</remarks>
    public virtual bool ForceUseSolverLicense { get; set; }
    /// <summary>Enable or disable using of Microsoft Graph API change notifications.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_GraphChangeNotificationEnabled"/>
    /// <remarks>Column <c>GraphChangeNotificationEnabled</c>: bit, not null.</remarks>
    public virtual bool GraphChangeNotificationEnabled { get; set; }
    /// <summary>
    /// Enable if you want to allow non registered users (guests) to view ticket detail using a link sent in email
    /// notifications.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_GuestCanSeeTickets"/>
    /// <remarks>Column <c>GuestCanSeeTickets</c>: bit, not null.</remarks>
    public virtual bool GuestCanSeeTickets { get; set; }
    /// <summary>Service flag for setting the tiles on the home page.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_HomePage"/>
    /// <remarks>Column <c>HomePage</c>: bit, not null.</remarks>
    public virtual bool HomePage { get; set; }
    /// <summary>
    /// If the service icon was not loaded from the disk when upgrading to A10.2, this column displays &quot;Upload
    /// failed &lt;icon name&gt;&quot;. This value in the service table overloads the display name of the icon from the
    /// icon library. Otherwise, this column is NULL.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_IconName"/>
    /// <remarks>Column <c>IconName</c>: nvarchar(255), null.</remarks>
    public virtual string IconName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_ImapPort"/>
    /// <remarks>Column <c>ImapPort</c>: int, null.</remarks>
    public virtual int? ImapPort { get; set; }
    /// <summary>Service keywords.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_Keywords"/>
    /// <remarks>Column <c>Keywords</c>: nvarchar(max), null.</remarks>
    public virtual string Keywords { get; set; }
    /// <summary>List of SharePoint folder URLs relative to root folder.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_KnowledgeSharepointFolders"/>
    /// <remarks>Column <c>KnowledgeSharepointFolders</c>: nvarchar(max), null.</remarks>
    public virtual string KnowledgeSharepointFolders { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_LibraryIconId"/>
    /// <remarks>Column <c>LibraryIconId</c>: int, not null. References <see cref="LibraryIcon"/>.</remarks>
    public virtual int LibraryIconId { get; set; }
    /// <summary>Id of the mail server connection type (MailServerConnectionType.Id).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_MailServerConnectionTypeId"/>
    /// <remarks>
    /// Column <c>MailServerConnectionTypeId</c>: int, not null. References <see cref="MailServerConnectionType"/>.
    /// </remarks>
    public virtual int MailServerConnectionTypeId { get; set; }
    /// <summary>Custom objects field name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_ObjectsFieldName"/>
    /// <remarks>Column <c>ObjectsFieldName</c>: nvarchar(255), null.</remarks>
    public virtual string ObjectsFieldName { get; set; }
    /// <summary>Column for the &quot;View in the Service catalog&quot; option.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_ShowInServiceCatalog"/>
    /// <remarks>Column <c>ShowInServiceCatalog</c>: bit, not null.</remarks>
    public virtual bool ShowInServiceCatalog { get; set; }
    /// <summary>
    /// Id of the service (tHdSection.iHdSectionId) from which this service inherits SLA assignments. If this service
    /// doesnât inherit SLA assignments, this column contains the same value as the iHdSectionId column. If this
    /// record represents a service shortcut this column contains the same value as the TargetHdSectionId column or id
    /// of the service the target service inherits SLA assignments from.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_SlaRightsSectionId"/>
    /// <remarks>Column <c>SlaRightsSectionId</c>: int, not null. References <see cref="tHdSection"/>.</remarks>
    public virtual int SlaRightsSectionId { get; set; }
    /// <summary>Target service of the service shortcut.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_TargetHdSectionId"/>
    /// <remarks>Column <c>TargetHdSectionId</c>: int, null. References <see cref="tHdSection"/>.</remarks>
    public virtual int? TargetHdSectionId { get; set; }
    /// <summary>Ticket name template.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_TicketNameTemplate"/>
    /// <remarks>Column <c>TicketNameTemplate</c>: nvarchar(1023), null.</remarks>
    public virtual string TicketNameTemplate { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_TicketTypeId"/>
    /// <remarks>Column <c>TicketTypeId</c>: int, not null. References <see cref="TicketType"/>.</remarks>
    public virtual int TicketTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_TileColor"/>
    /// <remarks>Column <c>TileColor</c>: int, null.</remarks>
    public virtual int? TileColor { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_TileType"/>
    /// <remarks>Column <c>TileType</c>: int, not null.</remarks>
    public virtual int TileType { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_UseDescriptionFieldName"/>
    /// <remarks>Column <c>UseDescriptionFieldName</c>: bit, not null.</remarks>
    public virtual bool UseDescriptionFieldName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_UseFeedback"/>
    /// <remarks>Column <c>UseFeedback</c>: bit, not null.</remarks>
    public virtual bool UseFeedback { get; set; }
    /// <summary>Managers can read the tickets of their reports.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_UserManagerCanReadTickets"/>
    /// <remarks>Column <c>UserManagerCanReadTickets</c>: bit, not null.</remarks>
    public virtual bool UserManagerCanReadTickets { get; set; }
    /// <summary>
    /// Flaf to determine whether the service is default. 1 - service is default 0 - service is not default NULL -
    /// service is not default. Only one service can be default.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_bHdSectionDefault"/>
    /// <remarks>Column <c>bHdSectionDefault</c>: bit, not null.</remarks>
    public virtual bool bHdSectionDefault { get; set; }
    /// <summary>
    /// If the service is only a folder containing other services and the user cannot insert tickets, the value is 1.
    /// The button for creating a ticket for this service is not displayed in the portal.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_bHdSectionFolder"/>
    /// <remarks>Column <c>bHdSectionFolder</c>: bit, not null.</remarks>
    public virtual bool bHdSectionFolder { get; set; }
    /// <summary>
    /// If this is 1, the user can view the tickets of other users from the same organization in this service.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_bHdSectionHdTicketUserRead"/>
    /// <remarks>Column <c>bHdSectionHdTicketUserRead</c>: bit, not null.</remarks>
    public virtual bool bHdSectionHdTicketUserRead { get; set; }
    /// <summary>If the value is 1, SSL will be used for connecting to the IMAP server.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_bHdSectionImapSsl"/>
    /// <remarks>Column <c>bHdSectionImapSsl</c>: bit, not null.</remarks>
    public virtual bool bHdSectionImapSsl { get; set; }
    /// <summary>If the value is 1, messages are marked as read once the message is loaded.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_bHdSectionMessageMarkRead"/>
    /// <remarks>Column <c>bHdSectionMessageMarkRead</c>: bit, not null.</remarks>
    public virtual bool bHdSectionMessageMarkRead { get; set; }
    /// <summary>If the value is 1, only unread messages are read.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_bHdSectionMessageReadOnlyUnread"/>
    /// <remarks>Column <c>bHdSectionMessageReadOnlyUnread</c>: bit, not null.</remarks>
    public virtual bool bHdSectionMessageReadOnlyUnread { get; set; }
    /// <summary>If the value is 1, processed messages are removed from the server.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_bHdSectionMessageRemove"/>
    /// <remarks>Column <c>bHdSectionMessageRemove</c>: bit, not null.</remarks>
    public virtual bool bHdSectionMessageRemove { get; set; }
    /// <summary>Time at which the service was removed. The service is not removed for NULL.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_dHdSectionRemoved"/>
    /// <remarks>Column <c>dHdSectionRemoved</c>: datetime, null.</remarks>
    public virtual DateTime? dHdSectionRemoved { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_iHdSectionId"/>
    /// <remarks>Column <c>iHdSectionId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int iHdSectionId { get; set; }
    /// <summary>Link to ancestor in tree.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_liHdSectionParentHdSectionId"/>
    /// <remarks>Column <c>liHdSectionParentHdSectionId</c>: int, null. References <see cref="tHdSection"/>.</remarks>
    public virtual int? liHdSectionParentHdSectionId { get; set; }
    /// <summary>Description of service.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_mHdSectionDesc"/>
    /// <remarks>Column <c>mHdSectionDesc</c>: nvarchar(max), null.</remarks>
    public virtual string mHdSectionDesc { get; set; }
    /// <summary>Order in which services are displayed.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_nHdSectionOrder"/>
    /// <remarks>Column <c>nHdSectionOrder</c>: float, null.</remarks>
    public virtual double? nHdSectionOrder { get; set; }
    /// <summary>The number of days when the requester may reopen their ticket until the ticket is resolved.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_nHdSectionUserReopenDays"/>
    /// <remarks>Column <c>nHdSectionUserReopenDays</c>: float, null.</remarks>
    public virtual double? nHdSectionUserReopenDays { get; set; }
    /// <summary>Full service name, including location. For example &quot;Helpdesk/Technical Support&quot;.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_sHdSection"/>
    /// <remarks>Column <c>sHdSection</c>: nvarchar(1024), null.</remarks>
    public virtual string sHdSection { get; set; }
    /// <summary>Service email.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_sHdSectionEmail"/>
    /// <remarks>Column <c>sHdSectionEmail</c>: nvarchar(255), null.</remarks>
    public virtual string sHdSectionEmail { get; set; }
    /// <summary>Custom workflow URL.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_sHdSectionHdTicketCustomWorkflowUrl"/>
    /// <remarks>Column <c>sHdSectionHdTicketCustomWorkflowUrl</c>: nvarchar(1024), null.</remarks>
    public virtual string sHdSectionHdTicketCustomWorkflowUrl { get; set; }
    /// <summary>Address of IMAP server for loading messages.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_sHdSectionImapServer"/>
    /// <remarks>Column <c>sHdSectionImapServer</c>: nvarchar(255), null.</remarks>
    public virtual string sHdSectionImapServer { get; set; }
    /// <summary>Username for loading messages.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_sHdSectionMailboxLogin"/>
    /// <remarks>Column <c>sHdSectionMailboxLogin</c>: nvarchar(255), null.</remarks>
    public virtual string sHdSectionMailboxLogin { get; set; }
    /// <summary>Password for loading messages.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_sHdSectionMailboxPassword"/>
    /// <remarks>Column <c>sHdSectionMailboxPassword</c>: nvarchar(255), null.</remarks>
    public virtual string sHdSectionMailboxPassword { get; set; }
    /// <summary>Target folder for moving loaded messages.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_sHdSectionMessageFolder"/>
    /// <remarks>Column <c>sHdSectionMessageFolder</c>: nvarchar(255), null.</remarks>
    public virtual string sHdSectionMessageFolder { get; set; }
    /// <summary>Prefix in ticket number.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_sHdSectionMessageTagPrefix"/>
    /// <remarks>Column <c>sHdSectionMessageTagPrefix</c>: nvarchar(255), null.</remarks>
    public virtual string sHdSectionMessageTagPrefix { get; set; }
    /// <summary>Suffix in ticket number.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_sHdSectionMessageTagSuffix"/>
    /// <remarks>Column <c>sHdSectionMessageTagSuffix</c>: nvarchar(255), null.</remarks>
    public virtual string sHdSectionMessageTagSuffix { get; set; }
    /// <summary>URL of the custom form to create a new ticket.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_sHdSectionNewHdTicketUrl"/>
    /// <remarks>Column <c>sHdSectionNewHdTicketUrl</c>: nvarchar(1024), null.</remarks>
    public virtual string sHdSectionNewHdTicketUrl { get; set; }
    /// <summary>Phone number.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_sHdSectionPhone"/>
    /// <remarks>Column <c>sHdSectionPhone</c>: nvarchar(255), null.</remarks>
    public virtual string sHdSectionPhone { get; set; }
    /// <summary>Service short name. For example &quot;Technical Support&quot;.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_sHdSectionShort"/>
    /// <remarks>Column <c>sHdSectionShort</c>: nvarchar(255), null.</remarks>
    public virtual string sHdSectionShort { get; set; }
    /// <summary>
    /// List of optional items that shall be displayed on the portal during the process of editing/viewing the ticket.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSection.html#Alvao_API_Common_Model_Database_tHdSection_sHdSectionUserShowFields"/>
    /// <remarks>Column <c>sHdSectionUserShowFields</c>: nvarchar(1024), null.</remarks>
    public virtual string sHdSectionUserShowFields { get; set; }
}
