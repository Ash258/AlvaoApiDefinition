namespace Alvao.API.AI.Utils;

public static class Similarity
{

    /// <param name="vector1"> </param>
    /// <param name="vector2"> </param>
    public static double GetCosineSimilarity(
        List<double> vector1,
        List<double> vector2
    )
    { throw new System.NotImplementedException(); }

    /// <param name="vectors"> </param>
    public static List<double> GetMeanVector(
        List<List<double>> vectors
    )
    { throw new System.NotImplementedException(); }

    /// <param name="vectors"> </param>
    public static double GetStandardDeviation(
        List<List<double>> vectors
    )
    { throw new System.NotImplementedException(); }

    /// <param name="vectors"> </param>
    public static List<double> GetStandardDeviationVector(
        List<List<double>> vectors
    )
    { throw new System.NotImplementedException(); }

    /// <param name="text"> </param>
    public static List<double> ToVector(
        this string text
    )
    { throw new System.NotImplementedException(); }
}
