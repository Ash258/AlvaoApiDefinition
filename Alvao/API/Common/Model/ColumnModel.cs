namespace Alvao.API.Common.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ColumnModel.html"/>
public class ColumnModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ColumnModel.html#Alvao_API_Common_Model_ColumnModel_ColumnValues"/>
    public IEnumerable<ColumnValue> ColumnValues { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ColumnModel.html#Alvao_API_Common_Model_ColumnModel_DataLength"/>
    public int? DataLength { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ColumnModel.html#Alvao_API_Common_Model_ColumnModel_DataType"/>
    public string DataType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ColumnModel.html#Alvao_API_Common_Model_ColumnModel_Localize"/>
    public bool Localize { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ColumnModel.html#Alvao_API_Common_Model_ColumnModel_Multiline"/>
    public bool Multiline { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ColumnModel.html#Alvao_API_Common_Model_ColumnModel_Precision"/>
    public int? Precision { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ColumnModel.html#Alvao_API_Common_Model_ColumnModel_RoleName"/>
    public string RoleName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ColumnModel.html#Alvao_API_Common_Model_ColumnModel_bUseColumnValue"/>
    public bool bUseColumnValue { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ColumnModel.html#Alvao_API_Common_Model_ColumnModel_iColumnId"/>
    public int iColumnId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ColumnModel.html#Alvao_API_Common_Model_ColumnModel_mDescription"/>
    public string mDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ColumnModel.html#Alvao_API_Common_Model_ColumnModel_nOrder"/>
    public double nOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ColumnModel.html#Alvao_API_Common_Model_ColumnModel_sColumn"/>
    public string sColumn { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ColumnModel.html#Alvao_API_Common_Model_ColumnModel_sTable"/>
    public string sTable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.ColumnModel.html#Alvao_API_Common_Model_ColumnModel_sTitle"/>
    public string sTitle { get; set; }
}
