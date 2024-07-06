using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Persons in the ALVAO system.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tPerson.htm"/>
[TableAttribute("dbo.tPerson")]
public class tPerson
{
    [FlagsAttribute]
    public enum TicketRoles
    {
        NoRole = 0,
        SectionRequester = 1,
        SectionSolver = 2,
        SectionMainSolver = 4,
        SectionOperator = 4,
        SectionManager = 8,
        SectionReader = 16,
        TicketSolver = 32,
        TicketApprovalAuthority = 64,
        TicketRequesterOrRequesterManager = 128,
        SectionExceptionalSolver = 256,
        TicketFollower = 1_024,
        TicketRequestParticipant = 2_048,
    }


    /// <summary>Application (client) ID in AAD</summary>
    public virtual string AadAppClientId { get; set; }
    /// <summary>Directory (tenant) ID in AAD</summary>
    public virtual string AadAppTenantId { get; set; }
    /// <summary>Application account</summary>
    public virtual bool App { get; set; }
    /// <summary>User ID in the Azure Active Directory</summary>
    public virtual string AzureAdObjectId { get; set; }
    /// <summary>The tenant’s ID Azure Active Directory which the user belongs to.</summary>
    public virtual int? AzureAdTenantId { get; set; }
    /// <summary>Hide in menus</summary>
    public virtual bool bHidden { get; set; }
    /// <summary>Account is disabled</summary>
    public virtual bool bPersonAccountDisabled { get; set; }
    public virtual bool bPersonGuest { get; set; }
    /// <summary>Shared account</summary>
    public virtual bool bPersonShared { get; set; }
    /// <summary>system user</summary>
    public virtual bool bPersonSystem { get; set; }
    public virtual DateTime? dPersonAdCreated { get; set; }
    /// <summary>date on which the user was created</summary>
    public virtual DateTime? dPersonCreated { get; set; }
    /// <summary>date on which the user was removed</summary>
    public virtual DateTime? dPersonRemoved { get; set; }
    public virtual string Email2 { get; set; }
    /// <summary>Date and time when the user was last found during AD import.</summary>
    public virtual DateTime? ImportAdLastFound { get; set; }
    public virtual int? iPersonCountryCode { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int iPersonId { get; set; }
    /// <summary>Language number. This is the Microsoft LocaleID. The list of these, for example, can be found here http://msdn.microsoft.com/en-us/goglobal/bb964664.aspx. The list of similar Locale ID can be found in the tLocale table</summary>
    public virtual int? iPersonLocaleId { get; set; }
    /// <summary>Identifier specifying whether the user is absent. Automatically calculated column.</summary>
    [ComputedAttribute]
    public virtual bool IsOutOfOffice { get; set; }
    public virtual int? liAccountId { get; set; }
    public virtual int? liPersonDelegatePersonId { get; set; }
    public virtual int? liPersonManagerPersonId { get; set; }
    /// <summary>Other contacts</summary>
    public virtual string mPersonContact { get; set; }
    public virtual string mPersonNotes { get; set; }
    public virtual byte[] oPersonSID { get; set; }
    /// <summary>Starting date and time of absence.</summary>
    public virtual DateTime? OutOfOfficeSince { get; set; }
    /// <summary>Ending date and time of absence.</summary>
    public virtual DateTime? OutOfOfficeUntil { get; set; }
    /// <summary>For user type, see the PersonBehavior table.</summary>
    public virtual int PersonBehaviorId { get; set; }
    public string PersonEmail { get; }
    public virtual byte[] PersonPortrait { get; set; }
    /// <summary>ETag value of portrait in Azure Active Directory</summary>
    public virtual string PersonPortraitETag { get; set; }
    public virtual string PersonPortraitHash { get; set; }
    public virtual string Phone2 { get; set; }
    /// <summary>For internal use</summary>
    public virtual string RefreshToken { get; set; }
    public virtual string sAdDisplayName { get; set; }
    /// <summary>Username for systems older than Windows 2000</summary>
    public virtual string SamAccountName { get; set; }
    public virtual string sFirstName { get; set; }
    public virtual string sImportRecordId { get; set; }
    public virtual string sImportSystem { get; set; }
    public virtual string sLastName { get; set; }
    /// <summary>displayed username</summary>
    public virtual string sPerson { get; set; }
    public virtual string sPersonAdGuid { get; set; }
    public virtual string sPersonAdName { get; set; }
    public virtual string sPersonAdPath { get; set; }
    public virtual string sPersonCity { get; set; }
    public virtual string sPersonCountry { get; set; }
    public virtual string sPersonCountryAbbr { get; set; }
    /// <summary>department</summary>
    public virtual string sPersonDepartment { get; set; }
    /// <summary>e-mail</summary>
    public virtual string sPersonEmail { get; set; }
    /// <summary>User name</summary>
    public virtual string sPersonLogin { get; set; }
    /// <summary>mobile phone</summary>
    public virtual string sPersonMobile { get; set; }
    /// <summary>office</summary>
    public virtual string sPersonOffice { get; set; }
    public virtual string sPersonPersonalNumber { get; set; }
    /// <summary>phone</summary>
    public virtual string sPersonPhone { get; set; }
    public virtual string sPersonPreferredLanguage { get; set; }
    public virtual string sPersonPswd { get; set; }
    public virtual string sPersonSID { get; set; }
    /// <summary>E-mail for urgent messages</summary>
    public virtual string sPersonUrgentEmail { get; set; }
    /// <summary>job</summary>
    public virtual string sPersonWorkPosition { get; set; }
    public virtual string TeamsConversationId { get; set; }
    public virtual string TimeZone { get; set; }

    public tPerson() { }
}
