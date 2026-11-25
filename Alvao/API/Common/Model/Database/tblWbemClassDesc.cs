using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Code list of values for the detected HW properties.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemClassDesc.html"/>
[Table("dbo.tblWbemClassDesc")]
public class tblWbemClassDesc {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemClassDesc.html#Alvao_API_Common_Model_Database_tblWbemClassDesc_intPropValueIndex"/>
    /// <remarks>Column <c>intPropValueIndex</c>: int, null.</remarks>
    public virtual int? intPropValueIndex { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemClassDesc.html#Alvao_API_Common_Model_Database_tblWbemClassDesc_txtCLASS"/>
    /// <remarks>Column <c>txtCLASS</c>: nvarchar(255), null.</remarks>
    public virtual string txtCLASS { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemClassDesc.html#Alvao_API_Common_Model_Database_tblWbemClassDesc_txtPropName"/>
    /// <remarks>Column <c>txtPropName</c>: nvarchar(255), null.</remarks>
    [ExplicitKey]
    public virtual string txtPropName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemClassDesc.html#Alvao_API_Common_Model_Database_tblWbemClassDesc_txtPropValueDesc"/>
    /// <remarks>Column <c>txtPropValueDesc</c>: nvarchar(255), null.</remarks>
    public virtual string txtPropValueDesc { get; set; }
}
