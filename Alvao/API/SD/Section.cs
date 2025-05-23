using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD;

/// <summary>Facade class grouping service methods.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Section.htm"/>
public static class Section {

    /// <summary>Adds service right to person and creates record in log.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_AddRight.htm"/>
    ///
    /// <param name="model">Service right model</param>
    /// <param name="authorId">Person ID (who added right) (tPerson.iPersonId)</param>
    public static void AddRight(
        tHdSectionRights model,
        int authorId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Adds multiple service rights to person and creates records in log.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_AddRights_1.htm"/>
    ///
    /// <param name="model">Service right model</param>
    /// <param name="sectionIds">Service IDs (tHdSection.iHdSectionId)</param>
    /// <param name="authorId">Person ID (who added right) (tPerson.iPersonId)</param>
    public static void AddRights(
        tHdSectionRights model,
        IEnumerable<int> sectionIds,
        int authorId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Adds multiple service rights to person and creates records in log.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_AddRights.htm"/>
    ///
    /// <param name="model">Service right model</param>
    /// <param name="rolesIds">Role IDs (tRole.iRoleId)</param>
    /// <param name="personsIds">Person IDs (tPerson.iPersonId)</param>
    /// <param name="authorId">Person ID (who added right) (tPerson.iPersonId)</param>
    public static void AddRights(
        tHdSectionRights model,
        IEnumerable<int> rolesIds,
        IEnumerable<int> personsIds,
        int authorId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Adds SLA permission on service and creates record in log.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_AddSlaRight.htm"/>
    ///
    /// <param name="model">SLA right model</param>
    /// <param name="authorId">Person ID (who added right) (tPerson.iPersonId)</param>
    public static void AddSlaRight(
        tSlaRights model,
        int authorId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Adds SLA permissions on service and creates record in log.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_AddSlaRights.htm"/>
    ///
    /// <param name="model">SLA right model</param>
    /// <param name="rolesIds">Role IDs (tRole.iRoleId)</param>
    /// <param name="personsIds">Person IDs (tPerson.iPersonId)</param>
    /// <param name="authorId">Person ID (who added right)(tPerson.iPersonId)</param>
    public static void AddSlaRights(
        tSlaRights model,
        IEnumerable<int> rolesIds,
        IEnumerable<int> personsIds,
        int authorId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Copies service with sourceSectionId under service with destinationSectionId.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_Copy.htm"/>
    ///
    /// <param name="sourceSectionId">Service ID to copy (tHdSection.iHdSectionId)</param>
    /// <param name="destinationSectionId">>Service ID to copy under (tHdSection.iHdSectionId). If null, service is copied to the root.</param>
    /// <param name="copyWithSubtree">Copy service with subtree</param>
    /// <param name="authorId">Person ID who copied service (for logging) (tPerson.iPersonId)</param>
    public static void Copy(
        int sourceSectionId,
        int? destinationSectionId,
        bool copyWithSubtree,
        int authorId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Creates new service from model.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_Create.htm"/>
    ///
    /// <param name="sectionModel">Section model (tHdSection) from Alvao.API namespace.</param>
    public static int Create(
        tHdSection sectionModel
    ) { throw new System.NotImplementedException(); }

    /// <summary>Removes every service rights and creates record in log.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_DeleteAllRights.htm"/>
    ///
    /// <param name="sectionsId">Service IDs (tHdSection.iHdSectionId)</param>
    /// <param name="authorId">Person ID (who removed right) (tPerson.iPersonId)</param>
    public static void DeleteAllRights(
        int[] sectionsId,
        int authorId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Removes all SLA permission on multiple services and creates record in log.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_DeleteAllSlaRights.htm"/>
    ///
    /// <param name="sectionsId">Service IDs (tHdSection.iHdSectionId)</param>
    /// <param name="authorId">Person ID (who removed permission) (tPerson.iPersonId)</param>
    public static void DeleteAllSlaRights(
        int[] sectionsId,
        int authorId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Removes service right and creates record in log.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_DeleteRight.htm"/>
    ///
    /// <param name="rightId">Right ID (tHdSectionRights.iHdSectionRightsId)</param>
    /// <param name="authorId">Person ID (who removed right) (tPerson.iPersonId)</param>
    public static void DeleteRight(
        int rightId,
        int authorId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Removes multiple service rights and creates record in log.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_DeleteRights.htm"/>
    ///
    /// <param name="rightIds">Right IDs (tHdSectionRights.iHdSectionRightsId)</param>
    /// <param name="authorId">Person ID (who removed right) (tPerson.iPersonId)</param>
    public static void DeleteRights(
        int[] rightIds,
        int authorId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Removes multiple SLA permission on service and creates record in log.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_DeleteSlaRights.htm"/>
    ///
    /// <param name="slaRightIds">SLA permission IDs (tSlaRights.iSlaRightsId)</param>
    /// <param name="authorId">Person ID (who removed permission) (tPerson.iPersonId)</param>
    public static void DeleteSlaRights(
        int[] slaRightIds,
        int authorId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Disable inheritance on the service.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_DisableInheritance.htm"/>
    ///
    /// <param name="sectionId">Section ID (tHdSection.iHdSectionId).</param>
    /// <param name="auditLogChanges">Log SectionRights changes to audit log.</param>
    public static void DisableInheritance(
        int sectionId,
        bool auditLogChanges = true
    ) { throw new System.NotImplementedException(); }

    /// <summary>Enable inheritance on the service.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_EnableInheritance.htm"/>
    ///
    /// <param name="sectionId">Section ID (tHdSection.iHdSectionId).</param>
    /// <param name="auditLogChanges">Log SectionRights changes to audit log.</param>
    public static void EnableInheritance(
        int sectionId,
        bool auditLogChanges = true
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns section database model.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_GetById.htm"/>
    ///
    /// <param name="sectionId">Section ID (tHdSection.iHdSectionId)</param>
    public static tHdSection GetById(
        int sectionId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns section database model.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_GetByTicketId.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    public static tHdSection GetByTicketId(
        int ticketId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Get ID of Solver in Section, if there is only 1 Solver and there is no other main solver.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_GetOnlySolverId.htm"/>
    ///
    /// <param name="ticketId">Ticket ID (tHdTicket.iHdTicketId)</param>
    /// <param name="sectionId">Section ID (tHdSection.iHdSectionId)</param>
    public static int GetOnlySolverId(
        int ticketId,
        int sectionId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns whether inheritance is enabled on the service.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_IsInheritanceEnabled.htm"/>
    ///
    /// <param name="sectionId">Section ID (tHdSection.iHdSectionId).</param>
    public static bool IsInheritanceEnabled(
        int sectionId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Checks whether provided e-mail is used by any service</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_IsSectionEmail.htm"/>
    ///
    /// <param name="email">E-mail address</param>
    public static bool IsSectionEmail(
        string email
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns whether role is solver group in specified service.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_IsSolverGroup.htm"/>
    ///
    /// <param name="sectionId">Section ID (tHdSection.iHdSectionId)</param>
    /// <param name="roleId">Role ID (tRole.iRoleId)</param>
    public static bool IsSolverGroup(
        int sectionId,
        int roleId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Moves service with sectionId under service with newParentSectionId</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_Move.htm"/>
    ///
    /// <param name="sectionId">Service ID to move (tHdSection.iHdSectionId)</param>
    /// <param name="newParentSectionId">Service ID to move under (tHdSection.iHdSectionId). If null, service is moved to the root.</param>
    public static void Move(
        int sectionId,
        int? newParentSectionId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Recalculate inheritance on the service (and all child services with enabled inheritance).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_RecalculateInheritance.htm"/>
    ///
    /// <param name="sectionId">Section ID (tHdSection.iHdSectionId).</param>
    /// <param name="auditLogChanges">Log SectionRights changes to audit log.</param>
    public static void RecalculateInheritance(
        int sectionId,
        bool auditLogChanges = false
    ) { throw new System.NotImplementedException(); }

    /// <summary>Recounts the count of solvers and requesters consuming the license of Service Desk.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_RecountSolversAndRequesters.htm"/>
    public static void RecountSolversAndRequesters() { throw new System.NotImplementedException(); }

    /// <summary>Replaces service rights with another service rights and creates record in log.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_ReplaceRights.htm"/>
    ///
    /// <param name="sourceSectionId">Service ID (tHdSection.iHdSectionId)</param>
    /// <param name="destinationSections">Service IDs to be replaced (tHdSection.iHdSectionId)</param>
    /// <param name="authorId">Person ID (who replaced rights) (tPerson.iPersonId)</param>
    public static void ReplaceRights(
        int sourceSectionId,
        int[] destinationSections,
        int authorId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Replaces multiple services SLA permissions with another service SLA permissions and creates record in log.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_ReplaceSlaRights.htm"/>
    ///
    /// <param name="sourceSectionId">Service ID (tHdSection.iHdSectionId)</param>
    /// <param name="destinationSections">Service IDs to be replaced (tHdSection.iHdSectionId)</param>
    /// <param name="authorId">Person ID (who replaced permissions) (tPerson.iPersonId)</param>
    public static void ReplaceSlaRights(
        int sourceSectionId,
        int[] destinationSections,
        int authorId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Updates service right and creates record in log.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_UpdateRight.htm"/>
    ///
    /// <param name="model">Service right model</param>
    /// <param name="authorId">Person ID (who updated right) (tPerson.iPersonId)</param>
    public static void UpdateRight(
        tHdSectionRights model,
        int authorId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Updates SLA permission on service and creates record in log.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Section_UpdateSlaRight.htm"/>
    ///
    /// <param name="model">SLA permission model</param>
    /// <param name="authorId">Person ID (who updated permissions) (tPerson.iPersonId)</param>
    public static void UpdateSlaRight(
        tSlaRights model,
        int authorId
    ) { throw new System.NotImplementedException(); }
}
