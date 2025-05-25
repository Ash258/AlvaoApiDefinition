namespace Alvao.API.Common.Model;

/// <summary>Column value model</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ColumnLocalizationModel.html"/>
public class ColumnLocalizationModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ColumnLocalizationModel.html#Alvao_API_Common_Model_ColumnLocalizationModel_ColumnId"/>
    public int ColumnId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ColumnLocalizationModel.html#Alvao_API_Common_Model_ColumnLocalizationModel_Description"/>
    public string Description { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ColumnLocalizationModel.html#Alvao_API_Common_Model_ColumnLocalizationModel_LocaleId"/>
    public int LocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ColumnLocalizationModel.html#Alvao_API_Common_Model_ColumnLocalizationModel_Title"/>
    public string Title { get; set; }
}
