namespace Alvao.API.AM;

/// <summary>Facade class grouping object type methods</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectType.html"/>
public static class ObjectType {
    /// <summary>Edit object type.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectType.html#Alvao_API_AM_ObjectType_Edit_System_Int32_System_String_System_Nullable_System_Int32__System_String_"/>
    /// <param name="id">Object type ID (tblClass.intClassId)</param>
    /// <param name="name">Object type name</param>
    /// <param name="iconId">Object type icon ID (tblIcon.intIconId)</param>
    /// <param name="objectNameTemplate">Template for name of objects having this type</param>
    public static void Edit(int id, string name, int? iconId, string objectNameTemplate) { throw new NotImplementedException(); }
    /// <summary>Gets ID of default template for given object type.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectType.html#Alvao_API_AM_ObjectType_GetDefaultTemplateId_System_Int32_"/>
    /// <param name="objectTypeId">Object type ID (tblClass.intClassId)</param>
    /// <returns>Object type default template ID(tblNode.intNodeId)</returns>
    public static int? GetDefaultTemplateId(int objectTypeId) { throw new NotImplementedException(); }
    /// <summary>Get object type ID based on ChassisTypesId, Hostname or Model.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectType.html#Alvao_API_AM_ObjectType_GetDeviceTypeId_System_String_System_String_System_Int32_"/>
    /// <param name="hostname">Hostname</param>
    /// <param name="model">Model</param>
    /// <param name="chassisTypesId">Chassis types ID</param>
    /// <returns>Object type ID (tblClss.intClassId)</returns>
    public static int GetDeviceTypeId(string hostname, string model, int chassisTypesId) { throw new NotImplementedException(); }
    /// <summary>Recalculates the objects names based on theirs's type.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectType.html#Alvao_API_AM_ObjectType_RecalcObjectName_Type_System_Int32_"/>
    /// <param name="objectTemplateId">Object template ID (tblClass.DefaultObjectTemplateNodeId)</param>
    public static void RecalcObjectName_Type(int objectTemplateId) { throw new NotImplementedException(); }
}
