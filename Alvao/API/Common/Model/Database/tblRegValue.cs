using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Detection - values of detected records from the register.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblRegValue.htm"/>
[TableAttribute("dbo.tblRegValue")]
public class tblRegValue
{
    [KeyAttribute]
    public virtual int intRegValueId { get; set; }
    public virtual int lintDetectId { get; set; }
    public virtual int lintRootRegKeyId { get; set; }
    public virtual string txtName { get; set; }
    public virtual string txtPath { get; set; }
    public virtual string txtValue { get; set; }

    public tblRegValue() { }
}
