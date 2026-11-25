using System.Runtime.Serialization;
using Alvao.API.Utils;

namespace Alvao.API.AM.Model.SwLibrary;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProductPack.html"/>
[DataContract]
public class SwLibProductPack : SwLibBase {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProductPack.html#Alvao_API_AM_Model_SwLibrary_SwLibProductPack_ProductPackUid"/>
    [DataMember(Name = "productPackUid")]
    public int ProductPackUid { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProductPack.html#Alvao_API_AM_Model_SwLibrary_SwLibProductPack_ProductUid"/>
    [DataMember(Name = "productUid")]
    public int ProductUid { get; set; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProductPack.html#Alvao_API_AM_Model_SwLibrary_SwLibProductPack__ctor"/>
    public SwLibProductPack() { }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProductPack.html#Alvao_API_AM_Model_SwLibrary_SwLibProductPack__ctor_Alvao_API_Utils_ArchiveStream_"/>
    public SwLibProductPack(ArchiveStream ar) { }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProductPack.html#Alvao_API_AM_Model_SwLibrary_SwLibProductPack_WriteToArchive_Alvao_API_Utils_ArchiveStream_"/>
    public override void WriteToArchive(ArchiveStream archiveStream) { throw new NotImplementedException(); }
}
