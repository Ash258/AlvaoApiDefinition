using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model;

public class StateRequiredColumnModel : vColumnLoc
{
    public bool AreObjects { get; }
    public virtual bool bUseColumnValue { get; set; }
    public virtual int ColumnLocaleId { get; set; }
    public virtual int iColumnId { get; set; }
    public bool IsDeadline { get; }
    public bool IsSystem { get; set; }
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

    public StateRequiredColumnModel() { }

    public override string ToString() { throw new System.NotImplementedException(); }
}
