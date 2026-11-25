namespace Alvao.API.AI.Utils;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Utils.Similarity.html"/>
public static class Similarity {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Utils.Similarity.html#Alvao_API_AI_Utils_Similarity_GetCosineSimilarity_System_Collections_Generic_List_System_Double__System_Collections_Generic_List_System_Double__"/>
    public static double GetCosineSimilarity(List<double> vector1, List<double> vector2) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Utils.Similarity.html#Alvao_API_AI_Utils_Similarity_GetCosineSimilarity_System_Single___System_Single___"/>
    public static double GetCosineSimilarity(float[] vector1, float[] vector2) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Utils.Similarity.html#Alvao_API_AI_Utils_Similarity_GetDistance_System_Double_"/>
    public static double GetDistance(double similarityPercentage) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Utils.Similarity.html#Alvao_API_AI_Utils_Similarity_GetMeanVector_System_Collections_Generic_List_System_Collections_Generic_List_System_Double___"/>
    public static List<double> GetMeanVector(List<List<double>> vectors) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Utils.Similarity.html#Alvao_API_AI_Utils_Similarity_GetMeanVector_System_Collections_Generic_List_System_Single____"/>
    public static float[] GetMeanVector(List<float[]> inputVectors) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Utils.Similarity.html#Alvao_API_AI_Utils_Similarity_GetStandardDeviation_System_Collections_Generic_List_System_Collections_Generic_List_System_Double___"/>
    public static double GetStandardDeviation(List<List<double>> vectors) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Utils.Similarity.html#Alvao_API_AI_Utils_Similarity_GetStandardDeviationVector_System_Collections_Generic_List_System_Collections_Generic_List_System_Double___"/>
    public static List<double> GetStandardDeviationVector(List<List<double>> vectors) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Utils.Similarity.html#Alvao_API_AI_Utils_Similarity_GetWeightedComposite_System_Collections_Generic_List_System_ValueTuple_System_Single___System_Single___"/>
    public static float[] GetWeightedComposite(List<(float[] vector, float weight)> weightedVectors) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Utils.Similarity.html#Alvao_API_AI_Utils_Similarity_GetWeightedComposite_System_Single___System_Single_System_Single___System_Single_System_Single___System_Single_"/>
    public static float[] GetWeightedComposite(float[] v1, float w1, float[] v2, float w2, float[] v3, float w3) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Utils.Similarity.html#Alvao_API_AI_Utils_Similarity_Normalize_System_Single___"/>
    public static float[] Normalize(float[] v) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Utils.Similarity.html#Alvao_API_AI_Utils_Similarity_ToVector_System_String_"/>
    public static List<double> ToVector(this string text) { throw new NotImplementedException(); }
}
