namespace Alvao.API.SD.Model;

public class EmailTemplateLocalizationModel
{
    public int id { get; set; }
    public int LocaleId { get; set; }
    public string mSubject { get; set; }
    public string mTextBody { get; set; }

    public EmailTemplateLocalizationModel() { }
}
