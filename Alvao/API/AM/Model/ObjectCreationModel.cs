namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectCreationModel.html"/>
public class ObjectCreationModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectCreationModel.html#Alvao_API_AM_Model_ObjectCreationModel_Count"/>
    public int Count { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectCreationModel.html#Alvao_API_AM_Model_ObjectCreationModel_ExcludeGeneratingPropertyKindIds"/>
    public List<int> ExcludeGeneratingPropertyKindIds { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectCreationModel.html#Alvao_API_AM_Model_ObjectCreationModel_InvoiceCreationModel"/>
    public ObjectsToCreateFromInvoice InvoiceCreationModel { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectCreationModel.html#Alvao_API_AM_Model_ObjectCreationModel_NewObjectType"/>
    public NewObjectType NewObjectType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectCreationModel.html#Alvao_API_AM_Model_ObjectCreationModel_ObjectId"/>
    public int ObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectCreationModel.html#Alvao_API_AM_Model_ObjectCreationModel_ParentObjectId"/>
    public int? ParentObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectCreationModel.html#Alvao_API_AM_Model_ObjectCreationModel_TicketId"/>
    public int? TicketId { get; set; }

    /// <summary>Returns a string that represents the current object.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ObjectCreationModel.html#Alvao_API_AM_Model_ObjectCreationModel_ToString"/>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString() { throw new NotImplementedException(); }
}
