using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.PersonWithSectionSettings.html"/>
public class PersonWithSectionSettings {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.PersonWithSectionSettings.html#Alvao_API_SD_Model_PersonWithSectionSettings_Person"/>
    public tPerson Person { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.PersonWithSectionSettings.html#Alvao_API_SD_Model_PersonWithSectionSettings_PersonEmail"/>
    public string PersonEmail { get; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.PersonWithSectionSettings.html#Alvao_API_SD_Model_PersonWithSectionSettings_Settings"/>
    public vHdSectionPerson Settings { get; set; }
}
