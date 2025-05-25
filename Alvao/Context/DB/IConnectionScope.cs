using System.Data;
using Microsoft.Data.SqlClient;

namespace Alvao.Context.DB;

/// <summary>Provides access to database connection and transaction operations.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.Context.DB.IConnectionScope.html"/>
public interface IConnectionScope : IDisposable {
    /// <summary>Get the closest parent save point name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.Context.DB.IConnectionScope.html#Alvao_Context_DB_IConnectionScope_ClosestSavePointName"/>
    string ClosestSavePointName { get; }
    /// <summary>Get opened connection to current database.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.Context.DB.IConnectionScope.html#Alvao_Context_DB_IConnectionScope_Connection"/>
    IDbConnection Connection { get; }
    /// <summary>Get opened legacy connection to current database.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.Context.DB.IConnectionScope.html#Alvao_Context_DB_IConnectionScope_LegacyConnection"/>
    SqlConnection LegacyConnection { get; }
    /// <summary>Get active legacy database transaction.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.Context.DB.IConnectionScope.html#Alvao_Context_DB_IConnectionScope_LegacyTransaction"/>
    SqlTransaction LegacyTransaction { get; }
    /// <summary>Get active database transaction.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.Context.DB.IConnectionScope.html#Alvao_Context_DB_IConnectionScope_Transaction"/>
    IDbTransaction Transaction { get; }
    /// <summary>Starts a database transaction.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.Context.DB.IConnectionScope.html#Alvao_Context_DB_IConnectionScope_BeginTransaction_System_Nullable_System_Data_IsolationLevel__System_Boolean_"/>
    /// <param name="level">The isolation level under which the transaction should run.</param>
    /// <param name="useSavePoint">Whether to use a savepoint for inner transaction. If this inner transaction was rolled back, it would only be rolled back to this savepoint. Outer transaction would continue.</param>
    void BeginTransaction(IsolationLevel? level = null, bool useSavePoint = false);
    /// <summary>Commits the database transaction.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.Context.DB.IConnectionScope.html#Alvao_Context_DB_IConnectionScope_CommitTransaction"/>
    void CommitTransaction();
    /// <summary>Rolls back a transaction from a pending state.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.Context.DB.IConnectionScope.html#Alvao_Context_DB_IConnectionScope_RollbackTransaction"/>
    void RollbackTransaction();
}
