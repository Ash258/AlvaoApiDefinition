using Alvao.API.Common.Model.Database;

namespace Alvao.API.AM;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Installation.html"/>
public static class Installation {
    /// <summary>Returns record of a special/trial installation.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Installation.html#Alvao_API_AM_Installation_GetSpecial_System_Int32_System_Int32_"/>
    /// <param name="productId">Product ID (tblProduct.intProductId) which is a special installation</param>
    /// <param name="objectId">Object (device) ID (tblNode.intNodeId) which has a special installation</param>
    /// <exception cref="UnauthorizedAccessException">Throws when user does not have rights to read licenses.</exception>
    /// <returns>Record of a special installation. If the installation is not special, returns null.</returns>
    public static tblInstTrial GetSpecial(int productId, int objectId) { throw new System.NotImplementedException(); }
    /// <summary>Record a manual installation on a computer</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Installation.html#Alvao_API_AM_Installation_Install_System_Int32_System_Int32_System_String_"/>
    /// <param name="productId">Product ID (tblProduct.intProductId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="note">Installation text note</param>
    /// <exception cref="UnauthorizedAccessException">Throws when user does not have rights to manage licenses.</exception>
    public static void Install(int productId, int objectId, string note) { throw new System.NotImplementedException(); }
    /// <summary>Mark product as a special/trial installation.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Installation.html#Alvao_API_AM_Installation_MarkAsSpecial_System_Int32_System_Int32_System_String_System_Nullable_System_DateTime__"/>
    /// <param name="productId">Product ID (tblProduct.intProductId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="note">Special installation text note</param>
    /// <param name="validUntil">Date and time until is special installation valid</param>
    /// <exception cref="UnauthorizedAccessException">Throws when user does not have rights to manage licenses.</exception>
    public static void MarkAsSpecial(int productId, int objectId, string note, DateTime? validUntil) { throw new System.NotImplementedException(); }
    /// <summary>Remove special/trial installation of a product.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Installation.html#Alvao_API_AM_Installation_RemoveSpecial_System_Int32_System_Int32_"/>
    /// <param name="productId">Product ID (tblProduct.intProductId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <exception cref="UnauthorizedAccessException">Throws when user does not have rights to manage licenses.</exception>
    public static void RemoveSpecial(int productId, int objectId) { throw new System.NotImplementedException(); }
    /// <summary>Record a manual uninstallation on a computer.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Installation.html#Alvao_API_AM_Installation_Uninstall_System_Collections_Generic_IEnumerable_System_Int32__"/>
    /// <param name="installationIds">List of installation IDs (tblInstHist.intInstHistId)</param>
    /// <exception cref="UnauthorizedAccessException">Throws when user does not have rights to manage licenses.</exception>
    public static void Uninstall(IEnumerable<int> installationIds) { throw new System.NotImplementedException(); }
}
