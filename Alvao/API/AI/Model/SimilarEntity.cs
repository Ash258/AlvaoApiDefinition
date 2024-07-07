namespace Alvao.API.AI.Model;

public class SimilarEntity
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_SimilarEntity_Id.htm"/>
    public int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_SimilarEntity_Similarity.htm"/>
    public double? Similarity { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_Model_SimilarEntity_Text.htm"/>
    public string Text { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_Model_SimilarEntity__ctor.htm"/>
    public SimilarEntity() { }
}
