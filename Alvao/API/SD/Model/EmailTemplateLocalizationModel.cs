namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Model_EmailTemplateLocalizationModel.htm"/>
public class EmailTemplateLocalizationModel {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_EmailTemplateLocalizationModel_id.htm"/>
    public int id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_EmailTemplateLocalizationModel_LocaleId.htm"/>
    public int LocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_EmailTemplateLocalizationModel_mSubject.htm"/>
    public string mSubject { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_EmailTemplateLocalizationModel_mTextBody.htm"/>
    public string mTextBody { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_EmailTemplateLocalizationModel__ctor.htm"/>
    public EmailTemplateLocalizationModel() { }
}
