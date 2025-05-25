using Alvao.Context.DB;

namespace Alvao.Context;

/// <summary>Class provides access to current database connection scope.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.Context.AlvaoContext.html"/>
public static class AlvaoContext {
    /// <summary>Get or set database context provider.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.Context.AlvaoContext.html#Alvao_Context_AlvaoContext_DbContextProvider"/>
    public static IDbContextProvider DbContextProvider { get; set; }
    /// <summary>Get connection scope for current database.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.Context.AlvaoContext.html#Alvao_Context_AlvaoContext_GetConnectionScope"/>
    /// <returns>Connection scope based on the context provider DbContextProvider.</returns>
    public static IConnectionScope GetConnectionScope() { throw new System.NotImplementedException(); }
}
