using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Data packages inserted by database updates</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_DataPack.htm"/>
[TableAttribute("dbo.DataPack")]
public class DataPack {
    /// <summary>Data package identifier</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DataPack_id.htm"/>
    [ExplicitKeyAttribute]
    public virtual string id { get; set; }
    /// <summary>Date of insertion</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DataPack_InsertedDate.htm"/>
    public virtual DateTime InsertedDate { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_DataPack__ctor.htm"/>
    public DataPack() { }
}
