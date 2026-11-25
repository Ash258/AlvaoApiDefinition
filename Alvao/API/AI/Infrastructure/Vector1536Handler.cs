using System.Data;
using Dapper;

namespace Alvao.API.AI.Infrastructure;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.Vector1536Handler.html"/>
public sealed class Vector1536Handler : SqlMapper.TypeHandler<float[]>, SqlMapper.ITypeHandler {
    /// <summary>Parse a database value back to a typed value</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.Vector1536Handler.html#Alvao_API_AI_Infrastructure_Vector1536Handler_Parse_System_Object_"/>
    /// <param name="value">The value from the database</param>
    /// <returns>The typed value</returns>
    public override float[] Parse(object value) { throw new NotImplementedException(); }
    /// <summary>Assign the value of a parameter before a command executes</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.Vector1536Handler.html#Alvao_API_AI_Infrastructure_Vector1536Handler_SetValue_System_Data_IDbDataParameter_System_Single___"/>
    /// <param name="parameter">The parameter to configure</param>
    /// <param name="value">Parameter value</param>
    public override void SetValue(IDbDataParameter parameter, float[] value) { throw new NotImplementedException(); }
}
