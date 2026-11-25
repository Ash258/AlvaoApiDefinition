using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Product License custom fields values.<br/><br/>!!!CAUTION: This class is not part of the API documentation. It was
/// generated from the database documentation
/// </summary>
/// <see href="https://doc.alvao.com/en/26/admin-guide/customization/alvao-database/tables/#U_dbo.ProductCust"/>
[Table("dbo.ProductCust")]
public class ProductCust {
    /// <remarks>Column <c>ProductId</c>: int, not null. References <see cref="tblProduct"/>.</remarks>
    public virtual int ProductId { get; set; }
}
