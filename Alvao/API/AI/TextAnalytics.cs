namespace Alvao.API.AI;

/// <summary>Facade for TextAnalytics methods. ALVAO connection to Azure.AI.TextAnalytics service.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.TextAnalytics.html"/>
public static class TextAnalytics {
    /// <summary>Returns extracted key phrases from text.</summary>
    /// <param name="text">Text to extract key phrases from.</param>
    /// <returns>Key phrases as collection</returns>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.TextAnalytics.html#Alvao_API_AI_TextAnalytics_ExtractKeyPhrases_System_String_"/>
    public static IEnumerable<string> ExtractKeyPhrases(string text) { throw new System.NotImplementedException(); }
    /// <summary>Returns extracted key phrases from text or original query if there is no extracted phrases. This function should never fail or throw an exception.</summary>
    /// <param name="text">Text to extract key phrases from.</param>
    /// <returns>Key phrases as string seperated by space</returns>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.TextAnalytics.html#Alvao_API_AI_TextAnalytics_ExtractKeyPhrasesString_System_String_"/>
    public static string ExtractKeyPhrasesString(string text) { throw new System.NotImplementedException(); }
}
