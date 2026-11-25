using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>External knowledge article imported from an external service.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticle.html"/>
[Table("dbo.ExternalArticle")]
public class ExternalArticle {
    /// <summary>Change tracking tag (ETag) of the content from the external service.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticle.html#Alvao_API_Common_Model_Database_ExternalArticle_CTag"/>
    /// <remarks>Column <c>CTag</c>: nvarchar(64), null.</remarks>
    public virtual string CTag { get; set; }
    /// <summary>Identifier of the source file in the external service.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticle.html#Alvao_API_Common_Model_Database_ExternalArticle_FileId"/>
    /// <remarks>Column <c>FileId</c>: nvarchar(128), not null.</remarks>
    public virtual string FileId { get; set; }
    /// <summary>Name of the source file.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticle.html#Alvao_API_Common_Model_Database_ExternalArticle_FileName"/>
    /// <remarks>Column <c>FileName</c>: nvarchar(128), not null.</remarks>
    public virtual string FileName { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticle.html#Alvao_API_Common_Model_Database_ExternalArticle_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Date and time the source file was last modified (UTC).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticle.html#Alvao_API_Common_Model_Database_ExternalArticle_ModifiedTime"/>
    /// <remarks>Column <c>ModifiedTime</c>: datetimeoffset, not null.</remarks>
    public virtual DateTimeOffset ModifiedTime { get; set; }
    /// <summary>URL of the source file.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticle.html#Alvao_API_Common_Model_Database_ExternalArticle_Url"/>
    /// <remarks>Column <c>Url</c>: nvarchar(256), not null.</remarks>
    public virtual string Url { get; set; }
}
