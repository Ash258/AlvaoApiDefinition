using Alvao.API.Common.Model.Database;

namespace Alvao.API.Common;

/// <summary>Facade class grouping person rights methods. Person rights are usually cached.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.html"/>
public static class PersonRights {
    /// <summary>Flags representing global (system) roles</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.GlobalRoles.html#fields"/>
    [Flags]
    public enum GlobalRoles {
        Accountants = 524288,
        Administrator = 256,
        ApplicationManager = 1024,
        AssetAdministrators = 16384,
        AssetManagers = 131072,
        AssetReaders = 65536,
        AssetRelationsManagers = 1048576,
        AssetRelationsReaders = 2097152,
        ContactManager = 8192,
        ContactReader = 67108864,
        CustomApplicationsManager = 16777216,
        HWAndSWDetectionsManagers = 262144,
        NoRole = 0,
        SectionAdmin = 4194304,
        SettingsManager = 8388608,
        SoftwareLicenseManagers = 32768,
        SoftwareManager = 2048,
        TeamManager = 4096,
        TicketRequesterAuthority = 33554432,
        WorkTime = 512,
    }
    /// <summary>Flags representing service roles.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.SectionRoles.html#fields"/>
    [Flags]
    public enum SectionRoles {
        ExceptionalSolver = 8,
        [Obsolete("Use RequestsReporter instead.")]
        IrregularOperator = 64,
        MainSolver = 2,
        Manager = 1,
        None = 0,
        [Obsolete("Use MainSolver instead.")]
        Operator = 2,
        Reader = 32,
        Requester = 16,
        RequestsReporter = 64,
        Solver = 4,
    }
    /// <summary>Flags representing request and service roles</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.TicketRoles.html#fields"/>
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
        TicketReaderDueToSectionSla = 4096,
        TicketRequestParticipant = 2048,
        TicketRequestParticipantManager = 8192,
        TicketRequester = 512,
        TicketRequesterOrRequesterManager = 128,
        TicketSolver = 32,
        TicketSolverGroupMember = 16384,
    }
    /// <summary>Returns whether user can read particular user.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.html#Alvao_API_Common_PersonRights_CanReadPerson_System_Int32_System_Int32_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="personToReadId">Person to read ID (tPerson.iPersonId)</param>
    /// <returns>User can read particular request</returns>
    public static bool CanReadPerson(int personId, int personToReadId) { throw new System.NotImplementedException(); }
    /// <summary>Returns whether user can read particular request.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.html#Alvao_API_Common_PersonRights_CanReadTicket_System_Int32_System_Int32_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <returns>User can read particular request</returns>
    public static bool CanReadTicket(int personId, int ticketId) { throw new System.NotImplementedException(); }
    /// <summary>Resets user's rights cache. Useful after user rights changes.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.html#Alvao_API_Common_PersonRights_ClearUserRightsCache_System_Int32_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    public static void ClearUserRightsCache(int personId) { throw new System.NotImplementedException(); }
    /// <summary>Returns whether user has any role in Asset Management.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.html#Alvao_API_Common_PersonRights_HaveAnyAssetManagementRole_System_Int32_System_Boolean_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="includeRemovedHidden">Include removed and hidden users</param>
    /// <returns>User has any role in Asset Management</returns>
    public static bool HaveAnyAssetManagementRole(int personId, bool includeRemovedHidden) { throw new System.NotImplementedException(); }
    /// <summary>Returns whether user is member of system group.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.html#Alvao_API_Common_PersonRights_HaveGlobalRole_System_Int32_Alvao_API_Common_Model_Database_RoleBehavior_BehaviorId_System_Boolean_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="behavior">System group</param>
    /// <param name="includeRemovedHidden">Include removed and hidden users</param>
    /// <returns>User is member</returns>
    public static bool HaveGlobalRole(int personId, RoleBehavior.BehaviorId behavior, bool includeRemovedHidden) { throw new System.NotImplementedException(); }
    /// <summary>Returns whether user has role in system.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.html#Alvao_API_Common_PersonRights_HaveGlobalRole_System_Int32_Alvao_API_Common_PersonRights_GlobalRoles_System_Boolean_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="roles">Roles flags (it is possible to combine them with |)</param>
    /// <param name="includeRemovedHidden">Include removed and hidden users</param>
    /// <returns>User has role in system</returns>
    public static bool HaveGlobalRole(int personId, PersonRights.GlobalRoles roles, bool includeRemovedHidden) { throw new System.NotImplementedException(); }
    /// <summary>Returns whether user has roles for particular request or service (or both).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.html#Alvao_API_Common_PersonRights_HaveTicketRole_System_Int32_System_Nullable_System_Int32__System_Nullable_System_Int32__Alvao_API_Common_PersonRights_TicketRoles_System_Boolean_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="sectionId">Service ID (tHdSection.iHdSectionId)</param>
    /// <param name="roles">Roles flags (it is possible to combine them with |)</param>
    /// <param name="includeRemovedTicket">Include removed request</param>
    /// <returns>User has role for particular request or service</returns>
    public static bool HaveTicketRole(int personId, int? ticketId, int? sectionId, PersonRights.TicketRoles roles, bool includeRemovedTicket) { throw new System.NotImplementedException(); }
    /// <summary>Returns whether user is administrator.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.html#Alvao_API_Common_PersonRights_IsAdmin_System_Int32_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <returns>User is administrator</returns>
    public static bool IsAdmin(int personId) { throw new System.NotImplementedException(); }
    /// <summary>Returns whether user is administrator. Revoked: If no administrator is set, returns true (everybody is administrator).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.html#Alvao_API_Common_PersonRights_IsAdminOrAdministratorsRoleIsEmpty_System_Int32_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <returns>User is administrator</returns>
    [Obsolete("IsAdminOrAdministratorsRoleIsEmpty is deprecated, please use IsAdmin instead.")]
    public static bool IsAdminOrAdministratorsRoleIsEmpty(int personId) { throw new System.NotImplementedException(); }
    /// <summary>Returns whether user has some role in any service.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.html#Alvao_API_Common_PersonRights_IsAnySectionRoleMember_System_Int32_Alvao_API_Common_PersonRights_SectionRoles_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="role">Service role</param>
    /// <returns>User has any service role</returns>
    public static bool IsAnySectionRoleMember(int personId, PersonRights.SectionRoles role) { throw new System.NotImplementedException(); }
    /// <summary>Returns whether user is member of any service solver team (solver, manager)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.html#Alvao_API_Common_PersonRights_IsAnySectionSolverTeamMember_System_Int32_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <returns>User is member of any service solver team (solver, manager)</returns>
    public static bool IsAnySectionSolverTeamMember(int personId) { throw new System.NotImplementedException(); }
    /// <summary>Returns whether user is only requester or participant for particular request.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.html#Alvao_API_Common_PersonRights_IsOnlyTicketRequesterOrTicketParticipant_System_Int32_System_Int32_System_Int32_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="sectionId">Section ID (tHdSection.iHdSectionId)</param>
    /// <returns>User is only requester or participant for particular request</returns>
    public static bool IsOnlyTicketRequesterOrTicketParticipant(int personId, int ticketId, int sectionId) { throw new System.NotImplementedException(); }
    /// <summary>Returns whether user is requester or requester's manager.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.html#Alvao_API_Common_PersonRights_IsRequesterOrRequesterManager_System_Int32_System_Int32_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <returns>User is requester or requester's manager</returns>
    public static bool IsRequesterOrRequesterManager(int personId, int ticketId) { throw new System.NotImplementedException(); }
    /// <summary>Returns whether user has role in service.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.html#Alvao_API_Common_PersonRights_IsSectionRoleMember_System_Int32_System_Int32_Alvao_API_Common_PersonRights_SectionRoles_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="sectionId">Service ID (tHdSection.iHdSectionId)</param>
    /// <param name="role">Service role</param>
    /// <returns>User has role in service</returns>
    public static bool IsSectionRoleMember(int personId, int sectionId, PersonRights.SectionRoles role) { throw new System.NotImplementedException(); }
    /// <summary>Returns whether user has service role for particular request.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.html#Alvao_API_Common_PersonRights_IsSectionRoleMemberForTicket_System_Int32_System_Int32_Alvao_API_Common_PersonRights_SectionRoles_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="role">Service role</param>
    /// <returns>User has service role for request</returns>
    public static bool IsSectionRoleMemberForTicket(int personId, int ticketId, PersonRights.SectionRoles role) { throw new System.NotImplementedException(); }
    /// <summary>Returns whether user is request approval authority (approves request).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.html#Alvao_API_Common_PersonRights_IsTicketApprovalAuthority_System_Int32_System_Int32_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <returns>User is request approval authority</returns>
    public static bool IsTicketApprovalAuthority(int personId, int ticketId) { throw new System.NotImplementedException(); }
    /// <summary>Returns whether user is ticket participant on the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.html#Alvao_API_Common_PersonRights_IsTicketRequestParticipant_System_Int32_System_Int32_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="ticketId">Request ID (tHdSection.iHdSectionId)</param>
    /// <returns>User is ticket participant.</returns>
    public static bool IsTicketRequestParticipant(int personId, int ticketId) { throw new System.NotImplementedException(); }
    /// <summary>Returns whether requester is not in requested for on the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.html#Alvao_API_Common_PersonRights_IsTicketRequestedForDifferent_System_Int32_"/>
    /// <param name="ticketId">Request ID (tHdSection.iHdSectionId)</param>
    /// <returns>User is different.</returns>
    public static bool IsTicketRequestedForDifferent(int ticketId) { throw new System.NotImplementedException(); }
    /// <summary>Returns whether user is only reader for particular service.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.html#Alvao_API_Common_PersonRights_IsTicketSectionOnlyReader_System_Int32_System_Int32_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="sectionId">Service ID (tHdSection.iHdSectionId)</param>
    /// <returns>User is only section reader</returns>
    public static bool IsTicketSectionOnlyReader(int personId, int sectionId) { throw new System.NotImplementedException(); }
    /// <summary>Returns whether user is request solver.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.html#Alvao_API_Common_PersonRights_IsTicketSolver_System_Int32_System_Int32_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <returns>User is request solver</returns>
    public static bool IsTicketSolver(int personId, int ticketId) { throw new System.NotImplementedException(); }
    /// <summary>Returns whether user is member of service solver team (solver, manager) for particular request</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.html#Alvao_API_Common_PersonRights_IsTicketSolverTeamMember_System_Int32_System_Int32_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <returns>User is member of service solver team (solver, manager) for particular request</returns>
    public static bool IsTicketSolverTeamMember(int personId, int ticketId) { throw new System.NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.PersonRights.html#Alvao_API_Common_PersonRights_SectionSolverTeamRoles"/>
    public static PersonRights.TicketRoles SectionSolverTeamRoles() { throw new System.NotImplementedException(); }
}
