using System.Data;
using Microsoft.Data.SqlClient;

namespace Alvao.Context.DB;

public interface IConnectionScope : IDisposable
{
    string ClosestSavePointName { get; }
    IDbConnection Connection { get; }
    SqlConnection LegacyConnection { get; }
    SqlTransaction LegacyTransaction { get; }
    IDbTransaction Transaction { get; }
    void BeginTransaction(
    IsolationLevel? level = null,
    bool useSavePoint = false
);
    void CommitTransaction();
    void RollbackTransaction();
}
