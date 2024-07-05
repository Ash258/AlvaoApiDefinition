namespace Alvao.Context.DB;

public interface IDbContext
{
    event EventHandler<TransactionEventArgs> InnerTransactionCommited;
    event EventHandler TransactionCommited;
    event EventHandler<TransactionEventArgs> TransactionRolledBack;
    IConnectionScope GetScope();
}
