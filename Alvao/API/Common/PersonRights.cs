using Alvao.API.Common.Model.Database;

namespace Alvao.API.Common;

/// <summary>Facade class grouping person rights methods. Person rights are usually cached.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_PersonRights.htm"/>
public static class PersonRights {
    /// <summary>Flags representing global (system) roles</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_PersonRights_GlobalRoles.htm"/>
    [FlagsAttribute]
    public enum GlobalRoles {
        NoRole = 0,
        Administrator = 256,
        WorkTime = 512,
        ApplicationManager = 1_024,
        SoftwareManager = 2_048,
        TeamManager = 4_096,
        ContactManager = 8_192,
        AssetAdministrators = 16_384,
        SoftwareLicenseManagers = 32_768,
        AssetReaders = 65_536,
        AssetManagers = 131_072,
        HWAndSWDetectionsManagers = 262_144,
        Accountants = 524_288,
        AssetRelationsManagers = 1_048_576,
        AssetRelationsReaders = 2_097_152,
        SectionAdmin = 4_194_304,
        SettingsManager = 8_388_608,
        CustomApplicationsManager = 16_777_216,
        TicketRequesterAuthority = 33_554_432,
        ContactReader = 67_108_864,
    }
    /// <summary>Flags representing service roles.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_PersonRights_SectionRoles.htm"/>
    [FlagsAttribute]
    public enum SectionRoles {
        None = 0,
        Manager = 1,
        Operator = 2,
        MainSolver = 2,
        Solver = 4,
        ExceptionalSolver = 8,
        Requester = 16,
        Reader = 32,
        IrregularOperator = 64,
        RequestsReporter = 64,
    }
    /// <summary>Flags representing request and service roles</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_PersonRights_TicketRoles.htm"/>
    [FlagsAttribute]
    public enum TicketRoles {
        NoRole = 0,
        SectionRequester = 1,
        SectionSolver = 2,
        SectionOperator = 4,
        SectionMainSolver = 4,
        SectionManager = 8,
        SectionReader = 16,
        TicketSolver = 32,
        TicketApprovalAuthority = 64,
        TicketRequesterOrRequesterManager = 128,
        SectionExceptionalSolver = 256,
        TicketRequester = 512,
        TicketFollower = 1_024,
        TicketRequestParticipant = 2_048,
        TicketReaderDueToSectionSla = 4_096,
        TicketRequestParticipantManager = 8_192,
    }

    /// <summary>Returns whether user can read particular user.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_PersonRights_CanReadPerson.htm"/>
    ///
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="personToReadId">Person to read ID (tPerson.iPersonId)</param>
    public static bool CanReadPerson(
        int personId,
        int personToReadId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns whether user can read particular request.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_PersonRights_CanReadTicket.htm"/>
    ///
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    public static bool CanReadTicket(
        int personId,
        int ticketId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Resets user's rights cache. Useful after user rights changes.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_PersonRights_ClearUserRightsCache.htm"/>
    ///
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    public static void ClearUserRightsCache(
        int personId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns whether user has any role in Asset Management.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_PersonRights_HaveAnyAssetManagementRole.htm"/>
    ///
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="includeRemovedHidden">Include removed and hidden users</param>
    public static bool HaveAnyAssetManagementRole(
        int personId,
        bool includeRemovedHidden
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns whether user is member of system group.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_PersonRights_HaveGlobalRole.htm"/>
    ///
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="behavior">System group</param>
    /// <param name="includeRemovedHidden">Include removed and hidden users</param>
    public static bool HaveGlobalRole(
        int personId,
        RoleBehavior.BehaviorId behavior,
        bool includeRemovedHidden
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns whether user has role in system.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_PersonRights_HaveGlobalRole_1.htm"/>
    ///
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="roles">Roles flags (it is possible to combine them with |)</param>
    /// <param name="includeRemovedHidden">Include removed and hidden users</param>
    public static bool HaveGlobalRole(
        int personId,
        PersonRights.GlobalRoles roles,
        bool includeRemovedHidden
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns whether user has roles for particular request or service (or both).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_PersonRights_HaveTicketRole.htm"/>
    ///
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="sectionId">Service ID (tHdSection.iHdSectionId)</param>
    /// <param name="roles">Roles flags (it is possible to combine them with |)</param>
    /// <param name="includeRemovedTicket">Include removed request</param>
    public static bool HaveTicketRole(
        int personId,
        int? ticketId,
        int? sectionId,
        PersonRights.TicketRoles roles,
        bool includeRemovedTicket
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns whether user is administrator.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_PersonRights_IsAdmin.htm"/>
    ///
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    public static bool IsAdmin(
        int personId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns whether user has some role in any service.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_PersonRights_IsAnySectionRoleMember.htm"/>
    ///
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="role">Service role</param>
    public static bool IsAnySectionRoleMember(
        int personId,
        PersonRights.SectionRoles role
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns whether user is member of any service solver team (solver, manager)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_PersonRights_IsAnySectionSolverTeamMember.htm"/>
    ///
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    public static bool IsAnySectionSolverTeamMember(
        int personId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns whether user is requester or requester's manager.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_PersonRights_IsRequesterOrRequesterManager.htm"/>
    ///
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    public static bool IsRequesterOrRequesterManager(
        int personId,
        int ticketId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns whether user has role in service.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_PersonRights_IsSectionRoleMember.htm"/>
    ///
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="sectionId">Service ID (tHdSection.iHdSectionId)</param>
    /// <param name="role">Service role</param>
    public static bool IsSectionRoleMember(
        int personId,
        int sectionId,
        PersonRights.SectionRoles role
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns whether user has service role for particular request.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_PersonRights_IsSectionRoleMemberForTicket.htm"/>
    ///
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="role">Service role</param>
    public static bool IsSectionRoleMemberForTicket(
        int personId,
        int ticketId,
        PersonRights.SectionRoles role
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns whether user is request approval authority (approves request).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_PersonRights_IsTicketApprovalAuthority.htm"/>
    ///
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    public static bool IsTicketApprovalAuthority(
        int personId,
        int ticketId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns whether requester is not in requested for on the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_PersonRights_IsTicketRequestedForDifferent.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdSection.iHdSectionId)</param>
    public static bool IsTicketRequestedForDifferent(
        int ticketId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns whether user is ticket participant on the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_PersonRights_IsTicketRequestParticipant.htm"/>
    ///
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="ticketId">Request ID (tHdSection.iHdSectionId)</param>
    public static bool IsTicketRequestParticipant(
        int personId,
        int ticketId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns whether user is only reader for particular service.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_PersonRights_IsTicketSectionOnlyReader.htm"/>
    ///
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="sectionId">Service ID (tHdSection.iHdSectionId)</param>
    public static bool IsTicketSectionOnlyReader(
        int personId,
        int sectionId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns whether user is request solver.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_PersonRights_IsTicketSolver.htm"/>
    ///
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    public static bool IsTicketSolver(
        int personId,
        int ticketId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns whether user is member of service solver team (solver, manager) for particular request</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_PersonRights_IsTicketSolverTeamMember.htm"/>
    ///
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    public static bool IsTicketSolverTeamMember(
        int personId,
        int ticketId
    ) { throw new System.NotImplementedException(); }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_PersonRights_SectionSolverTeamRoles.htm"/>
    public static PersonRights.TicketRoles SectionSolverTeamRoles() { throw new System.NotImplementedException(); }
}
