namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Model_AutoAssignedLicense.htm"/>
public class AutoAssignedLicense
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_AutoAssignedLicense_AutoAssignFilter.htm"/>
    public string AutoAssignFilter { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_AutoAssignedLicense_Centre.htm"/>
    public string Centre { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_AutoAssignedLicense_Cnt.htm"/>
    public int Cnt { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_AutoAssignedLicense_ItemId.htm"/>
    public int ItemId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_AutoAssignedLicense_LicHistId.htm"/>
    public int LicHistId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_AutoAssignedLicense_LicOrganization.htm"/>
    public string LicOrganization { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_AutoAssignedLicense_ProductId.htm"/>
    public int ProductId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Model_AutoAssignedLicense__ctor.htm"/>
    public AutoAssignedLicense() { }
}
