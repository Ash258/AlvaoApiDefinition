using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cache of value list item localizations.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ColumnValueLoc.html"/>
[Table("dbo.ColumnValueLoc")]
public class ColumnValueLoc {
    /// <summary>Custom field ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ColumnValueLoc.html#Alvao_API_Common_Model_Database_ColumnValueLoc_ColumnId"/>
    /// <remarks>Column <c>ColumnId</c>: int, not null.</remarks>
    public virtual int ColumnId { get; set; }
    /// <summary>Localized item value.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ColumnValueLoc.html#Alvao_API_Common_Model_Database_ColumnValueLoc_ColumnValue"/>
    /// <remarks>Column <c>ColumnValue</c>: nvarchar(max), not null.</remarks>
    public virtual string ColumnValue { get; set; }
    /// <summary>Value list item ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ColumnValueLoc.html#Alvao_API_Common_Model_Database_ColumnValueLoc_ColumnValueId"/>
    /// <remarks>Column <c>ColumnValueId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int ColumnValueId { get; set; }
    /// <summary>Localized reduced item value.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ColumnValueLoc.html#Alvao_API_Common_Model_Database_ColumnValueLoc_ColumnValueShort"/>
    /// <remarks>Column <c>ColumnValueShort</c>: nvarchar(max), not null.</remarks>
    public virtual string ColumnValueShort { get; set; }
    /// <summary>Language ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ColumnValueLoc.html#Alvao_API_Common_Model_Database_ColumnValueLoc_LocaleId"/>
    /// <remarks>Column <c>LocaleId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int LocaleId { get; set; }
}
