using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cache of value list item localizations.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ColumnValueLoc.html"/>
[Table("dbo.ColumnValueLoc")]
public class ColumnValueLoc {
    /// <summary>Custom field ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ColumnValueLoc.html#Alvao_API_Common_Model_Database_ColumnValueLoc_ColumnId"/>
    public virtual int ColumnId { get; set; }
    /// <summary>Localized item value.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ColumnValueLoc.html#Alvao_API_Common_Model_Database_ColumnValueLoc_ColumnValue"/>
    public virtual string ColumnValue { get; set; }
    /// <summary>Value list item ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ColumnValueLoc.html#Alvao_API_Common_Model_Database_ColumnValueLoc_ColumnValueId"/>
    [ExplicitKey]
    public virtual int ColumnValueId { get; set; }
    /// <summary>Localized reduced item value.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ColumnValueLoc.html#Alvao_API_Common_Model_Database_ColumnValueLoc_ColumnValueShort"/>
    public virtual string ColumnValueShort { get; set; }
    /// <summary>Language ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ColumnValueLoc.html#Alvao_API_Common_Model_Database_ColumnValueLoc_LocaleId"/>
    public virtual int LocaleId { get; set; }
}
