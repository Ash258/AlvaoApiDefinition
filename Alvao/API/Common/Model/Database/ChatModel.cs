using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Settings for AI chat completion models</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ChatModel.html"/>
[Table("dbo.ChatModel")]
public class ChatModel {
    /// <summary>Name of model deployment</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ChatModel.html#Alvao_API_Common_Model_Database_ChatModel_DeploymentName"/>
    /// <remarks>Column <c>DeploymentName</c>: nvarchar(64), not null.</remarks>
    public virtual string DeploymentName { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ChatModel.html#Alvao_API_Common_Model_Database_ChatModel_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Status of chat completions model</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ChatModel.html#Alvao_API_Common_Model_Database_ChatModel_IsEnabled"/>
    /// <remarks>Column <c>IsEnabled</c>: bit, not null.</remarks>
    public virtual bool IsEnabled { get; set; }
    /// <summary>Name of model</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ChatModel.html#Alvao_API_Common_Model_Database_ChatModel_ModelName"/>
    /// <remarks>Column <c>ModelName</c>: nvarchar(64), not null.</remarks>
    public virtual string ModelName { get; set; }
}
