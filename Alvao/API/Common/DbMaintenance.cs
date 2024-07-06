namespace Alvao.API.Common;

/// <summary>
/// Facade class grouping DB maintenance methods.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_DbMaintenance.htm"/>
public static class DbMaintenance
{

    /// <summary>Rebuilds cache tables.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_DbMaintenance_Repair.htm"/>
    public static void Repair() { throw new System.NotImplementedException(); }

    /// <summary>Rebuilds every table indexes, updates every table statistics and deletes temporary data in database.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_DbMaintenance_Run.htm"/>
    public static void Run() { throw new System.NotImplementedException(); }

    /// <summary>Updates Query report views</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_DbMaintenance_UpdateQueryViews.htm"/>
    public static void UpdateQueryViews() { throw new System.NotImplementedException(); }
}
