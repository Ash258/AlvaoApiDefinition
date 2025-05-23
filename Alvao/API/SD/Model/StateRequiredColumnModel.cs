using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Model_StateRequiredColumnModel.htm"/>
public class StateRequiredColumnModel : vColumnLoc {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_StateRequiredColumnModel_AreObjects.htm"/>
    public bool AreObjects { get; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnLoc_bUseColumnValue.htm"/>
    public virtual bool bUseColumnValue { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnLoc_ColumnLocaleId.htm"/>
    public virtual int ColumnLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnLoc_iColumnId.htm"/>
    public virtual int iColumnId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_StateRequiredColumnModel_IsDeadline.htm"/>
    public bool IsDeadline { get; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_StateRequiredColumnModel_IsSystem.htm"/>
    public bool IsSystem { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnLoc_Localize.htm"/>
    public virtual bool Localize { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnLoc_LocalizedDescription.htm"/>
    public virtual string LocalizedDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnLoc_LocalizedTitle.htm"/>
    public virtual string LocalizedTitle { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnLoc_MaxLength.htm"/>
    public virtual int? MaxLength { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnLoc_mDescription.htm"/>
    public virtual string mDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnLoc_Multiline.htm"/>
    public virtual bool Multiline { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnLoc_nOrder.htm"/>
    public virtual double nOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnLoc_Removed.htm"/>
    public virtual DateTime? Removed { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnLoc_RoleId.htm"/>
    public virtual int? RoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnLoc_sColumn.htm"/>
    public virtual string sColumn { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnLoc_sTable.htm"/>
    public virtual string sTable { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnLoc_sTitle.htm"/>
    public virtual string sTitle { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vColumnLoc_Type.htm"/>
    public virtual string Type { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_StateRequiredColumnModel__ctor.htm"/>
    public StateRequiredColumnModel() { }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_StateRequiredColumnModel_ToString.htm"/>
    public override string ToString() { throw new System.NotImplementedException(); }
}
