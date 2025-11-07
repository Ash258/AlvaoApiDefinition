namespace Alvao.API.AM.Model.Detection.Software;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Software.DetectionRegValue.html"/>
public class DetectionRegValue {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Software.DetectionRegValue.KeyType.html#fields"/>
    public enum KeyType {
        CurrentUser = 1,
        LocalMachine = 2,
        Uninstall = 256,
    }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Software.DetectionRegValue.html#Alvao_API_AM_Model_Detection_Software_DetectionRegValue_Name"/>
    public string Name { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Software.DetectionRegValue.html#Alvao_API_AM_Model_Detection_Software_DetectionRegValue_Path"/>
    public string Path { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Software.DetectionRegValue.html#Alvao_API_AM_Model_Detection_Software_DetectionRegValue_Type"/>
    public DetectionRegValue.KeyType Type { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Software.DetectionRegValue.html#Alvao_API_AM_Model_Detection_Software_DetectionRegValue_Value"/>
    public string Value { get; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.Software.DetectionRegValue.html#Alvao_API_AM_Model_Detection_Software_DetectionRegValue__ctor_Alvao_API_AM_Model_Detection_DetectionArchive_"/>
    public DetectionRegValue(DetectionArchive ar) { }
}
