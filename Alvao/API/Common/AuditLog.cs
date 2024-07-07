using Alvao.API.Common.Model;

namespace Alvao.API.Common;

/// <summary>
/// Facade class grouping logging methods.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_AuditLog.htm"/>
public static class AuditLog
{
    /// <summary>Message type. Values description can be found in the documentation.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_AuditLog_MessageType.htm"/>
    public enum MessageType
    {
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
    }

    /// <summary>Creates system block.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_AuditLog_CreateSystemBlockModel.htm"/>
    public static AuditSystemBlockModel CreateSystemBlockModel() { throw new System.NotImplementedException(); }

    /// <summary>Creates audit record.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_AuditLog_LogAuditRecord.htm"/>
    ///
    /// <param name="messageType">Message type.</param>
    /// <param name="properties">List of properties to append to log message.</param>
    /// <param name="systemBlock">Properties to append after delimiter and properties (system block)</param>
    public static void LogAuditRecord(
        AuditLog.MessageType messageType,
        IEnumerable<KeyValuePair<string, string>> properties,
        AuditSystemBlockModel systemBlock
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Creates audit record.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_AuditLog_LogAuditRecord_1.htm"/>
    ///
    /// <param name="messageType">Message type.</param>
    /// <param name="properties">List of properties to append to log message.</param>
    /// <param name="appendSystemBlock">Automatically create and append system block.</param>
    public static void LogAuditRecord(
        AuditLog.MessageType messageType,
        IEnumerable<KeyValuePair<string, string>> properties,
        bool appendSystemBlock = true
    )
    { throw new System.NotImplementedException(); }
}
