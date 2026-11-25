using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Data packages inserted by database updates</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DataPack.html"/>
[Table("dbo.DataPack")]
public class DataPack {
    /// <summary>Date of insertion</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DataPack.html#Alvao_API_Common_Model_Database_DataPack_InsertedDate"/>
    /// <remarks>Column <c>InsertedDate</c>: datetime, not null.</remarks>
    public virtual DateTime InsertedDate { get; set; }
    /// <summary>Data package identifier</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DataPack.html#Alvao_API_Common_Model_Database_DataPack_id"/>
    /// <remarks>Column <c>id</c>: nvarchar(128), not null.</remarks>
    [ExplicitKey]
    public virtual string id { get; set; }
}
