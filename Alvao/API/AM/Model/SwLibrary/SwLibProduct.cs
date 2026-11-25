using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Alvao.API.Utils;

namespace Alvao.API.AM.Model.SwLibrary;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html"/>
[DataContract]
public class SwLibProduct : SwLibBase {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.ProductState.html#fields"/>
    public enum ProductState {
        Unclassified = 1,
        Approving = 2,
        Approved = 3,
        ApprovedScheduledForDecommissioning = 4,
        Discontinued = 5,
        Rejected = 6,
    }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.SamType.html#fields"/>
    public enum SamType {
        AuditYes = 1,
        AuditNo = 2,
    }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_CategoryId"/>
    [DataMember(Name = "categoryId")]
    public int? CategoryId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_Description"/>
    [DataMember(Name = "description")]
    public string Description { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_Edition"/>
    [DataMember(Name = "edition")]
    public string Edition { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_IsAudited"/>
    [IgnoreDataMember]
    public bool IsAudited { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_LangId"/>
    [DataMember(Name = "langId")]
    public int? LangId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_Name"/>
    [DataMember(Name = "name")]
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_Platform"/>
    [DataMember(Name = "platform")]
    public string Platform { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_ProducerCompanyUid"/>
    [DataMember(Name = "producerCompanyUid")]
    public int? ProducerCompanyUid { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_ProductCpe"/>
    [DataMember(Name = "cpe")]
    [JsonPropertyName("cpe")]
    public string ProductCpe { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_SamTypeId"/>
    public SwLibProduct.SamType SamTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_StateId"/>
    public SwLibProduct.ProductState StateId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_TypeId"/>
    [DataMember(Name = "typeId")]
    public int? TypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_Version"/>
    [DataMember(Name = "version")]
    public string Version { get; set; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct__ctor"/>
    public SwLibProduct() { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct__ctor_Alvao_API_Utils_ArchiveStream_"/>
    public SwLibProduct(ArchiveStream ar) { }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProduct.html#Alvao_API_AM_Model_SwLibrary_SwLibProduct_WriteToArchive_Alvao_API_Utils_ArchiveStream_"/>
    public override void WriteToArchive(ArchiveStream archiveStream) { throw new NotImplementedException(); }
}
