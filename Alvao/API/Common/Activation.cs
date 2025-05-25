namespace Alvao.API.Common;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Activation.html"/>
public static class Activation {
    /// <summary>Returns Organization name of the activation key. Organization name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Activation.html#Alvao_API_Common_Activation_OrganizationName"/>
    public static string OrganizationName { get; }
    /// <summary>Returns specific license module of the activation key. License module.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Activation.html#Alvao_API_Common_Activation_GetModule_Alvao_Global_ModuleInfo_ModuleId_"/>
    public static LicenseModule GetModule(ModuleInfo.ModuleId moduleId) { throw new NotImplementedException(); }
    /// <summary>Returns whether the ALVAO key entered in the database is loaded correctly.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Activation.html#Alvao_API_Common_Activation_IsKeyLoaded"/>
    /// <returns>True, if the key format is valid.</returns>
    public static bool IsKeyLoaded() { throw new NotImplementedException(); }
    /// <summary>Returns whether ALVAO module is activated.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Activation.html#Alvao_API_Common_Activation_IsModuleActivated_Alvao_Global_ModuleInfo_ModuleId_"/>
    /// <param name="moduleId">ALVAO module id</param>
    public static bool IsModuleActivated(ModuleInfo.ModuleId moduleId) { throw new NotImplementedException(); }
}
