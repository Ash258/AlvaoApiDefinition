namespace Alvao.API.AI.Model;

[FlagsAttribute]
public enum VectorType
{
    None = 0,
    Communication = 1,
    Fields = 2,
    Objects = 4,
    All = 7,
}
