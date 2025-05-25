using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Value lists for custom fields.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tColumnValue.html"/>
[Table("dbo.tColumnValue")]
public class tColumnValue {
    /// <summary>Full name including path via parent items.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tColumnValue.html#Alvao_API_Common_Model_Database_tColumnValue_ColumnValueShort"/>
    public virtual string ColumnValueShort { get; set; }
    /// <summary>Parent tree item.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tColumnValue.html#Alvao_API_Common_Model_Database_tColumnValue_ParentValue"/>
    public virtual int? ParentValue { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tColumnValue.html#Alvao_API_Common_Model_Database_tColumnValue_iColumnValueId"/>
    [Key]
    public virtual int iColumnValueId { get; set; }
    /// <summary>Link to custom field record.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tColumnValue.html#Alvao_API_Common_Model_Database_tColumnValue_liColumnId"/>
    public virtual int liColumnId { get; set; }
    /// <summary>NULL represents an item on the list of values applies to all services. The view is otherwise limited only to the configured service.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tColumnValue.html#Alvao_API_Common_Model_Database_tColumnValue_liHdSectionId"/>
    public virtual int? liHdSectionId { get; set; }
    /// <summary>Displayed item name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tColumnValue.html#Alvao_API_Common_Model_Database_tColumnValue_mColumnValue"/>
    public virtual string mColumnValue { get; set; }
    /// <summary>Order for displaying items, sorted from lowest to highest number.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tColumnValue.html#Alvao_API_Common_Model_Database_tColumnValue_nOrder"/>
    public virtual double nOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tColumnValue.html#Alvao_API_Common_Model_Database_tColumnValue_sExtra1"/>
    public virtual string sExtra1 { get; set; }
}
