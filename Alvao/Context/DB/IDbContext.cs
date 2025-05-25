namespace Alvao.Context.DB;

/// <summary>Database context interface that provides connection scope and transaction events.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.Context.DB.IDbContext.html"/>
public interface IDbContext {
    /// <summary>Get current database connection scope.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.Context.DB.IDbContext.html#Alvao_Context_DB_IDbContext_GetScope"/>
    /// <returns>A scope with access to database connection and transaction.</returns>
    IConnectionScope GetScope();

    /// <summary>Occurs when the inner database transaction can be commited, but there is parent scope with an opened transaction. Nothing actually happens with the transaction.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.Context.DB.IDbContext.html#Alvao_Context_DB_IDbContext_InnerTransactionCommited"/>
    event EventHandler<TransactionEventArgs> InnerTransactionCommited;
    /// <summary>Occurs when the database transaction is commited.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.Context.DB.IDbContext.html#Alvao_Context_DB_IDbContext_TransactionCommited"/>
    event EventHandler TransactionCommited;
    /// <summary>Occurs when the database transaction is rolled back.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.Context.DB.IDbContext.html#Alvao_Context_DB_IDbContext_TransactionRolledBack"/>
    event EventHandler<TransactionEventArgs> TransactionRolledBack;
}
