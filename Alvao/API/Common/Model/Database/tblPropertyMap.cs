using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Mapping properties to system functions.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblPropertyMap.htm"/>
[TableAttribute("dbo.tblPropertyMap")]
public class tblPropertyMap
{
    [KeyAttribute]
    public virtual int intPropertyMapId { get; set; }
    public virtual int? lintKindId { get; set; }
    public virtual int? lintMapKindId { get; set; }
    public virtual int? lintMapObjClassId { get; set; }
    public virtual int? lintMapObjKindId { get; set; }
    public virtual int? lintObjClassId { get; set; }
    public virtual int? lintObjKindId { get; set; }
    public virtual int? lintPropertyMapTypeId { get; set; }

    public tblPropertyMap() { }
}
