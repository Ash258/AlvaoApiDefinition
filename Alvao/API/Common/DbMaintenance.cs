namespace Alvao.API.Common;

/// <summary>Facade class grouping DB maintenance methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.DbMaintenance.html"/>
public static class DbMaintenance {
    /// <summary>Removes and summarizes data in Perf.* tables.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.DbMaintenance.html#Alvao_API_Common_DbMaintenance_PurgePerfData"/>
    public static Task PurgePerfData() { throw new NotImplementedException(); }
    /// <summary>Rebuilds cache tables.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.DbMaintenance.html#Alvao_API_Common_DbMaintenance_Repair_System_Boolean_"/>
    public static void Repair(bool forceRun = false) { throw new NotImplementedException(); }
    /// <summary>Rebuilds every table indexes, updates every table statistics and deletes temporary data in database.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.DbMaintenance.html#Alvao_API_Common_DbMaintenance_Run"/>
    public static void Run() { throw new NotImplementedException(); }
    /// <summary>Updates Query report views</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.DbMaintenance.html#Alvao_API_Common_DbMaintenance_UpdateQueryViews"/>
    /// <exception cref="QueryViewUpdateException">Throws when any error occurs. Message contains all error messages separated with new line.</exception>
    public static void UpdateQueryViews() { throw new NotImplementedException(); }
}
