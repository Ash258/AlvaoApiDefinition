namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Model_ProductInstallation.htm"/>
public class ProductInstallation
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ProductInstallation_Centre.htm"/>
    public string Centre { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ProductInstallation_ObjectId.htm"/>
    public int ObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ProductInstallation_ProductId.htm"/>
    public int ProductId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Model_ProductInstallation__ctor.htm"/>
    public ProductInstallation() { }
}
