namespace Alvao.API.AI.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AI_Model_VectorType.htm"/>
[FlagsAttribute]
public enum VectorType
{
    None = 0,
    Communication = 1,
    Fields = 2,
    Objects = 4,
    All = 7,
}
