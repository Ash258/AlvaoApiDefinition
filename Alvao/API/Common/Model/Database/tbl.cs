using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// ID of the objects types. Texts in tblDict.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblClass.htm"/>
[TableAttribute("dbo.tblClass")]
public class tblClass
{
    public virtual bool bComputer { get; set; }
    public virtual int? DefaultObjectTemplateNodeId { get; set; }
    /// <summary>Class Id</summary>
    [ExplicitKeyAttribute]
    public virtual int intClassId { get; set; }

    public tblClass() { }
}
