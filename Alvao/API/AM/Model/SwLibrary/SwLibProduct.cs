namespace Alvao.API.AM.Model.SwLibrary;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html"/>
public class SwLibProduct : SwLibBase {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.ProductState.html#fields"/>
    public enum ProductState {
        Unclassified = 1,
        Approving = 2,
        Approved = 3,
        ApprovedScheduledForDecommissioning = 4,
        Discontinued = 5,
        Rejected = 6,
    }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.SamType.html#fields"/>
    public enum SamType {
        AuditYes = 1,
        AuditNo = 2,
    }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_CategoryId"/>
    public int? CategoryId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_Description"/>
    public string Description { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_Edition"/>
    public string Edition { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_IsAudited"/>
    public bool IsAudited { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_LangId"/>
    public int? LangId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_Name"/>
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_Platform"/>
    public string Platform { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_ProducerCompanyUid"/>
    public int? ProducerCompanyUid { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_SamTypeId"/>
    public SwLibProduct.SamType SamTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_StateId"/>
    public SwLibProduct.ProductState StateId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_TypeId"/>
    public int? TypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_Version"/>
    public string Version { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct__ctor"/>
    public SwLibProduct() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct__ctor_Alvao_API_Utils_ArchiveStream_"/>
    public SwLibProduct(ArchiveStream ar) { }
}
