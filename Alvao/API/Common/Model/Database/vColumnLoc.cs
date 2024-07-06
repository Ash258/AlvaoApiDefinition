using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Translations of the names and descriptions of custom fields in all languages ​​used.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vColumnLoc.htm"/>
[TableAttribute("dbo.vColumnLoc")]
public class vColumnLoc
{
    public virtual bool bUseColumnValue { get; set; }
    public virtual int ColumnLocaleId { get; set; }
    public virtual int iColumnId { get; set; }
    public virtual bool Localize { get; set; }
    public virtual string LocalizedDescription { get; set; }
    public virtual string LocalizedTitle { get; set; }
    public virtual int? MaxLength { get; set; }
    public virtual string mDescription { get; set; }
    public virtual bool Multiline { get; set; }
    public virtual double nOrder { get; set; }
    public virtual DateTime? Removed { get; set; }
    public virtual int? RoleId { get; set; }
    public virtual string sColumn { get; set; }
    public virtual string sTable { get; set; }
    public virtual string sTitle { get; set; }
    public virtual string Type { get; set; }

    public vColumnLoc() { }
}
