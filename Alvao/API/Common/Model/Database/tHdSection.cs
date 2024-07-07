using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>ALVAO Service Desk product services.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tHdSection.htm"/>
[TableAttribute("dbo.tHdSection")]
public class tHdSection
{
    /// <summary>If it is 1 and a custom form is set up on the service to submit a new ticket, operators can submit the ticket in the standard way.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_AllowSkipCustomForm.htm"/>
    public virtual bool AllowSkipCustomForm { get; set; }
    /// <summary>Flaf to determine whether the service is default.1 - service is default0 - service is not defaultNULL - service is not default.Only one service can be default.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_bHdSectionDefault.htm"/>
    public virtual bool bHdSectionDefault { get; set; }
    /// <summary>If the service is only a folder containing other services and the user cannot insert tickets, the value is 1. The button for creating a ticket for this service is not displayed in the portal.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_bHdSectionFolder.htm"/>
    public virtual bool bHdSectionFolder { get; set; }
    /// <summary>If this is 1, the user can view the tickets of other users from the same organization in this service.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_bHdSectionHdTicketUserRead.htm"/>
    public virtual bool bHdSectionHdTicketUserRead { get; set; }
    /// <summary>If the value is 1, SSL will be used for connecting to the IMAP server.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_bHdSectionImapSsl.htm"/>
    public virtual bool bHdSectionImapSsl { get; set; }
    /// <summary>If the value is 1, messages are marked as read once the message is loaded.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_bHdSectionMessageMarkRead.htm"/>
    public virtual bool bHdSectionMessageMarkRead { get; set; }
    /// <summary>If the value is 1, only unread messages are read.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_bHdSectionMessageReadOnlyUnread.htm"/>
    public virtual bool bHdSectionMessageReadOnlyUnread { get; set; }
    /// <summary>If the value is 1, processed messages are removed from the server.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_bHdSectionMessageRemove.htm"/>
    public virtual bool bHdSectionMessageRemove { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_CreateNewFollowingRequest.htm"/>
    public virtual bool CreateNewFollowingRequest { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_CreateNewFollowingRequestToSection.htm"/>
    public virtual int? CreateNewFollowingRequestToSection { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_CustomFeedbackUrl.htm"/>
    public virtual string CustomFeedbackUrl { get; set; }
    /// <summary>Service local language.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_DefaultLanguageId.htm"/>
    public virtual int? DefaultLanguageId { get; set; }
    /// <summary>Default ticket template.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_DefaultTicketTemplateId.htm"/>
    public virtual int? DefaultTicketTemplateId { get; set; }
    /// <summary>Service local time zone.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_DefaultTimeZone.htm"/>
    public virtual string DefaultTimeZone { get; set; }
    /// <summary>Time at which the service was removed. The service is not removed for NULL.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_dHdSectionRemoved.htm"/>
    public virtual DateTime? dHdSectionRemoved { get; set; }
    /// <summary>Application ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_EwsClientId.htm"/>
    public virtual string EwsClientId { get; set; }
    /// <summary>Secret client code.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_EwsClientSecret.htm"/>
    public virtual string EwsClientSecret { get; set; }
    /// <summary>Name of Exchange server.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_EwsServerName.htm"/>
    public virtual string EwsServerName { get; set; }
    /// <summary>Folder ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_EwsTenantId.htm"/>
    public virtual string EwsTenantId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_ForceUseSolverLicense.htm"/>
    public virtual bool ForceUseSolverLicense { get; set; }
    /// <summary>Service flag for setting the tiles on the home page.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_HomePage.htm"/>
    public virtual bool HomePage { get; set; }
    /// <summary>If the service icon was not loaded from the disk when upgrading to A10.2, this column displays "Upload failed &lt;icon name&gt;". This value in the service table overloads the display name of the icon from the icon library. Otherwise, this column is NULL.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_IconName.htm"/>
    public virtual string IconName { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_iHdSectionId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int iHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_ImapPort.htm"/>
    public virtual int? ImapPort { get; set; }
    /// <summary>Service keywords.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_Keywords.htm"/>
    public virtual string Keywords { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_LibraryIconId.htm"/>
    public virtual int LibraryIconId { get; set; }
    /// <summary>Link to building.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_liHdSectionBuildingId.htm"/>
    public virtual int? liHdSectionBuildingId { get; set; }
    /// <summary>Link to ancestor in tree.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_liHdSectionParentHdSectionId.htm"/>
    public virtual int? liHdSectionParentHdSectionId { get; set; }
    /// <summary>Description of service.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_mHdSectionDesc.htm"/>
    public virtual string mHdSectionDesc { get; set; }
    /// <summary>Order in which services are displayed.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_nHdSectionOrder.htm"/>
    public virtual double? nHdSectionOrder { get; set; }
    /// <summary>The number of days when the requester may reopen their ticket until the ticket is resolved.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_nHdSectionUserReopenDays.htm"/>
    public virtual double? nHdSectionUserReopenDays { get; set; }
    /// <summary>Full service name, including location. For example "Helpdesk/Technical Support".</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_sHdSection.htm"/>
    public virtual string sHdSection { get; set; }
    /// <summary>Service email.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_sHdSectionEmail.htm"/>
    public virtual string sHdSectionEmail { get; set; }
    /// <summary>Custom workflow URL.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_sHdSectionHdTicketCustomWorkflowUrl.htm"/>
    public virtual string sHdSectionHdTicketCustomWorkflowUrl { get; set; }
    /// <summary>Address of IMAP server for loading messages.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_sHdSectionImapServer.htm"/>
    public virtual string sHdSectionImapServer { get; set; }
    /// <summary>Username for loading messages.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_sHdSectionMailboxLogin.htm"/>
    public virtual string sHdSectionMailboxLogin { get; set; }
    /// <summary>Password for loading messages.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_sHdSectionMailboxPassword.htm"/>
    public virtual string sHdSectionMailboxPassword { get; set; }
    /// <summary>Target folder for moving loaded messages.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_sHdSectionMessageFolder.htm"/>
    public virtual string sHdSectionMessageFolder { get; set; }
    /// <summary>Prefix in ticket number.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_sHdSectionMessageTagPrefix.htm"/>
    public virtual string sHdSectionMessageTagPrefix { get; set; }
    /// <summary>Suffix in ticket number.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_sHdSectionMessageTagSuffix.htm"/>
    public virtual string sHdSectionMessageTagSuffix { get; set; }
    /// <summary>URL of the custom form to create a new ticket.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_sHdSectionNewHdTicketUrl.htm"/>
    public virtual string sHdSectionNewHdTicketUrl { get; set; }
    /// <summary>Phone number.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_sHdSectionPhone.htm"/>
    public virtual string sHdSectionPhone { get; set; }
    /// <summary>Service short name. For example "Technical Support".</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_sHdSectionShort.htm"/>
    public virtual string sHdSectionShort { get; set; }
    /// <summary>List of optional items that shall be displayed on the portal during the process of editing/viewing the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_sHdSectionUserShowFields.htm"/>
    public virtual string sHdSectionUserShowFields { get; set; }
    /// <summary>Column for the "View in the Service catalog" option.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_ShowInServiceCatalog.htm"/>
    public virtual bool ShowInServiceCatalog { get; set; }
    /// <summary>Id of the service (tHdSection.iHdSectionId) from which this service inherits SLA assignments. If this service doesn’t inherit SLA assignments, this column contains the same value as the iHdSectionId column. If this record represents a service shortcut this column contains the same value as the TargetHdSectionId column or id of the service the target service inherits SLA assignments from.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_SlaRightsSectionId.htm"/>
    public virtual int SlaRightsSectionId { get; set; }
    /// <summary>Target service of the service shortcut.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_TargetHdSectionId.htm"/>
    public virtual int? TargetHdSectionId { get; set; }
    /// <summary>Ticket name template.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_TicketNameTemplate.htm"/>
    public virtual string TicketNameTemplate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_TicketTypeId.htm"/>
    public virtual int TicketTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_TileColor.htm"/>
    public virtual int? TileColor { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_TileType.htm"/>
    public virtual int TileType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_UseFeedback.htm"/>
    public virtual bool UseFeedback { get; set; }
    /// <summary>Managers can read the tickets of their subordinates.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSection_UserManagerCanReadTickets.htm"/>
    public virtual bool UserManagerCanReadTickets { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tHdSection__ctor.htm"/>
    public tHdSection() { }
}
