using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Persons in the ALVAO system.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tPerson.htm"/>
[TableAttribute("dbo.tPerson")]
public class tPerson
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tPerson_TicketRoles.htm"/>
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
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_AadAppClientId.htm"/>
    public virtual string AadAppClientId { get; set; }
    /// <summary>Directory (tenant) ID in AAD</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_AadAppTenantId.htm"/>
    public virtual string AadAppTenantId { get; set; }
    /// <summary>Application account</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_App.htm"/>
    public virtual bool App { get; set; }
    /// <summary>User ID in the Azure Active Directory</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_AzureAdObjectId.htm"/>
    public virtual string AzureAdObjectId { get; set; }
    /// <summary>The tenant’s ID Azure Active Directory which the user belongs to.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_AzureAdTenantId.htm"/>
    public virtual int? AzureAdTenantId { get; set; }
    /// <summary>Hide in menus</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_bHidden.htm"/>
    public virtual bool bHidden { get; set; }
    /// <summary>Account is disabled</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_bPersonAccountDisabled.htm"/>
    public virtual bool bPersonAccountDisabled { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_bPersonGuest.htm"/>
    public virtual bool bPersonGuest { get; set; }
    /// <summary>Shared account</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_bPersonShared.htm"/>
    public virtual bool bPersonShared { get; set; }
    /// <summary>system user</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_bPersonSystem.htm"/>
    public virtual bool bPersonSystem { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_dPersonAdCreated.htm"/>
    public virtual DateTime? dPersonAdCreated { get; set; }
    /// <summary>date on which the user was created</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_dPersonCreated.htm"/>
    public virtual DateTime? dPersonCreated { get; set; }
    /// <summary>date on which the user was removed</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_dPersonRemoved.htm"/>
    public virtual DateTime? dPersonRemoved { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_Email2.htm"/>
    public virtual string Email2 { get; set; }
    /// <summary>Date and time when the user was last found during AD import.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_ImportAdLastFound.htm"/>
    public virtual DateTime? ImportAdLastFound { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_iPersonCountryCode.htm"/>
    public virtual int? iPersonCountryCode { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_iPersonId.htm"/>
    [KeyAttribute]
    public virtual int iPersonId { get; set; }
    /// <summary>Language number. This is the Microsoft LocaleID. The list of these, for example, can be found here http://msdn.microsoft.com/en-us/goglobal/bb964664.aspx. The list of similar Locale ID can be found in the tLocale table</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_iPersonLocaleId.htm"/>
    public virtual int? iPersonLocaleId { get; set; }
    /// <summary>Identifier specifying whether the user is absent. Automatically calculated column.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_IsOutOfOffice.htm"/>
    [ComputedAttribute]
    public virtual bool IsOutOfOffice { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_liAccountId.htm"/>
    public virtual int? liAccountId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_liPersonDelegatePersonId.htm"/>
    public virtual int? liPersonDelegatePersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_liPersonManagerPersonId.htm"/>
    public virtual int? liPersonManagerPersonId { get; set; }
    /// <summary>Other contacts</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_mPersonContact.htm"/>
    public virtual string mPersonContact { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_mPersonNotes.htm"/>
    public virtual string mPersonNotes { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_oPersonSID.htm"/>
    public virtual byte[] oPersonSID { get; set; }
    /// <summary>Starting date and time of absence.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_OutOfOfficeSince.htm"/>
    public virtual DateTime? OutOfOfficeSince { get; set; }
    /// <summary>Ending date and time of absence.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_OutOfOfficeUntil.htm"/>
    public virtual DateTime? OutOfOfficeUntil { get; set; }
    /// <summary>For user type, see the PersonBehavior table.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_PersonBehaviorId.htm"/>
    public virtual int PersonBehaviorId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_PersonEmail.htm"/>
    public string PersonEmail { get; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_PersonPortrait.htm"/>
    public virtual byte[] PersonPortrait { get; set; }
    /// <summary>ETag value of portrait in Azure Active Directory</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_PersonPortraitETag.htm"/>
    public virtual string PersonPortraitETag { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_PersonPortraitHash.htm"/>
    public virtual string PersonPortraitHash { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_Phone2.htm"/>
    public virtual string Phone2 { get; set; }
    /// <summary>For internal use</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_RefreshToken.htm"/>
    public virtual string RefreshToken { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_sAdDisplayName.htm"/>
    public virtual string sAdDisplayName { get; set; }
    /// <summary>Username for systems older than Windows 2000</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_SamAccountName.htm"/>
    public virtual string SamAccountName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_sFirstName.htm"/>
    public virtual string sFirstName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_sImportRecordId.htm"/>
    public virtual string sImportRecordId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_sImportSystem.htm"/>
    public virtual string sImportSystem { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_sLastName.htm"/>
    public virtual string sLastName { get; set; }
    /// <summary>displayed username</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_sPerson.htm"/>
    public virtual string sPerson { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_sPersonAdGuid.htm"/>
    public virtual string sPersonAdGuid { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_sPersonAdName.htm"/>
    public virtual string sPersonAdName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_sPersonAdPath.htm"/>
    public virtual string sPersonAdPath { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_sPersonCity.htm"/>
    public virtual string sPersonCity { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_sPersonCountry.htm"/>
    public virtual string sPersonCountry { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_sPersonCountryAbbr.htm"/>
    public virtual string sPersonCountryAbbr { get; set; }
    /// <summary>department</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_sPersonDepartment.htm"/>
    public virtual string sPersonDepartment { get; set; }
    /// <summary>e-mail</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_sPersonEmail.htm"/>
    public virtual string sPersonEmail { get; set; }
    /// <summary>User name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_sPersonLogin.htm"/>
    public virtual string sPersonLogin { get; set; }
    /// <summary>mobile phone</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_sPersonMobile.htm"/>
    public virtual string sPersonMobile { get; set; }
    /// <summary>office</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_sPersonOffice.htm"/>
    public virtual string sPersonOffice { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_sPersonPersonalNumber.htm"/>
    public virtual string sPersonPersonalNumber { get; set; }
    /// <summary>phone</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_sPersonPhone.htm"/>
    public virtual string sPersonPhone { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_sPersonPreferredLanguage.htm"/>
    public virtual string sPersonPreferredLanguage { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_sPersonPswd.htm"/>
    public virtual string sPersonPswd { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_sPersonSID.htm"/>
    public virtual string sPersonSID { get; set; }
    /// <summary>E-mail for urgent messages</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_sPersonUrgentEmail.htm"/>
    public virtual string sPersonUrgentEmail { get; set; }
    /// <summary>job</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_sPersonWorkPosition.htm"/>
    public virtual string sPersonWorkPosition { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_TeamsConversationId.htm"/>
    public virtual string TeamsConversationId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tPerson_TimeZone.htm"/>
    public virtual string TimeZone { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tPerson__ctor.htm"/>
    public tPerson() { }
}
