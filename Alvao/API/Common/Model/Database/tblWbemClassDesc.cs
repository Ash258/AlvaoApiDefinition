using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Code list of values for the detected HW properties.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemClassDesc.html"/>
[Table("dbo.tblWbemClassDesc")]
public class tblWbemClassDesc {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemClassDesc.html#Alvao_API_Common_Model_Database_tblWbemClassDesc_intPropValueIndex"/>
    public virtual int? intPropValueIndex { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemClassDesc.html#Alvao_API_Common_Model_Database_tblWbemClassDesc_txtCLASS"/>
    public virtual string txtCLASS { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemClassDesc.html#Alvao_API_Common_Model_Database_tblWbemClassDesc_txtPropName"/>
    [ExplicitKey]
    public virtual string txtPropName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblWbemClassDesc.html#Alvao_API_Common_Model_Database_tblWbemClassDesc_txtPropValueDesc"/>
    public virtual string txtPropValueDesc { get; set; }
}
