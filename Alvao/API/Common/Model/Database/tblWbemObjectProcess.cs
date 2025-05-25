using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Hardware &quot;Blacklist&quot;.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObjectProcess.html"/>
[Table("dbo.tblWbemObjectProcess")]
public class tblWbemObjectProcess {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObjectProcess.html#Alvao_API_Common_Model_Database_tblWbemObjectProcess_bolClearObjectProp"/>
    public virtual bool bolClearObjectProp { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObjectProcess.html#Alvao_API_Common_Model_Database_tblWbemObjectProcess_bolSetObjectAsVirtual"/>
    public virtual bool bolSetObjectAsVirtual { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObjectProcess.html#Alvao_API_Common_Model_Database_tblWbemObjectProcess_txtCLASS"/>
    [ExplicitKey]
    public virtual string txtCLASS { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObjectProcess.html#Alvao_API_Common_Model_Database_tblWbemObjectProcess_txtPropName"/>
    public virtual string txtPropName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemObjectProcess.html#Alvao_API_Common_Model_Database_tblWbemObjectProcess_txtPropValue"/>
    public virtual string txtPropValue { get; set; }
}
