namespace Alvao.API.Common.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_ColumnModel.htm"/>
public class ColumnModel {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_ColumnModel_bUseColumnValue.htm"/>
    public bool bUseColumnValue { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_ColumnModel_ColumnValues.htm"/>
    public IEnumerable<ColumnValue> ColumnValues { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_ColumnModel_DataLength.htm"/>
    public int? DataLength { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_ColumnModel_DataType.htm"/>
    public string DataType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_ColumnModel_iColumnId.htm"/>
    public int iColumnId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_ColumnModel_Localize.htm"/>
    public bool Localize { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_ColumnModel_mDescription.htm"/>
    public string mDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_ColumnModel_Multiline.htm"/>
    public bool Multiline { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_ColumnModel_nOrder.htm"/>
    public double nOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_ColumnModel_RoleName.htm"/>
    public string RoleName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_ColumnModel_sColumn.htm"/>
    public string sColumn { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_ColumnModel_sTable.htm"/>
    public string sTable { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_ColumnModel_sTitle.htm"/>
    public string sTitle { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_ColumnModel__ctor.htm"/>
    public ColumnModel() { }
}
