namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Model.EmbeddingModelStatus.html"/>
public enum EmbeddingModelStatus {
    Aborted = 4,
    Active = 1,
    Disabled = 0,
    FastReindexing = 3,
    Reindexing = 2,
}
