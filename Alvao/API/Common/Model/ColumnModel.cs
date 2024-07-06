namespace Alvao.API.Common.Model;

public class ColumnModel
{
    public bool bUseColumnValue { get; set; }
    public IEnumerable<ColumnValue> ColumnValues { get; set; }
    public int? DataLength { get; set; }
    public string DataType { get; set; }
    public int iColumnId { get; set; }
    public bool Localize { get; set; }
    public string mDescription { get; set; }
    public bool Multiline { get; set; }
    public double nOrder { get; set; }
    public string RoleName { get; set; }
    public string sColumn { get; set; }
    public string sTable { get; set; }
    public string sTitle { get; set; }

    public ColumnModel() { }
}
