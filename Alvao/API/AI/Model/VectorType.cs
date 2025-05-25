namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.Model.VectorType.html"/>
[Flags]
public enum VectorType {
    All = Communication | Fields | Objects,
    Communication = 1,
    Fields = 2,
    None = 0,
    Objects = 4,
}
