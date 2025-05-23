namespace Alvao.API.AM.Model.Detection;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.ScanLoadSettings.html"/>
public class ScanLoadSettings {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.ScanLoadSettings.html#Alvao_API_AM_Model_Detection_ScanLoadSettings_CreateNewComputer"/>
    public bool CreateNewComputer { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.ScanLoadSettings.html#Alvao_API_AM_Model_Detection_ScanLoadSettings_EvaluateImmediatelly"/>
    public bool EvaluateImmediatelly { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.ScanLoadSettings.html#Alvao_API_AM_Model_Detection_ScanLoadSettings_ParentNodeId"/>
    public int? ParentNodeId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.ScanLoadSettings.html#Alvao_API_AM_Model_Detection_ScanLoadSettings_ScanName"/>
    public string ScanName { get; set; }

}
