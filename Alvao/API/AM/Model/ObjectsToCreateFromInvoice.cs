namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectsToCreateFromInvoice.html"/>
public class ObjectsToCreateFromInvoice {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectsToCreateFromInvoice.html#Alvao_API_AM_Model_ObjectsToCreateFromInvoice_DocumentInfo"/>
    public AMDocumentsModel DocumentInfo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectsToCreateFromInvoice.html#Alvao_API_AM_Model_ObjectsToCreateFromInvoice_Items"/>
    public List<InvoiceItemToCreate> Items { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectsToCreateFromInvoice.html#Alvao_API_AM_Model_ObjectsToCreateFromInvoice_LoadDocument"/>
    public bool LoadDocument { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectsToCreateFromInvoice.html#Alvao_API_AM_Model_ObjectsToCreateFromInvoice_ParentId"/>
    public int? ParentId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectsToCreateFromInvoice.html#Alvao_API_AM_Model_ObjectsToCreateFromInvoice_StoreDirectoryId"/>
    public Guid StoreDirectoryId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectsToCreateFromInvoice.html#Alvao_API_AM_Model_ObjectsToCreateFromInvoice_TicketId"/>
    public int TicketId { get; set; }
}
