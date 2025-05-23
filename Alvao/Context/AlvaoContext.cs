using Alvao.Context.DB;
using Volo.Abp.EntityFrameworkCore;

namespace Alvao.Context;

/// <summary>Class provides access to current database connection scope.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_Context_AlvaoContext.htm"/>
public static class AlvaoContext
{

    /// <summary>Get connection scope for current database.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_Context_AlvaoContext_GetConnectionScope.htm"/>
    public static IConnectionScope GetConnectionScope() { throw new System.NotImplementedException(); }
}
