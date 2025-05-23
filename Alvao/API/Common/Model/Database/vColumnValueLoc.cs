using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Translations of custom fields values in all languages ​​used.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vColumnValueLoc.htm"/>
[TableAttribute("dbo.vColumnValueLoc")]
public class vColumnValueLoc {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnValueLoc_ColumnValueLocaleId.htm"/>
    public virtual int ColumnValueLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnValueLoc_ColumnValueShort.htm"/>
    public virtual string ColumnValueShort { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnValueLoc_iColumnValueId.htm"/>
    public virtual int iColumnValueId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnValueLoc_liColumnId.htm"/>
    public virtual int liColumnId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnValueLoc_liHdSectionId.htm"/>
    public virtual int? liHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnValueLoc_LocalizedColumnValue.htm"/>
    public virtual string LocalizedColumnValue { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnValueLoc_LocalizedColumnValueShort.htm"/>
    public virtual string LocalizedColumnValueShort { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnValueLoc_mColumnValue.htm"/>
    public virtual string mColumnValue { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnValueLoc_nOrder.htm"/>
    public virtual double nOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnValueLoc_ParentValue.htm"/>
    public virtual int? ParentValue { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnValueLoc_sExtra1.htm"/>
    public virtual string sExtra1 { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vColumnValueLoc__ctor.htm"/>
    public vColumnValueLoc() { }
}
