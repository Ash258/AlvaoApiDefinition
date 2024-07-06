using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Auxiliary view for the language localization of service names and descriptions.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vHdSectionLoc.htm"/>
[TableAttribute("dbo.vHdSectionLoc")]
public class vHdSectionLoc
{
    public virtual bool AllowSkipCustomForm { get; set; }
    public virtual bool bHdSectionDefault { get; set; }
    public virtual bool bHdSectionFolder { get; set; }
    public virtual bool bHdSectionHdTicketUserRead { get; set; }
    public virtual bool bHdSectionImapSsl { get; set; }
    public virtual bool bHdSectionMessageMarkRead { get; set; }
    public virtual bool bHdSectionMessageReadOnlyUnread { get; set; }
    public virtual bool bHdSectionMessageRemove { get; set; }
    public virtual bool CreateNewFollowingRequest { get; set; }
    public virtual int? CreateNewFollowingRequestToSection { get; set; }
    public virtual string CustomFeedbackUrl { get; set; }
    public virtual int? DefaultLanguageId { get; set; }
    public virtual int? DefaultTicketTemplateId { get; set; }
    public virtual string DefaultTimeZone { get; set; }
    public virtual DateTime? dHdSectionRemoved { get; set; }
    public virtual bool ForceUseSolverLicense { get; set; }
    public virtual bool HomePage { get; set; }
    public virtual string IconName { get; set; }
    /// <summary>ID of record with service.</summary>
    public virtual int iHdSectionId { get; set; }
    /// <summary>LCID of the language into which the localization is performed</summary>
    public virtual int iHdSectionLocaleId { get; set; }
    public virtual int? ImapPort { get; set; }
    public virtual string Keywords { get; set; }
    public virtual int LibraryIconId { get; set; }
    public virtual int? liHdSectionBuildingId { get; set; }
    public virtual int? liHdSectionParentHdSectionId { get; set; }
    public virtual string LocalizedKeywords { get; set; }
    /// <summary>Localized full service name.</summary>
    public virtual string LocalizedSection { get; set; }
    /// <summary>Localized service description.</summary>
    public virtual string LocalizedSectionDesc { get; set; }
    /// <summary>Localized short service name.</summary>
    public virtual string LocalizedSectionShort { get; set; }
    /// <summary>Localized service description.</summary>
    public virtual string mHdSectionDesc { get; set; }
    public virtual double? nHdSectionOrder { get; set; }
    public virtual double? nHdSectionUserReopenDays { get; set; }
    /// <summary>Localized full service name.</summary>
    public virtual string sHdSection { get; set; }
    public virtual string sHdSectionEmail { get; set; }
    public virtual string sHdSectionHdTicketCustomWorkflowUrl { get; set; }
    public virtual string sHdSectionImapServer { get; set; }
    public virtual string sHdSectionMailboxLogin { get; set; }
    public virtual string sHdSectionMailboxPassword { get; set; }
    public virtual string sHdSectionMessageFolder { get; set; }
    public virtual string sHdSectionMessageTagPrefix { get; set; }
    public virtual string sHdSectionMessageTagSuffix { get; set; }
    public virtual string sHdSectionNewHdTicketUrl { get; set; }
    public virtual string sHdSectionPhone { get; set; }
    /// <summary>Localized short service name.</summary>
    public virtual string sHdSectionShort { get; set; }
    public virtual string sHdSectionUserShowFields { get; set; }
    public virtual bool ShowInServiceCatalog { get; set; }
    public virtual int? TargetHdSectionId { get; set; }
    public virtual int TicketTypeId { get; set; }
    public virtual int? TileColor { get; set; }
    public virtual int TileType { get; set; }
    public virtual bool UseFeedback { get; set; }
    /// <summary>Managers can read the tickets of their subordinates.</summary>
    public virtual bool UserManagerCanReadTickets { get; set; }

    public vHdSectionLoc() { }
}
