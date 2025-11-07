using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>External services</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ExternalService.html"/>
[Table("dbo.ExternalService")]
public class ExternalService {
    /// <summary>ID of external service</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ExternalService.html#Alvao_API_Common_Model_Database_ExternalService_Id"/>
    [ExplicitKey]
    public virtual int Id { get; set; }
    /// <summary>Name of external service</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ExternalService.html#Alvao_API_Common_Model_Database_ExternalService_Name"/>
    public virtual string Name { get; set; }
}
