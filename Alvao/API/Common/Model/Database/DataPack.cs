using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Data packages inserted by database updates
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_DataPack.htm"/>
[TableAttribute("dbo.DataPack")]
public class DataPack
{
    /// <summary>Data package identifier</summary>
    [ExplicitKeyAttribute]
    public virtual string id { get; set; }
    /// <summary>Date of insertion</summary>
    public virtual DateTime InsertedDate { get; set; }

    public DataPack() { }
}
