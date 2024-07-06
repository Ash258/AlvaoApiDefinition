using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Translations of custom fields values in all languages ​​used.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vColumnValueLoc.htm"/>
[TableAttribute("dbo.vColumnValueLoc")]
public class vColumnValueLoc
{
    public virtual int ColumnValueLocaleId { get; set; }
    public virtual string ColumnValueShort { get; set; }
    public virtual int iColumnValueId { get; set; }
    public virtual int liColumnId { get; set; }
    public virtual int? liHdSectionId { get; set; }
    public virtual string LocalizedColumnValue { get; set; }
    public virtual string LocalizedColumnValueShort { get; set; }
    public virtual string mColumnValue { get; set; }
    public virtual double nOrder { get; set; }
    public virtual int? ParentValue { get; set; }
    public virtual string sExtra1 { get; set; }

    public vColumnValueLoc() { }
}
