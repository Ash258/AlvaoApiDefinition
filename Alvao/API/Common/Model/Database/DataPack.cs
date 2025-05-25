using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Data packages inserted by database updates</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DataPack.html"/>
[Table("dbo.DataPack")]
public class DataPack {
    /// <summary>Date of insertion</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DataPack.html#Alvao_API_Common_Model_Database_DataPack_InsertedDate"/>
    public virtual DateTime InsertedDate { get; set; }
    /// <summary>Data package identifier</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DataPack.html#Alvao_API_Common_Model_Database_DataPack_id"/>
    [ExplicitKey]
    public virtual string id { get; set; }
}
