using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Type of an asset code (Barcode/QR Code)</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintTemplateAssetCodeType.html"/>
[Table("dbo.PrintTemplateAssetCodeType")]
public class PrintTemplateAssetCodeType {
    /// <summary>Asset code type name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintTemplateAssetCodeType.html#Alvao_API_Common_Model_Database_PrintTemplateAssetCodeType_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(128), not null.</remarks>
    public virtual string Name { get; set; }
    /// <summary>Asset code type ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PrintTemplateAssetCodeType.html#Alvao_API_Common_Model_Database_PrintTemplateAssetCodeType_id"/>
    /// <remarks>Column <c>id</c>: tinyint, not null.</remarks>
    [ExplicitKey]
    public virtual byte id { get; set; }
}
