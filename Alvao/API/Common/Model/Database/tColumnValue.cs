using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Value lists for custom fields.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tColumnValue.html"/>
[Table("dbo.tColumnValue")]
public class tColumnValue {
    /// <summary>Full name including path via parent items.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tColumnValue.html#Alvao_API_Common_Model_Database_tColumnValue_ColumnValueShort"/>
    /// <remarks>Column <c>ColumnValueShort</c>: nvarchar(max), not null.</remarks>
    public virtual string ColumnValueShort { get; set; }
    /// <summary>Parent tree item.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tColumnValue.html#Alvao_API_Common_Model_Database_tColumnValue_ParentValue"/>
    /// <remarks>Column <c>ParentValue</c>: int, null. References <see cref="tColumnValue"/>.</remarks>
    public virtual int? ParentValue { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tColumnValue.html#Alvao_API_Common_Model_Database_tColumnValue_iColumnValueId"/>
    /// <remarks>Column <c>iColumnValueId</c>: int, not null.</remarks>
    [Key]
    public virtual int iColumnValueId { get; set; }
    /// <summary>Link to custom field record.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tColumnValue.html#Alvao_API_Common_Model_Database_tColumnValue_liColumnId"/>
    /// <remarks>Column <c>liColumnId</c>: int, not null. References <see cref="tColumn"/>.</remarks>
    public virtual int liColumnId { get; set; }
    /// <summary>
    /// NULL represents an item on the list of values applies to all services. The view is otherwise limited only to the
    /// configured service.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tColumnValue.html#Alvao_API_Common_Model_Database_tColumnValue_liHdSectionId"/>
    /// <remarks>Column <c>liHdSectionId</c>: int, null. References <see cref="tHdSection"/>.</remarks>
    public virtual int? liHdSectionId { get; set; }
    /// <summary>Displayed item name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tColumnValue.html#Alvao_API_Common_Model_Database_tColumnValue_mColumnValue"/>
    /// <remarks>Column <c>mColumnValue</c>: nvarchar(max), not null.</remarks>
    public virtual string mColumnValue { get; set; }
    /// <summary>Order for displaying items, sorted from lowest to highest number.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tColumnValue.html#Alvao_API_Common_Model_Database_tColumnValue_nOrder"/>
    /// <remarks>Column <c>nOrder</c>: float, not null.</remarks>
    public virtual double nOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tColumnValue.html#Alvao_API_Common_Model_Database_tColumnValue_sExtra1"/>
    /// <remarks>Column <c>sExtra1</c>: nvarchar(255), null.</remarks>
    public virtual string sExtra1 { get; set; }
}
