using Newtonsoft.Json;

namespace Alvao.API.AM.Model.Print;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.PrintPageSettings.html"/>
public class PrintPageSettings {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.PrintPageSettings.OrientationType.html#fields"/>
    public enum OrientationType {
        Portrait = 0,
        Landscape = 1,
    }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.PrintPageSettings.html#Alvao_API_AM_Model_Print_PrintPageSettings_HeightMm"/>
    public int HeightMm { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.PrintPageSettings.html#Alvao_API_AM_Model_Print_PrintPageSettings_MarginBottom"/>
    public int MarginBottom { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.PrintPageSettings.html#Alvao_API_AM_Model_Print_PrintPageSettings_MarginLeft"/>
    public int MarginLeft { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.PrintPageSettings.html#Alvao_API_AM_Model_Print_PrintPageSettings_MarginRight"/>
    public int MarginRight { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.PrintPageSettings.html#Alvao_API_AM_Model_Print_PrintPageSettings_MarginTop"/>
    public int MarginTop { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.PrintPageSettings.html#Alvao_API_AM_Model_Print_PrintPageSettings_Orientation"/>
    public string Orientation { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.PrintPageSettings.html#Alvao_API_AM_Model_Print_PrintPageSettings_PageOrientation"/>
    [JsonIgnore]
    public PrintPageSettings.OrientationType PageOrientation { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.PrintPageSettings.html#Alvao_API_AM_Model_Print_PrintPageSettings_ShowPageNumbers"/>
    public bool ShowPageNumbers { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.PrintPageSettings.html#Alvao_API_AM_Model_Print_PrintPageSettings_WidthMm"/>
    public int WidthMm { get; set; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.PrintPageSettings.html#Alvao_API_AM_Model_Print_PrintPageSettings_LoadFromHTML_System_String_"/>
    public bool LoadFromHTML(string data) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.PrintPageSettings.html#Alvao_API_AM_Model_Print_PrintPageSettings_LoadFromREP_System_String_"/>
    public bool LoadFromREP(string data) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Print.PrintPageSettings.html#Alvao_API_AM_Model_Print_PrintPageSettings_LoadGlobal_System_String_"/>
    public void LoadGlobal(string pageSettings) { throw new NotImplementedException(); }
}
