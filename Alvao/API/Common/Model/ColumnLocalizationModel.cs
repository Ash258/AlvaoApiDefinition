namespace Alvao.API.Common.Model;

/// <summary>
/// Column value model
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_ColumnLocalizationModel.htm"/>
public class ColumnLocalizationModel
{
    public int ColumnId { get; set; }
    public string Description { get; set; }
    public int LocaleId { get; set; }
    public string Title { get; set; }

    public ColumnLocalizationModel() { }
}
