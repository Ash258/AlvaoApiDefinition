using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD;

/// <summary>Facade class grouping service methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html"/>
public static class Section {
    /// <summary>Adds service right to person and creates record in log.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_AddRight_Alvao_API_Common_Model_Database_tHdSectionRights_System_Int32_"/>
    /// <param name="model">Service right model</param>
    /// <param name="authorId">Person ID (who added right) (tPerson.iPersonId)</param>
    /// <exception cref="ArgumentNullException">Throws when model is null.</exception>
    public static void AddRight(tHdSectionRights model, int authorId) { throw new NotImplementedException(); }
    /// <summary>Adds multiple service rights to person and creates records in log.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_AddRights_Alvao_API_Common_Model_Database_tHdSectionRights_System_Collections_Generic_IEnumerable_System_Int32__System_Collections_Generic_IEnumerable_System_Int32__System_Int32_"/>
    /// <param name="model">Service right model</param>
    /// <param name="rolesIds">Role IDs (tRole.iRoleId)</param>
    /// <param name="personsIds">Person IDs (tPerson.iPersonId)</param>
    /// <param name="authorId">Person ID (who added right) (tPerson.iPersonId)</param>
    /// <exception cref="ArgumentNullException">Throws when model, rolesIds or personsIds is null.</exception>
    /// <exception cref="ArgumentException">Throws when section does not exist or at least one role from rolesIds or person from personsIds does not exist.</exception>
    public static void AddRights(tHdSectionRights model, IEnumerable<int> rolesIds, IEnumerable<int> personsIds, int authorId) { throw new NotImplementedException(); }
    /// <summary>Adds multiple service rights to person and creates records in log.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_AddRights_Alvao_API_Common_Model_Database_tHdSectionRights_System_Collections_Generic_IEnumerable_System_Int32__System_Int32_"/>
    /// <param name="model">Service right model</param>
    /// <param name="sectionIds">Service IDs (tHdSection.iHdSectionId)</param>
    /// <param name="authorId">Person ID (who added right) (tPerson.iPersonId)</param>
    /// <exception cref="ArgumentNullException">Throws when model is null.</exception>
    /// <exception cref="ArgumentException">Throws when sectionIds is null or at least one of them does not exist or when model is not valid.</exception>
    public static void AddRights(tHdSectionRights model, IEnumerable<int> sectionIds, int authorId) { throw new NotImplementedException(); }
    /// <summary>Adds SLA permission on service and creates record in log.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_AddSlaRight_Alvao_API_Common_Model_Database_tSlaRights_System_Int32_"/>
    /// <param name="model">SLA right model</param>
    /// <param name="authorId">Person ID (who added right) (tPerson.iPersonId)</param>
    /// <exception cref="ArgumentNullException">Throws when model is null.</exception>
    /// <exception cref="ArgumentException">Throws when service does not exist or model is not valid.</exception>
    public static void AddSlaRight(tSlaRights model, int authorId) { throw new NotImplementedException(); }
    /// <summary>Adds SLA permissions on service and creates record in log.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_AddSlaRights_Alvao_API_Common_Model_Database_tSlaRights_System_Collections_Generic_IEnumerable_System_Int32__System_Collections_Generic_IEnumerable_System_Int32__System_Int32_"/>
    /// <param name="model">SLA right model</param>
    /// <param name="rolesIds">Role IDs (tRole.iRoleId)</param>
    /// <param name="personsIds">Person IDs (tPerson.iPersonId)</param>
    /// <param name="authorId">Person ID (who added right)(tPerson.iPersonId)</param>
    /// <exception cref="ArgumentNullException">Throws when model, rolesIds or personsIds is null.</exception>
    /// <exception cref="ArgumentException">Throws when at least one role in rolesIds, person in personsIds or service does not exist.</exception>
    public static void AddSlaRights(tSlaRights model, IEnumerable<int> rolesIds, IEnumerable<int> personsIds, int authorId) { throw new NotImplementedException(); }
    /// <summary>Copies service with sourceSectionId under service with destinationSectionId.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_Copy_System_Int32_System_Nullable_System_Int32__System_Boolean_System_Int32_"/>
    /// <exception cref="ArgumentException">Throws when destinationSectionId or sourceSectionId does not exists.</exception>
    /// <exception cref="InvalidOperationException">Throws when destinationSectionId or sourceSectionId is deleted.</exception>
    public static void Copy(int sourceSectionId, int? destinationSectionId, bool copyWithSubtree, int authorId) { throw new NotImplementedException(); }
    /// <summary>Copies service with sourceSectionId under service with destinationSectionId. CopySections is deprecated, please use Copy instead.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_CopySections_System_Int32_System_Nullable_System_Int32__System_Boolean_System_Int32_"/>
    /// <exception cref="ArgumentException">Throws when destinationSectionId or sourceSectionId does not exists.</exception>
    /// <exception cref="InvalidOperationException">Throws when destinationSectionId or sourceSectionId is deleted.</exception>
    [Obsolete("CopySections is deprecated, please use Copy instead.")]
    public static void CopySections(int sourceSectionId, int? destinationSectionId, bool copyWithSubtree, int authorId) { throw new NotImplementedException(); }
    /// <summary>Creates new service from model.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_Create_Alvao_API_Common_Model_Database_tHdSection_"/>
    /// <param name="sectionModel">Section model (tHdSection) from Alvao.API namespace.</param>
    /// <returns>Created service ID.</returns>
    public static int Create(tHdSection sectionModel) { throw new NotImplementedException(); }
    /// <summary>Removes every service rights and creates record in log.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_DeleteAllRights_System_Int32___System_Int32_"/>
    /// <param name="sectionsId">Service IDs (tHdSection.iHdSectionId)</param>
    /// <param name="authorId">Person ID (who removed right) (tPerson.iPersonId)</param>
    /// <exception cref="ArgumentNullException">Throws when sectionsId is null.</exception>
    public static void DeleteAllRights(int[] sectionsId, int authorId) { throw new NotImplementedException(); }
    /// <summary>Removes all SLA permission on multiple services and creates record in log.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_DeleteAllSlaRights_System_Int32___System_Int32_"/>
    /// <param name="sectionsId">Service IDs (tHdSection.iHdSectionId)</param>
    /// <param name="authorId">Person ID (who removed permission) (tPerson.iPersonId)</param>
    /// <exception cref="ArgumentNullException">Throws when sectionsId is null.</exception>
    public static void DeleteAllSlaRights(int[] sectionsId, int authorId) { throw new NotImplementedException(); }
    /// <summary>Removes service right and creates record in log.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_DeleteRight_System_Int32_System_Int32_"/>
    /// <param name="rightId">Right ID (tHdSectionRights.iHdSectionRightsId)</param>
    /// <param name="authorId">Person ID (who removed right) (tPerson.iPersonId)</param>
    /// <exception cref="ArgumentException">Throws when section right with rightId does not exist.</exception>
    public static void DeleteRight(int rightId, int authorId) { throw new NotImplementedException(); }
    /// <summary>Removes multiple service rights and creates record in log.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_DeleteRights_System_Int32___System_Int32_"/>
    /// <param name="rightIds">Right IDs (tHdSectionRights.iHdSectionRightsId)</param>
    /// <param name="authorId">Person ID (who removed right) (tPerson.iPersonId)</param>
    /// <exception cref="ArgumentNullException">Throws when rightIds is null.</exception>
    /// <exception cref="ArgumentException">Throws when at least one section right in rightIds does not exist.</exception>
    public static void DeleteRights(int[] rightIds, int authorId) { throw new NotImplementedException(); }
    /// <summary>Removes multiple SLA permission on service and creates record in log.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_DeleteSlaRights_System_Int32___System_Int32_"/>
    /// <param name="slaRightIds">SLA permission IDs (tSlaRights.iSlaRightsId)</param>
    /// <param name="authorId">Person ID (who removed permission) (tPerson.iPersonId)</param>
    /// <exception cref="ArgumentNullException">Throws when slaRightIds is null.</exception>
    /// <exception cref="ArgumentException">Throws when at least one sla right in slaRightIds does not exist.</exception>
    public static void DeleteSlaRights(int[] slaRightIds, int authorId) { throw new NotImplementedException(); }
    /// <summary>Disable inheritance on the service.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_DisableInheritance_System_Int32_System_Boolean_"/>
    /// <param name="sectionId">Section ID (tHdSection.iHdSectionId).</param>
    /// <param name="auditLogChanges">Log SectionRights changes to audit log.</param>
    /// <exception cref="ArgumentException">Throws when service with sectionId does not exists.</exception>
    /// <exception cref="InheritanceException">Throws when infinite recursion is detected.</exception>
    public static void DisableInheritance(int sectionId, bool auditLogChanges = true) { throw new NotImplementedException(); }
    /// <summary>Enable inheritance on the service.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_EnableInheritance_System_Int32_System_Boolean_"/>
    /// <param name="sectionId">Section ID (tHdSection.iHdSectionId).</param>
    /// <param name="auditLogChanges">Log SectionRights changes to audit log.</param>
    /// <exception cref="ArgumentException">Throws when service with sectionId does not exists.</exception>
    /// <exception cref="InheritanceException">Throws when infinite recursion is detected.</exception>
    public static void EnableInheritance(int sectionId, bool auditLogChanges = true) { throw new NotImplementedException(); }
    /// <summary>Returns section database model.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_GetById_System_Int32_"/>
    /// <param name="sectionId">Section ID (tHdSection.iHdSectionId)</param>
    /// <returns>Request model (tHdTicket)</returns>
    public static tHdSection GetById(int sectionId) { throw new NotImplementedException(); }
    /// <summary>Returns section database model.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_GetByIdAsync_System_Int32_"/>
    /// <param name="sectionId">Section ID (tHdSection.iHdSectionId)</param>
    /// <returns>Request model (tHdTicket)</returns>
    public static Task<tHdSection> GetByIdAsync(int sectionId) { throw new NotImplementedException(); }
    /// <summary>Returns section database model.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_GetByTicketId_System_Int32_"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <returns>Request model (tHdTicket)</returns>
    public static tHdSection GetByTicketId(int ticketId) { throw new NotImplementedException(); }
    /// <summary>Get ID of Solver in Section, if there is only 1 Solver and there is no other main solver.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_GetOnlySolverId_System_Int32_System_Int32_"/>
    /// <param name="ticketId">Ticket ID (tHdTicket.iHdTicketId)</param>
    /// <param name="sectionId">Section ID (tHdSection.iHdSectionId)</param>
    public static int GetOnlySolverId(int ticketId, int sectionId) { throw new NotImplementedException(); }
    /// <summary>Get ID of Solver in Section, if there is only 1 Solver and there is no other main solver. GetSectionOnlySolverId is deprecated, please use GetOnlySolverId instead.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_GetSectionOnlySolverId_System_Int32_System_Int32_"/>
    /// <param name="ticketId">Ticket ID from (tHdTicket.iHdTicketId)</param>
    /// <param name="sectionId">Section ID from (tHdSection.iHdSectionId)</param>
    [Obsolete("GetSectionOnlySolverId is deprecated, please use GetOnlySolverId instead.")]
    public static int GetSectionOnlySolverId(int ticketId, int sectionId) { throw new NotImplementedException(); }
    /// <summary>Returns whether inheritance is enabled on the service.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_IsInheritanceEnabled_System_Int32_"/>
    /// <param name="sectionId">Section ID (tHdSection.iHdSectionId).</param>
    /// <returns>Service has inheritance enabled.</returns>
    public static bool IsInheritanceEnabled(int sectionId) { throw new NotImplementedException(); }
    /// <summary>Checks whether provided e-mail is used by any service</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_IsSectionEmail_System_String_"/>
    /// <param name="email">E-mail address</param>
    /// <returns>True, if e-mail is used by any service, false otherwise.</returns>
    public static bool IsSectionEmail(string email) { throw new NotImplementedException(); }
    /// <summary>Returns whether role is solver group in specified service.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_IsSolverGroup_System_Int32_System_Int32_"/>
    /// <param name="sectionId">Section ID (tHdSection.iHdSectionId)</param>
    /// <param name="roleId">Role ID (tRole.iRoleId)</param>
    /// <returns>Role is solver group in specified service</returns>
    public static bool IsSolverGroup(int sectionId, int roleId) { throw new NotImplementedException(); }
    /// <summary>Moves service with sectionId under service with newParentSectionId</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_Move_System_Int32_System_Nullable_System_Int32__"/>
    /// <param name="sectionId">Service ID to move (tHdSection.iHdSectionId)</param>
    /// <param name="newParentSectionId">Service ID to move under (tHdSection.iHdSectionId). If null, service is moved to the root.</param>
    /// <exception cref="ArgumentException">Throws when service with sectionId does not exists.</exception>
    /// <exception cref="InvalidOperationException">Throws when newParentSectionId is deleted.</exception>
    public static void Move(int sectionId, int? newParentSectionId) { throw new NotImplementedException(); }
    /// <summary>Moves service with sectionId under service with newParentSectionId MoveSections is deprecated, please use Move instead.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_MoveSections_System_Int32_System_Nullable_System_Int32__"/>
    /// <param name="sectionId">Service ID to move (tHdSection.iHdSectionId)</param>
    /// <param name="newParentSectionId">Service ID to move under (tHdSection.iHdSectionId). If null, service is moved to the root.</param>
    /// <exception cref="ArgumentException">Throws when service with sectionId does not exists.</exception>
    /// <exception cref="InvalidOperationException">Throws when newParentSectionId is deleted.</exception>
    [Obsolete("MoveSections is deprecated, please use Move instead.")]
    public static void MoveSections(int sectionId, int? newParentSectionId) { throw new NotImplementedException(); }
    /// <summary>Recalculate inheritance on the service (and all child services with enabled inheritance).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_RecalculateInheritance_System_Int32_System_Boolean_"/>
    /// <param name="sectionId">Section ID (tHdSection.iHdSectionId).</param>
    /// <param name="auditLogChanges">Log SectionRights changes to audit log.</param>
    /// <exception cref="ArgumentException">Throws when service with sectionId does not exists.</exception>
    /// <exception cref="InheritanceException">Throws when infinite recursion is detected.</exception>
    public static void RecalculateInheritance(int sectionId, bool auditLogChanges = false) { throw new NotImplementedException(); }
    /// <summary>Recounts the count of solvers and requesters consuming the license of Service Desk.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_RecountSolversAndRequesters"/>
    public static void RecountSolversAndRequesters() { throw new NotImplementedException(); }
    /// <summary>Replaces service rights with another service rights and creates record in log.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_ReplaceRights_System_Int32_System_Int32___System_Int32_"/>
    /// <param name="sourceSectionId">Service ID (tHdSection.iHdSectionId)</param>
    /// <param name="destinationSections">Service IDs to be replaced (tHdSection.iHdSectionId)</param>
    /// <param name="authorId">Person ID (who replaced rights) (tPerson.iPersonId)</param>
    /// <exception cref="ArgumentNullException">Throws when destinationSections is null.</exception>
    public static void ReplaceRights(int sourceSectionId, int[] destinationSections, int authorId) { throw new NotImplementedException(); }
    /// <summary>Replaces service rights with another service rights and creates record in log. ReplaceSectionsRights is deprecated, please use ReplaceRights instead.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_ReplaceSectionsRights_System_Int32_System_Int32___System_Int32_"/>
    /// <param name="sourceSectionId">Service ID (tHdSection.iHdSectionId)</param>
    /// <param name="destinationSections">Service IDs to be replaced (tHdSection.iHdSectionId)</param>
    /// <param name="authorId">Person ID (who replaced rights) (tPerson.iPersonId)</param>
    /// <exception cref="ArgumentNullException">Throws when destinationSections is null.</exception>
    [Obsolete("ReplaceSectionsRights is deprecated, please use ReplaceRights instead.")]
    public static void ReplaceSectionsRights(int sourceSectionId, int[] destinationSections, int authorId) { throw new NotImplementedException(); }
    /// <summary>Replaces multiple services SLA permissions with another service SLA permissions and creates record in log. ReplaceSectionsSlaRights is deprecated, please use ReplaceSlaRights instead.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_ReplaceSectionsSlaRights_System_Int32_System_Int32___System_Int32_"/>
    /// <param name="sourceSectionId">Service ID (tHdSection.iHdSectionId)</param>
    /// <param name="destinationSections">Service IDs to be replaced (tHdSection.iHdSectionId)</param>
    /// <param name="authorId">Person ID (who replaced permissions) (tPerson.iPersonId)</param>
    /// <exception cref="ArgumentNullException">Throws when destinationSections is null.</exception>
    [Obsolete("ReplaceSectionsSlaRights is deprecated, please use ReplaceSlaRights instead.")]
    public static void ReplaceSectionsSlaRights(int sourceSectionId, int[] destinationSections, int authorId) { throw new NotImplementedException(); }
    /// <summary>Replaces multiple services SLA permissions with another service SLA permissions and creates record in log.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_ReplaceSlaRights_System_Int32_System_Int32___System_Int32_"/>
    /// <param name="sourceSectionId">Service ID (tHdSection.iHdSectionId)</param>
    /// <param name="destinationSections">Service IDs to be replaced (tHdSection.iHdSectionId)</param>
    /// <param name="authorId">Person ID (who replaced permissions) (tPerson.iPersonId)</param>
    /// <exception cref="ArgumentNullException">Throws when destinationSections is null.</exception>
    public static void ReplaceSlaRights(int sourceSectionId, int[] destinationSections, int authorId) { throw new NotImplementedException(); }
    /// <summary>Updates service right and creates record in log.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_UpdateRight_Alvao_API_Common_Model_Database_tHdSectionRights_System_Int32_"/>
    /// <param name="model">Service right model</param>
    /// <param name="authorId">Person ID (who updated right) (tPerson.iPersonId)</param>
    /// <exception cref="ArgumentNullException">Throws when model is null.</exception>
    /// <exception cref="ArgumentException">Throws when service or requester role does not exist or model is not valid.</exception>
    public static void UpdateRight(tHdSectionRights model, int authorId) { throw new NotImplementedException(); }
    /// <summary>Updates SLA permission on service and creates record in log.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Section.html#Alvao_API_SD_Section_UpdateSlaRight_Alvao_API_Common_Model_Database_tSlaRights_System_Int32_"/>
    /// <param name="model">SLA permission model</param>
    /// <param name="authorId">Person ID (who updated permissions) (tPerson.iPersonId)</param>
    /// <exception cref="ArgumentNullException">Throws when model is null.</exception>
    /// <exception cref="ArgumentException">Throws when section does not exist or model is not valid.</exception>
    public static void UpdateSlaRight(tSlaRights model, int authorId) { throw new NotImplementedException(); }
}
