using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Mapping properties to system functions.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblPropertyMap.htm"/>
[TableAttribute("dbo.tblPropertyMap")]
public class tblPropertyMap
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblPropertyMap_intPropertyMapId.htm"/>
    [KeyAttribute]
    public virtual int intPropertyMapId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblPropertyMap_lintKindId.htm"/>
    public virtual int? lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblPropertyMap_lintMapKindId.htm"/>
    public virtual int? lintMapKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblPropertyMap_lintMapObjClassId.htm"/>
    public virtual int? lintMapObjClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblPropertyMap_lintMapObjKindId.htm"/>
    public virtual int? lintMapObjKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblPropertyMap_lintObjClassId.htm"/>
    public virtual int? lintObjClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblPropertyMap_lintObjKindId.htm"/>
    public virtual int? lintObjKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblPropertyMap_lintPropertyMapTypeId.htm"/>
    public virtual int? lintPropertyMapTypeId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblPropertyMap__ctor.htm"/>
    public tblPropertyMap() { }
}
