using Alvao.API.Common.Model;

namespace Alvao.API.Common;

/// <summary>Facade class grouping logging methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.AuditLog.html"/>
public static class AuditLog {
    /// <summary>Message type. Values description can be found in the documentation.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.AuditLog.MessageType.html#fields"/>
    public enum MessageType {
        PersonCreate = 1,
        PersonDelete = 2,
        PersonChange = 3,
        UserLoginSuccessful = 4,
        UserLogout = 5,
        UserLoginUnsuccessful = 6,
        ServicePermissionAdded = 7,
        ServicePermissionChanged = 8,
        ServicePermissionRemoved = 9,
        SlaPermissionAdded = 10,
        SlaPermissionChanged = 11,
        SlaPermissionRemoved = 12,
        ObjectPermissionAdded = 13,
        ObjectPermissionChanged = 14,
        ObjectPermissionRemoved = 15,
        PropertyPermissionChange = 16,
        PropertyPermissionAdd = 17,
        PropertyPermissionRemove = 18,
        MemberAddToGroup = 19,
        MemberRemoveFromGroup = 20,
        ServicesImportedFromFile = 21,
        SoftwareLicensePermissionAdded = 22,
        SoftwareLicensePermissionChanged = 23,
        SoftwareLicensePermissionRemoved = 24,
        InvalidAuthenticationWhenSigningADocument = 25,
        DocumentFolderPermissionAdded = 26,
        DocumentFolderPermissionChanged = 27,
        DocumentFolderPermissionRemoved = 28,
        QueryCreated = 29,
        QueryEdited = 30,
        QueryDeleted = 31,
        QueryPermissionAdded = 32,
        QueryPermissionDeleted = 33,
        ServiceInheritanceEnabled = 34,
        ServiceInheritanceDisabled = 35,
        GroupCreated = 36,
        GroupDeleted = 37,
        GroupChanged = 38,
        EntraTenantAdded = 39,
        EntraTenantSecretTokenGenerated = 40,
        EntraTenantRemoved = 41,
        OrganizationCreated = 42,
        OrganizationDeleted = 43,
        OrganizationEdited = 44,
        OrganizationRecovered = 45,
    }

    /// <summary>Creates system block.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.AuditLog.html#Alvao_API_Common_AuditLog_CreateSystemBlockModel"/>
    /// <returns>System block model.</returns>
    public static AuditSystemBlockModel CreateSystemBlockModel() { throw new NotImplementedException(); }
    /// <summary>Creates audit record.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.AuditLog.html#Alvao_API_Common_AuditLog_LogAuditRecord_Alvao_API_Common_AuditLog_MessageType_System_Collections_Generic_IEnumerable_System_Collections_Generic_KeyValuePair_System_String_System_String___Alvao_API_Common_Model_AuditSystemBlockModel_"/>
    /// <param name="messageType">Message type.</param>
    /// <param name="properties">List of properties to append to log message.</param>
    /// <param name="systemBlock">Properties to append after delimiter and properties (system block)</param>
    public static void LogAuditRecord(AuditLog.MessageType messageType, IEnumerable<KeyValuePair<string, string>> properties, AuditSystemBlockModel systemBlock) { throw new NotImplementedException(); }
    /// <summary>Creates audit record.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.AuditLog.html#Alvao_API_Common_AuditLog_LogAuditRecord_Alvao_API_Common_AuditLog_MessageType_System_Collections_Generic_IEnumerable_System_Collections_Generic_KeyValuePair_System_String_System_String___System_Boolean_"/>
    /// <param name="messageType">Message type.</param>
    /// <param name="properties">List of properties to append to log message.</param>
    /// <param name="appendSystemBlock">Automatically create and append system block.</param>
    public static void LogAuditRecord(AuditLog.MessageType messageType, IEnumerable<KeyValuePair<string, string>> properties, bool appendSystemBlock = true) { throw new NotImplementedException(); }
}
