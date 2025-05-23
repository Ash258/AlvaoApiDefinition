namespace Alvao.Context.DB;

/// <summary>Database context interface that provides connection scope and transaction events.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_Context_DB_IDbContext.htm"/>
public interface IDbContext
{
    /// <summary>Occurs when the inner database transaction can be commited, but there is parent scope with an opened transaction. Nothing actually happens with the transaction.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/E_Alvao_Context_DB_IDbContext_InnerTransactionCommited.htm"/>
    event EventHandler<TransactionEventArgs> InnerTransactionCommited;
    /// <summary>Occurs when the database transaction is commited.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/E_Alvao_Context_DB_IDbContext_TransactionCommited.htm"/>
    event EventHandler TransactionCommited;
    /// <summary>Occurs when the database transaction is rolled back.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/E_Alvao_Context_DB_IDbContext_TransactionRolledBack.htm"/>
    event EventHandler<TransactionEventArgs> TransactionRolledBack;

    /// <summary>Get current database connection scope.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_Context_DB_IDbContext_GetScope.htm"/>
    IConnectionScope GetScope();
}
