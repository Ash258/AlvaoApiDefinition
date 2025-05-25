using AutoMapper.Configuration.Annotations;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Persons in the ALVAO system.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html"/>
[Table("dbo.tPerson")]
public class tPerson {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.TicketRoles.html#fields"/>
    [Flags]
    public enum TicketRoles {
        NoRole = 0,
        SectionExceptionalSolver = 256,
        SectionMainSolver = 4,
        SectionManager = 8,
        [Obsolete("Use SectionMainSolver instead.")]
        SectionOperator = 4,
        SectionReader = 16,
        SectionRequester = 1,
        SectionSolver = 2,
        TicketApprovalAuthority = 64,
        TicketFollower = 1024,
        TicketRequestParticipant = 2048,
        TicketRequesterOrRequesterManager = 128,
        TicketSolver = 32,
    }
    /// <summary>Application (client) ID in AAD</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_AadAppClientId"/>
    public virtual string AadAppClientId { get; set; }
    /// <summary>Directory (tenant) ID in AAD</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_AadAppTenantId"/>
    public virtual string AadAppTenantId { get; set; }
    /// <summary>Application account</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_App"/>
    public virtual bool App { get; set; }
    /// <summary>User ID in the Azure Active Directory</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_AzureAdObjectId"/>
    public virtual string AzureAdObjectId { get; set; }
    /// <summary>The tenantâs ID Azure Active Directory which the user belongs to.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_AzureAdTenantId"/>
    public virtual int? AzureAdTenantId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_Email2"/>
    public virtual string Email2 { get; set; }
    /// <summary>Date and time when the user was last found during AD import.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_ImportAdLastFound"/>
    public virtual DateTime? ImportAdLastFound { get; set; }
    /// <summary>Identifier specifying whether the user is absent. Automatically calculated column.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_IsOutOfOffice"/>
    [Computed]
    public virtual bool IsOutOfOffice { get; set; }
    /// <summary>Starting date and time of absence.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_OutOfOfficeSince"/>
    public virtual DateTime? OutOfOfficeSince { get; set; }
    /// <summary>Ending date and time of absence.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_OutOfOfficeUntil"/>
    public virtual DateTime? OutOfOfficeUntil { get; set; }
    /// <summary>For user type, see the PersonBehavior table.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_PersonBehaviorId"/>
    public virtual int PersonBehaviorId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_PersonEmail"/>
    [Ignore]
    public string PersonEmail { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_PersonPortrait"/>
    public virtual byte[] PersonPortrait { get; set; }
    /// <summary>ETag value of portrait in Azure Active Directory</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_PersonPortraitETag"/>
    public virtual string PersonPortraitETag { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_PersonPortraitHash"/>
    public virtual string PersonPortraitHash { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_Phone2"/>
    public virtual string Phone2 { get; set; }
    /// <summary>For internal use</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_RefreshToken"/>
    public virtual string RefreshToken { get; set; }
    /// <summary>Username for systems older than Windows 2000</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_SamAccountName"/>
    public virtual string SamAccountName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_TeamsConversationId"/>
    public virtual string TeamsConversationId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_TimeZone"/>
    public virtual string TimeZone { get; set; }
    /// <summary>Hide in menus</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_bHidden"/>
    public virtual bool bHidden { get; set; }
    /// <summary>Account is disabled</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_bPersonAccountDisabled"/>
    public virtual bool bPersonAccountDisabled { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_bPersonGuest"/>
    public virtual bool bPersonGuest { get; set; }
    /// <summary>Shared account</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_bPersonShared"/>
    public virtual bool bPersonShared { get; set; }
    /// <summary>system user</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_bPersonSystem"/>
    public virtual bool bPersonSystem { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_dPersonAdCreated"/>
    public virtual DateTime? dPersonAdCreated { get; set; }
    /// <summary>date on which the user was created</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_dPersonCreated"/>
    public virtual DateTime? dPersonCreated { get; set; }
    /// <summary>date on which the user was removed</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_dPersonRemoved"/>
    public virtual DateTime? dPersonRemoved { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_iPersonCountryCode"/>
    public virtual int? iPersonCountryCode { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_iPersonId"/>
    [Key]
    public virtual int iPersonId { get; set; }
    /// <summary>Language number. This is the Microsoft LocaleID. The list of these, for example, can be found here http://msdn.microsoft.com/en-us/goglobal/bb964664.aspx. The list of similar Locale ID can be found in the tLocale table</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_iPersonLocaleId"/>
    public virtual int? iPersonLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_liAccountId"/>
    public virtual int? liAccountId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_liPersonDelegatePersonId"/>
    public virtual int? liPersonDelegatePersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_liPersonManagerPersonId"/>
    public virtual int? liPersonManagerPersonId { get; set; }
    /// <summary>Other contacts</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_mPersonContact"/>
    public virtual string mPersonContact { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_mPersonNotes"/>
    public virtual string mPersonNotes { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_oPersonSID"/>
    public virtual byte[] oPersonSID { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sAdDisplayName"/>
    public virtual string sAdDisplayName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sFirstName"/>
    public virtual string sFirstName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sImportRecordId"/>
    public virtual string sImportRecordId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sImportSystem"/>
    public virtual string sImportSystem { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sLastName"/>
    public virtual string sLastName { get; set; }
    /// <summary>displayed username</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPerson"/>
    public virtual string sPerson { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonAdGuid"/>
    public virtual string sPersonAdGuid { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonAdName"/>
    public virtual string sPersonAdName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonAdPath"/>
    public virtual string sPersonAdPath { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonCity"/>
    public virtual string sPersonCity { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonCountry"/>
    public virtual string sPersonCountry { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonCountryAbbr"/>
    public virtual string sPersonCountryAbbr { get; set; }
    /// <summary>department</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonDepartment"/>
    public virtual string sPersonDepartment { get; set; }
    /// <summary>e-mail</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonEmail"/>
    public virtual string sPersonEmail { get; set; }
    /// <summary>User name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonLogin"/>
    public virtual string sPersonLogin { get; set; }
    /// <summary>mobile phone</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonMobile"/>
    public virtual string sPersonMobile { get; set; }
    /// <summary>office</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonOffice"/>
    public virtual string sPersonOffice { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonPersonalNumber"/>
    public virtual string sPersonPersonalNumber { get; set; }
    /// <summary>phone</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonPhone"/>
    public virtual string sPersonPhone { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonPreferredLanguage"/>
    public virtual string sPersonPreferredLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonPswd"/>
    public virtual string sPersonPswd { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonSID"/>
    public virtual string sPersonSID { get; set; }
    /// <summary>E-mail for urgent messages</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonUrgentEmail"/>
    public virtual string sPersonUrgentEmail { get; set; }
    /// <summary>job</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonWorkPosition"/>
    public virtual string sPersonWorkPosition { get; set; }
}
