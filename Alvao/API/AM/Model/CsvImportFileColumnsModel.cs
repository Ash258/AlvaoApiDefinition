namespace Alvao.API.AM.Model;

public class CsvImportFileColumnsModel
{
    public IEnumerable<string> ImportFileColumns { get; set; }
    public bool RequireObjectClass { get; set; }

    public CsvImportFileColumnsModel() { }
}
