using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Auxiliary view for the language localization of service names and descriptions.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html"/>
[Table("dbo.vHdSectionLoc")]
public class vHdSectionLoc {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_AllowSkipCustomForm"/>
    public virtual bool AllowSkipCustomForm { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_CreateNewFollowingRequest"/>
    public virtual bool CreateNewFollowingRequest { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_CreateNewFollowingRequestToSection"/>
    public virtual int? CreateNewFollowingRequestToSection { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_CustomFeedbackUrl"/>
    public virtual string CustomFeedbackUrl { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_DefaultLanguageId"/>
    public virtual int? DefaultLanguageId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_DefaultTicketTemplateId"/>
    public virtual int? DefaultTicketTemplateId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_DefaultTimeZone"/>
    public virtual string DefaultTimeZone { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_ForceUseSolverLicense"/>
    public virtual bool ForceUseSolverLicense { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_HomePage"/>
    public virtual bool HomePage { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_IconName"/>
    public virtual string IconName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_ImapPort"/>
    public virtual int? ImapPort { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_Keywords"/>
    public virtual string Keywords { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_LibraryIconId"/>
    public virtual int LibraryIconId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_LocalizedKeywords"/>
    public virtual string LocalizedKeywords { get; set; }
    /// <summary>Localized full service name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_LocalizedSection"/>
    public virtual string LocalizedSection { get; set; }
    /// <summary>Localized service description.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_LocalizedSectionDesc"/>
    public virtual string LocalizedSectionDesc { get; set; }
    /// <summary>Localized short service name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_LocalizedSectionShort"/>
    public virtual string LocalizedSectionShort { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_ShowInServiceCatalog"/>
    public virtual bool ShowInServiceCatalog { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_TargetHdSectionId"/>
    public virtual int? TargetHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_TicketTypeId"/>
    public virtual int TicketTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_TileColor"/>
    public virtual int? TileColor { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_TileType"/>
    public virtual int TileType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_UseFeedback"/>
    public virtual bool UseFeedback { get; set; }
    /// <summary>Managers can read the tickets of their reports.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_UserManagerCanReadTickets"/>
    public virtual bool UserManagerCanReadTickets { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_bHdSectionDefault"/>
    public virtual bool bHdSectionDefault { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_bHdSectionFolder"/>
    public virtual bool bHdSectionFolder { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_bHdSectionHdTicketUserRead"/>
    public virtual bool bHdSectionHdTicketUserRead { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_bHdSectionImapSsl"/>
    public virtual bool bHdSectionImapSsl { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_bHdSectionMessageMarkRead"/>
    public virtual bool bHdSectionMessageMarkRead { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_bHdSectionMessageReadOnlyUnread"/>
    public virtual bool bHdSectionMessageReadOnlyUnread { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_bHdSectionMessageRemove"/>
    public virtual bool bHdSectionMessageRemove { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_dHdSectionRemoved"/>
    public virtual DateTime? dHdSectionRemoved { get; set; }
    /// <summary>ID of record with service.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_iHdSectionId"/>
    public virtual int iHdSectionId { get; set; }
    /// <summary>LCID of the language into which the localization is performed</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_iHdSectionLocaleId"/>
    public virtual int iHdSectionLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_liHdSectionParentHdSectionId"/>
    public virtual int? liHdSectionParentHdSectionId { get; set; }
    /// <summary>Localized service description.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_mHdSectionDesc"/>
    public virtual string mHdSectionDesc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_nHdSectionOrder"/>
    public virtual double? nHdSectionOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_nHdSectionUserReopenDays"/>
    public virtual double? nHdSectionUserReopenDays { get; set; }
    /// <summary>Localized full service name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSection"/>
    public virtual string sHdSection { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSectionEmail"/>
    public virtual string sHdSectionEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSectionHdTicketCustomWorkflowUrl"/>
    public virtual string sHdSectionHdTicketCustomWorkflowUrl { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSectionImapServer"/>
    public virtual string sHdSectionImapServer { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSectionMailboxLogin"/>
    public virtual string sHdSectionMailboxLogin { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSectionMailboxPassword"/>
    public virtual string sHdSectionMailboxPassword { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSectionMessageFolder"/>
    public virtual string sHdSectionMessageFolder { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSectionMessageTagPrefix"/>
    public virtual string sHdSectionMessageTagPrefix { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSectionMessageTagSuffix"/>
    public virtual string sHdSectionMessageTagSuffix { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSectionNewHdTicketUrl"/>
    public virtual string sHdSectionNewHdTicketUrl { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSectionPhone"/>
    public virtual string sHdSectionPhone { get; set; }
    /// <summary>Localized short service name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSectionShort"/>
    public virtual string sHdSectionShort { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionLoc.html#Alvao_API_Common_Model_Database_vHdSectionLoc_sHdSectionUserShowFields"/>
    public virtual string sHdSectionUserShowFields { get; set; }
}
