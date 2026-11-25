namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Model.VectorType.html"/>
[Flags]
public enum VectorType {
    All = Communication | Fields | Objects | Description,
    Communication = 1,
    Description = 8,
    Fields = 2,
    None = 0,
    Objects = 4,
}
