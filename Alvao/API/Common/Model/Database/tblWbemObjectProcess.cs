using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Hardware &quot;Blacklist&quot;.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObjectProcess.html"/>
[Table("dbo.tblWbemObjectProcess")]
public class tblWbemObjectProcess {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObjectProcess.html#Alvao_API_Common_Model_Database_tblWbemObjectProcess_bolClearObjectProp"/>
    /// <remarks>Column <c>bolClearObjectProp</c>: bit, not null.</remarks>
    public virtual bool bolClearObjectProp { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObjectProcess.html#Alvao_API_Common_Model_Database_tblWbemObjectProcess_bolSetObjectAsVirtual"/>
    /// <remarks>Column <c>bolSetObjectAsVirtual</c>: bit, not null.</remarks>
    public virtual bool bolSetObjectAsVirtual { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObjectProcess.html#Alvao_API_Common_Model_Database_tblWbemObjectProcess_txtCLASS"/>
    /// <remarks>Column <c>txtCLASS</c>: nvarchar(255), null.</remarks>
    [ExplicitKey]
    public virtual string txtCLASS { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObjectProcess.html#Alvao_API_Common_Model_Database_tblWbemObjectProcess_txtPropName"/>
    /// <remarks>Column <c>txtPropName</c>: nvarchar(255), null.</remarks>
    public virtual string txtPropName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObjectProcess.html#Alvao_API_Common_Model_Database_tblWbemObjectProcess_txtPropValue"/>
    /// <remarks>Column <c>txtPropValue</c>: nvarchar(255), null.</remarks>
    public virtual string txtPropValue { get; set; }
}
