namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Model_LicenseRelationModel.htm"/>
public class LicenseRelationModel
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_LicenseRelationModel_BeginLicHistName.htm"/>
    public string BeginLicHistName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_LicenseRelationModel_BeginRelationName.htm"/>
    public string BeginRelationName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_LicenseRelationModel_EndLicHistName.htm"/>
    public string EndLicHistName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_LicenseRelationModel_EndRelationName.htm"/>
    public string EndRelationName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_LicenseRelationModel_RelationFullName.htm"/>
    public string RelationFullName { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Model_LicenseRelationModel__ctor.htm"/>
    public LicenseRelationModel() { }
}
