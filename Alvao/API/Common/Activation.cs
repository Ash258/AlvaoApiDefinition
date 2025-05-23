using Alvao.Global;
using static Alvao.Global.ModuleInfo;

namespace Alvao.API.Common;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Activation.htm"/>
public static class Activation {
    /// <summary>Returns Organization name of the activation key. Return Value String Organization name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Activation_OrganizationName.htm"/>
    public static string OrganizationName { get; }

    /// <summary>Returns specific license module of the activation key. Return Value LicenseModule License module.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Activation_GetModule.htm"/>
    ///
    /// <param name="moduleId"> </param>
    public static LicenseModule GetModule(
        ModuleId moduleId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns whether the ALVAO key entered in the database is loaded correctly.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Activation_IsKeyLoaded.htm"/>
    public static bool IsKeyLoaded() { throw new System.NotImplementedException(); }

    /// <summary>Returns whether ALVAO module is activated.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Activation_IsModuleActivated.htm"/>
    ///
    /// <param name="moduleId">ALVAO module id</param>
    public static bool IsModuleActivated(
        ModuleId moduleId
    ) { throw new System.NotImplementedException(); }
}
