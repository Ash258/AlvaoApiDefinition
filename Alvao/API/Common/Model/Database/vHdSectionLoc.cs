using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Auxiliary view for the language localization of service names and descriptions.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vHdSectionLoc.htm"/>
[TableAttribute("dbo.vHdSectionLoc")]
public class vHdSectionLoc
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_AllowSkipCustomForm.htm"/>
    public virtual bool AllowSkipCustomForm { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_bHdSectionDefault.htm"/>
    public virtual bool bHdSectionDefault { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_bHdSectionFolder.htm"/>
    public virtual bool bHdSectionFolder { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_bHdSectionHdTicketUserRead.htm"/>
    public virtual bool bHdSectionHdTicketUserRead { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_bHdSectionImapSsl.htm"/>
    public virtual bool bHdSectionImapSsl { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_bHdSectionMessageMarkRead.htm"/>
    public virtual bool bHdSectionMessageMarkRead { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_bHdSectionMessageReadOnlyUnread.htm"/>
    public virtual bool bHdSectionMessageReadOnlyUnread { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_bHdSectionMessageRemove.htm"/>
    public virtual bool bHdSectionMessageRemove { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_CreateNewFollowingRequest.htm"/>
    public virtual bool CreateNewFollowingRequest { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_CreateNewFollowingRequestToSection.htm"/>
    public virtual int? CreateNewFollowingRequestToSection { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_CustomFeedbackUrl.htm"/>
    public virtual string CustomFeedbackUrl { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_DefaultLanguageId.htm"/>
    public virtual int? DefaultLanguageId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_DefaultTicketTemplateId.htm"/>
    public virtual int? DefaultTicketTemplateId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_DefaultTimeZone.htm"/>
    public virtual string DefaultTimeZone { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_dHdSectionRemoved.htm"/>
    public virtual DateTime? dHdSectionRemoved { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_ForceUseSolverLicense.htm"/>
    public virtual bool ForceUseSolverLicense { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_HomePage.htm"/>
    public virtual bool HomePage { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_IconName.htm"/>
    public virtual string IconName { get; set; }
    /// <summary>ID of record with service.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_iHdSectionId.htm"/>
    public virtual int iHdSectionId { get; set; }
    /// <summary>LCID of the language into which the localization is performed</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_iHdSectionLocaleId.htm"/>
    public virtual int iHdSectionLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_ImapPort.htm"/>
    public virtual int? ImapPort { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_Keywords.htm"/>
    public virtual string Keywords { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_LibraryIconId.htm"/>
    public virtual int LibraryIconId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_liHdSectionBuildingId.htm"/>
    public virtual int? liHdSectionBuildingId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_liHdSectionParentHdSectionId.htm"/>
    public virtual int? liHdSectionParentHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_LocalizedKeywords.htm"/>
    public virtual string LocalizedKeywords { get; set; }
    /// <summary>Localized full service name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_LocalizedSection.htm"/>
    public virtual string LocalizedSection { get; set; }
    /// <summary>Localized service description.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_LocalizedSectionDesc.htm"/>
    public virtual string LocalizedSectionDesc { get; set; }
    /// <summary>Localized short service name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_LocalizedSectionShort.htm"/>
    public virtual string LocalizedSectionShort { get; set; }
    /// <summary>Localized service description.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_mHdSectionDesc.htm"/>
    public virtual string mHdSectionDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_nHdSectionOrder.htm"/>
    public virtual double? nHdSectionOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_nHdSectionUserReopenDays.htm"/>
    public virtual double? nHdSectionUserReopenDays { get; set; }
    /// <summary>Localized full service name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSection.htm"/>
    public virtual string sHdSection { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSectionEmail.htm"/>
    public virtual string sHdSectionEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSectionHdTicketCustomWorkflowUrl.htm"/>
    public virtual string sHdSectionHdTicketCustomWorkflowUrl { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSectionImapServer.htm"/>
    public virtual string sHdSectionImapServer { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSectionMailboxLogin.htm"/>
    public virtual string sHdSectionMailboxLogin { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSectionMailboxPassword.htm"/>
    public virtual string sHdSectionMailboxPassword { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSectionMessageFolder.htm"/>
    public virtual string sHdSectionMessageFolder { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSectionMessageTagPrefix.htm"/>
    public virtual string sHdSectionMessageTagPrefix { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSectionMessageTagSuffix.htm"/>
    public virtual string sHdSectionMessageTagSuffix { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSectionNewHdTicketUrl.htm"/>
    public virtual string sHdSectionNewHdTicketUrl { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSectionPhone.htm"/>
    public virtual string sHdSectionPhone { get; set; }
    /// <summary>Localized short service name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSectionShort.htm"/>
    public virtual string sHdSectionShort { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSectionUserShowFields.htm"/>
    public virtual string sHdSectionUserShowFields { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_ShowInServiceCatalog.htm"/>
    public virtual bool ShowInServiceCatalog { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_TargetHdSectionId.htm"/>
    public virtual int? TargetHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_TicketTypeId.htm"/>
    public virtual int TicketTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_TileColor.htm"/>
    public virtual int? TileColor { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_TileType.htm"/>
    public virtual int TileType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_UseFeedback.htm"/>
    public virtual bool UseFeedback { get; set; }
    /// <summary>Managers can read the tickets of their subordinates.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionLoc_UserManagerCanReadTickets.htm"/>
    public virtual bool UserManagerCanReadTickets { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vHdSectionLoc__ctor.htm"/>
    public vHdSectionLoc() { }
}
