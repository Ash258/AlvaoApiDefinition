namespace Alvao.API.Common.Model;

/// <summary>
/// Column value model
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_ColumnLocalizationModel.htm"/>
public class ColumnLocalizationModel
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_ColumnLocalizationModel_ColumnId.htm"/>
    public int ColumnId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_ColumnLocalizationModel_Description.htm"/>
    public string Description { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_ColumnLocalizationModel_LocaleId.htm"/>
    public int LocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_ColumnLocalizationModel_Title.htm"/>
    public string Title { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_ColumnLocalizationModel__ctor.htm"/>
    public ColumnLocalizationModel() { }
}
