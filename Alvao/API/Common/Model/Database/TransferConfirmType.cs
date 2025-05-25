using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Method of the assets takeover signing.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TransferConfirmType.html"/>
[Table("dbo.TransferConfirmType")]
public class TransferConfirmType {
    /// <summary>Name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TransferConfirmType.html#Alvao_API_Common_Model_Database_TransferConfirmType_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Item ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TransferConfirmType.html#Alvao_API_Common_Model_Database_TransferConfirmType_id"/>
    [ExplicitKey]
    public virtual int id { get; set; }
}
