namespace Alvao.API.AM.Model.SwLibrary;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProductPack.html"/>
public class SwLibProductPack : SwLibBase {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProductPack.html#Alvao_API_AM_Model_SwLibrary_SwLibProductPack_ProductPackUid"/>
    public int ProductPackUid { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProductPack.html#Alvao_API_AM_Model_SwLibrary_SwLibProductPack_ProductUid"/>
    public int ProductUid { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProductPack.html#Alvao_API_AM_Model_SwLibrary_SwLibProductPack__ctor"/>
    public SwLibProductPack() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.SwLibrary.SwLibProductPack.html#Alvao_API_AM_Model_SwLibrary_SwLibProductPack__ctor_Alvao_API_Utils_ArchiveStream_"/>
    public SwLibProductPack(ArchiveStream ar) { }
}
