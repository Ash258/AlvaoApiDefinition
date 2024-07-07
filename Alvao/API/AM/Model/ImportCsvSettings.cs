namespace Alvao.API.AM.Model;

public class ImportCsvSettings
{
    public string ConnectionString { get; set; }
    public string DateTimeFormat { get; set; }
    public string DbName { get; set; }
    public int? ImportedByPersonId { get; set; }
    public int? ImportedObjectsParentId { get; set; }
    public string ImportObjectKind { get; set; }
    public bool ImportToDb { get; set; }
    public bool IncludeScrapped { get; set; }
    public Stream InputFile { get; set; }
    public string Separator { get; set; }
    public string ServerName { get; set; }
    public bool SkipErrors { get; set; }
    public bool SkipCheck { get; set; }

    public ImportCsvSettings() { }

    public string[] GetKeyFields() { throw new System.NotImplementedException(); }

    /// <param name="value"> </param>
    public void SetKeyFields(
        string[] value
    )
    { throw new System.NotImplementedException(); }
}
