using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>External knowledge article imported from an external service.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticle.html"/>
[Table("dbo.ExternalArticle")]
public class ExternalArticle {
    /// <summary>Change tracking tag (ETag) of the content from the external service.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticle.html#Alvao_API_Common_Model_Database_ExternalArticle_CTag"/>
    public virtual string CTag { get; set; }
    /// <summary>Identifier of the source file in the external service.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticle.html#Alvao_API_Common_Model_Database_ExternalArticle_FileId"/>
    public virtual string FileId { get; set; }
    /// <summary>Name of the source file.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticle.html#Alvao_API_Common_Model_Database_ExternalArticle_FileName"/>
    public virtual string FileName { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticle.html#Alvao_API_Common_Model_Database_ExternalArticle_Id"/>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Date and time the source file was last modified (UTC).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticle.html#Alvao_API_Common_Model_Database_ExternalArticle_ModifiedTime"/>
    public virtual DateTimeOffset ModifiedTime { get; set; }
    /// <summary>URL of the source file.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ExternalArticle.html#Alvao_API_Common_Model_Database_ExternalArticle_Url"/>
    public virtual string Url { get; set; }
}
