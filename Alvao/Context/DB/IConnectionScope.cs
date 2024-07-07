using Microsoft.Data.SqlClient;
using System.Data;

namespace Alvao.Context.DB;

/// <summary>
/// Provides access to database connection and transaction operations.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_Context_DB_IConnectionScope.htm"/>
public interface IConnectionScope : IDisposable
{
    /// <summary>Get the closest parent save point name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_Context_DB_IConnectionScope_ClosestSavePointName.htm"/>
    string ClosestSavePointName { get; }
    /// <summary>Get opened connection to current database.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_Context_DB_IConnectionScope_Connection.htm"/>
    IDbConnection Connection { get; }
    /// <summary>Get opened legacy connection to current database.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_Context_DB_IConnectionScope_LegacyConnection.htm"/>
    SqlConnection LegacyConnection { get; }
    /// <summary>Get active legacy database transaction.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_Context_DB_IConnectionScope_LegacyTransaction.htm"/>
    SqlTransaction LegacyTransaction { get; }
    /// <summary>Get active database transaction.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_Context_DB_IConnectionScope_Transaction.htm"/>
    IDbTransaction Transaction { get; }

    /// <summary>Starts a database transaction.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_Context_DB_IConnectionScope_BeginTransaction.htm"/>
    ///
    /// <param name="level">The isolation level under which the transaction should run.</param>
    /// <param name="useSavePoint">Whether to use a savepoint for inner transaction. If this inner transaction was rolled back, it would only be rolled back to this savepoint. Outer transaction would continue.</param>
    void BeginTransaction(
        IsolationLevel? level = null,
        bool useSavePoint = false
    );

    /// <summary>Commits the database transaction.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_Context_DB_IConnectionScope_CommitTransaction.htm"/>
    void CommitTransaction();

    /// <summary>Rolls back a transaction from a pending state.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_Context_DB_IConnectionScope_RollbackTransaction.htm"/>
    void RollbackTransaction();
}
