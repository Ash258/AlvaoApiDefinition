using AutoMapper.Configuration.Annotations;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Persons in the ALVAO system.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html"/>
[Table("dbo.tPerson")]
public class tPerson {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.TicketRoles.html#fields"/>
    [Flags]
    public enum TicketRoles {
        NoRole = 0,
        SectionRequester = 1,
        SectionSolver = 2,
        SectionMainSolver = 4,
        [Obsolete("Use SectionMainSolver instead.")]
        SectionOperator = 4,
        SectionManager = 8,
        SectionReader = 16,
        TicketSolver = 32,
        TicketApprovalAuthority = 64,
        TicketRequesterOrRequesterManager = 128,
        SectionExceptionalSolver = 256,
        TicketFollower = 1024,
        TicketRequestParticipant = 2048,
        TicketReaderDueToSectionSla = 4096,
        TicketRequestParticipantManager = 8192,
        TicketSolverGroupMember = 16384,
        TicketReaderDueToParentTicket = 32768,
    }

    /// <summary>Application (client) ID in AAD</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_AadAppClientId"/>
    /// <remarks>Column <c>AadAppClientId</c>: nvarchar(255), null.</remarks>
    public virtual string AadAppClientId { get; set; }
    /// <summary>Directory (tenant) ID in AAD</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_AadAppTenantId"/>
    /// <remarks>Column <c>AadAppTenantId</c>: nvarchar(255), null.</remarks>
    public virtual string AadAppTenantId { get; set; }
    /// <summary>Application account</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_App"/>
    /// <remarks>Column <c>App</c>: bit, not null.</remarks>
    public virtual bool App { get; set; }
    /// <summary>User ID in the Azure Active Directory</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_AzureAdObjectId"/>
    /// <remarks>Column <c>AzureAdObjectId</c>: nvarchar(40), null.</remarks>
    public virtual string AzureAdObjectId { get; set; }
    /// <summary>The tenantâs ID Azure Active Directory which the user belongs to.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_AzureAdTenantId"/>
    /// <remarks>Column <c>AzureAdTenantId</c>: int, null. References <see cref="AzureAdTenant"/>.</remarks>
    public virtual int? AzureAdTenantId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_Email2"/>
    /// <remarks>Column <c>Email2</c>: nvarchar(255), null.</remarks>
    public virtual string Email2 { get; set; }
    /// <summary>Date and time when the user was last found during AD import.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_ImportAdLastFound"/>
    /// <remarks>Column <c>ImportAdLastFound</c>: datetime, null.</remarks>
    public virtual DateTime? ImportAdLastFound { get; set; }
    /// <summary>Identifier specifying whether the user is absent. Automatically calculated column.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_IsOutOfOffice"/>
    /// <remarks>Column <c>IsOutOfOffice</c>: bit, not null.</remarks>
    [Computed]
    public virtual bool IsOutOfOffice { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_IsSample"/>
    /// <remarks>Column <c>IsSample</c>: bit, not null.</remarks>
    public virtual bool IsSample { get; set; }
    /// <summary>Starting date and time of absence.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_OutOfOfficeSince"/>
    /// <remarks>Column <c>OutOfOfficeSince</c>: datetime, null.</remarks>
    public virtual DateTime? OutOfOfficeSince { get; set; }
    /// <summary>Ending date and time of absence.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_OutOfOfficeUntil"/>
    /// <remarks>Column <c>OutOfOfficeUntil</c>: datetime, null.</remarks>
    public virtual DateTime? OutOfOfficeUntil { get; set; }
    /// <summary>For user type, see the PersonBehavior table.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_PersonBehaviorId"/>
    /// <remarks>Column <c>PersonBehaviorId</c>: int, not null. References <see cref="PersonBehavior"/>.</remarks>
    public virtual int PersonBehaviorId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_PersonEmail"/>
    [Ignore]
    public string PersonEmail { get; }
    /// <summary>ETag value of portrait in Azure Active Directory</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_PersonPortraitETag"/>
    /// <remarks>Column <c>PersonPortraitETag</c>: nvarchar(1024), null.</remarks>
    public virtual string PersonPortraitETag { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_PersonPortraitHash"/>
    /// <remarks>Column <c>PersonPortraitHash</c>: varchar, null.</remarks>
    public virtual string PersonPortraitHash { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_Phone2"/>
    /// <remarks>Column <c>Phone2</c>: nvarchar(255), null.</remarks>
    public virtual string Phone2 { get; set; }
    /// <summary>For internal use</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_RefreshToken"/>
    /// <remarks>Column <c>RefreshToken</c>: nvarchar(3000), null.</remarks>
    public virtual string RefreshToken { get; set; }
    /// <summary>Username for systems older than Windows 2000</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_SamAccountName"/>
    /// <remarks>Column <c>SamAccountName</c>: nvarchar(255), null.</remarks>
    public virtual string SamAccountName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_TeamsConversationId"/>
    /// <remarks>Column <c>TeamsConversationId</c>: nvarchar(255), null.</remarks>
    public virtual string TeamsConversationId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_TimeZone"/>
    /// <remarks>Column <c>TimeZone</c>: nvarchar(64), null.</remarks>
    public virtual string TimeZone { get; set; }
    /// <summary>Hide in menus</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_bHidden"/>
    /// <remarks>Column <c>bHidden</c>: bit, not null.</remarks>
    public virtual bool bHidden { get; set; }
    /// <summary>Account is disabled</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_bPersonAccountDisabled"/>
    /// <remarks>Column <c>bPersonAccountDisabled</c>: bit, not null.</remarks>
    public virtual bool bPersonAccountDisabled { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_bPersonGuest"/>
    /// <remarks>Column <c>bPersonGuest</c>: bit, not null.</remarks>
    public virtual bool bPersonGuest { get; set; }
    /// <summary>Shared account</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_bPersonShared"/>
    /// <remarks>Column <c>bPersonShared</c>: bit, not null.</remarks>
    public virtual bool bPersonShared { get; set; }
    /// <summary>system user</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_bPersonSystem"/>
    /// <remarks>Column <c>bPersonSystem</c>: bit, not null.</remarks>
    public virtual bool bPersonSystem { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_dPersonAdCreated"/>
    /// <remarks>Column <c>dPersonAdCreated</c>: datetime, null.</remarks>
    public virtual DateTime? dPersonAdCreated { get; set; }
    /// <summary>date on which the user was created</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_dPersonCreated"/>
    /// <remarks>Column <c>dPersonCreated</c>: datetime, null.</remarks>
    public virtual DateTime? dPersonCreated { get; set; }
    /// <summary>date on which the user was removed</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_dPersonRemoved"/>
    /// <remarks>Column <c>dPersonRemoved</c>: datetime, null.</remarks>
    public virtual DateTime? dPersonRemoved { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_iPersonCountryCode"/>
    /// <remarks>Column <c>iPersonCountryCode</c>: int, null.</remarks>
    public virtual int? iPersonCountryCode { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_iPersonId"/>
    /// <remarks>Column <c>iPersonId</c>: int, not null.</remarks>
    [Key]
    public virtual int iPersonId { get; set; }
    /// <summary>
    /// Language number. This is the Microsoft LocaleID. The list of these, for example, can be found here
    /// http://msdn.microsoft.com/en-us/goglobal/bb964664.aspx. The list of similar Locale ID can be found in the
    /// tLocale table
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_iPersonLocaleId"/>
    /// <remarks>Column <c>iPersonLocaleId</c>: int, null.</remarks>
    public virtual int? iPersonLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_liAccountId"/>
    /// <remarks>Column <c>liAccountId</c>: int, null. References <see cref="tAccount"/>.</remarks>
    public virtual int? liAccountId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_liPersonDelegatePersonId"/>
    /// <remarks>Column <c>liPersonDelegatePersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? liPersonDelegatePersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_liPersonManagerPersonId"/>
    /// <remarks>Column <c>liPersonManagerPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? liPersonManagerPersonId { get; set; }
    /// <summary>Other contacts</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_mPersonContact"/>
    /// <remarks>Column <c>mPersonContact</c>: nvarchar(max), null.</remarks>
    public virtual string mPersonContact { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_mPersonNotes"/>
    /// <remarks>Column <c>mPersonNotes</c>: nvarchar(max), null.</remarks>
    public virtual string mPersonNotes { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_oPersonSID"/>
    /// <remarks>Column <c>oPersonSID</c>: image, null.</remarks>
    public virtual byte[] oPersonSID { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sAdDisplayName"/>
    /// <remarks>Column <c>sAdDisplayName</c>: nvarchar(255), null.</remarks>
    public virtual string sAdDisplayName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sFirstName"/>
    /// <remarks>Column <c>sFirstName</c>: nvarchar(255), null.</remarks>
    public virtual string sFirstName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sImportRecordId"/>
    /// <remarks>Column <c>sImportRecordId</c>: nvarchar(255), null.</remarks>
    public virtual string sImportRecordId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sImportSystem"/>
    /// <remarks>Column <c>sImportSystem</c>: nvarchar(255), null.</remarks>
    public virtual string sImportSystem { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sLastName"/>
    /// <remarks>Column <c>sLastName</c>: nvarchar(255), null.</remarks>
    public virtual string sLastName { get; set; }
    /// <summary>displayed username</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPerson"/>
    /// <remarks>Column <c>sPerson</c>: nvarchar(255), null.</remarks>
    public virtual string sPerson { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonAdGuid"/>
    /// <remarks>Column <c>sPersonAdGuid</c>: nvarchar(255), null.</remarks>
    public virtual string sPersonAdGuid { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonAdName"/>
    /// <remarks>Column <c>sPersonAdName</c>: nvarchar(255), null.</remarks>
    public virtual string sPersonAdName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonAdPath"/>
    /// <remarks>Column <c>sPersonAdPath</c>: nvarchar(1024), null.</remarks>
    public virtual string sPersonAdPath { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonCity"/>
    /// <remarks>Column <c>sPersonCity</c>: nvarchar(255), null.</remarks>
    public virtual string sPersonCity { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonCountry"/>
    /// <remarks>Column <c>sPersonCountry</c>: nvarchar(255), null.</remarks>
    public virtual string sPersonCountry { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonCountryAbbr"/>
    /// <remarks>Column <c>sPersonCountryAbbr</c>: nvarchar(2), null.</remarks>
    public virtual string sPersonCountryAbbr { get; set; }
    /// <summary>department</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonDepartment"/>
    /// <remarks>Column <c>sPersonDepartment</c>: nvarchar(255), null.</remarks>
    public virtual string sPersonDepartment { get; set; }
    /// <summary>Email</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonEmail"/>
    /// <remarks>Column <c>sPersonEmail</c>: nvarchar(255), null.</remarks>
    public virtual string sPersonEmail { get; set; }
    /// <summary>User name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonLogin"/>
    /// <remarks>Column <c>sPersonLogin</c>: nvarchar(255), null.</remarks>
    public virtual string sPersonLogin { get; set; }
    /// <summary>mobile phone</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonMobile"/>
    /// <remarks>Column <c>sPersonMobile</c>: nvarchar(255), null.</remarks>
    public virtual string sPersonMobile { get; set; }
    /// <summary>office</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonOffice"/>
    /// <remarks>Column <c>sPersonOffice</c>: nvarchar(255), null.</remarks>
    public virtual string sPersonOffice { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonPersonalNumber"/>
    /// <remarks>Column <c>sPersonPersonalNumber</c>: nvarchar(255), null.</remarks>
    public virtual string sPersonPersonalNumber { get; set; }
    /// <summary>phone</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonPhone"/>
    /// <remarks>Column <c>sPersonPhone</c>: nvarchar(255), null.</remarks>
    public virtual string sPersonPhone { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonPreferredLanguage"/>
    /// <remarks>Column <c>sPersonPreferredLanguage</c>: nvarchar(2), null.</remarks>
    public virtual string sPersonPreferredLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonPswd"/>
    /// <remarks>Column <c>sPersonPswd</c>: nvarchar(255), null.</remarks>
    public virtual string sPersonPswd { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonSID"/>
    /// <remarks>Column <c>sPersonSID</c>: nvarchar(255), null.</remarks>
    public virtual string sPersonSID { get; set; }
    /// <summary>Email for urgent messages</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonUrgentEmail"/>
    /// <remarks>Column <c>sPersonUrgentEmail</c>: nvarchar(255), null.</remarks>
    public virtual string sPersonUrgentEmail { get; set; }
    /// <summary>job</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tPerson.html#Alvao_API_Common_Model_Database_tPerson_sPersonWorkPosition"/>
    /// <remarks>Column <c>sPersonWorkPosition</c>: nvarchar(255), null.</remarks>
    public virtual string sPersonWorkPosition { get; set; }
}
