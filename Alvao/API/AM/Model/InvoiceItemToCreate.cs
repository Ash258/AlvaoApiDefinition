namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.InvoiceItemToCreate.html"/>
public class InvoiceItemToCreate {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.InvoiceItemToCreate.html#Alvao_API_AM_Model_InvoiceItemToCreate_Properties"/>
    public List<InvoiceProperty> Properties { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.InvoiceItemToCreate.html#Alvao_API_AM_Model_InvoiceItemToCreate_Quantity"/>
    public int Quantity { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.InvoiceItemToCreate.html#Alvao_API_AM_Model_InvoiceItemToCreate_TemplateId"/>
    public int TemplateId { get; set; }
}
