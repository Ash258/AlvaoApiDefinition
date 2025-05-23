using Alvao.API.Common.Model.Database;

namespace Alvao.API.AM;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Installation.htm"/>
public static class Installation {

    /// <summary>Returns record of a special/trial installation.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Installation_GetSpecial.htm"/>
    ///
    /// <param name="productId">Product ID (tblProduct.intProductId) which is a special installation</param>
    /// <param name="objectId">Object (device) ID (tblNode.intNodeId) which has a special installation</param>
    public static tblInstTrial GetSpecial(
        int productId,
        int objectId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Record a manual installation on a computer</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Installation_Install.htm"/>
    ///
    /// <param name="productId">Product ID (tblProduct.intProductId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="note">Installation text note</param>
    public static void Install(
        int productId,
        int objectId,
        string note
    ) { throw new System.NotImplementedException(); }

    /// <summary>Mark product as a special/trial installation.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Installation_MarkAsSpecial.htm"/>
    ///
    /// <param name="productId">Product ID (tblProduct.intProductId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="note">Special installation text note</param>
    /// <param name="validUntil">Date and time until is special installation valid</param>
    public static void MarkAsSpecial(
        int productId,
        int objectId,
        string note,
        DateTime? validUntil
    ) { throw new System.NotImplementedException(); }

    /// <summary>Remove special/trial installation of a product.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Installation_RemoveSpecial.htm"/>
    ///
    /// <param name="productId">Product ID (tblProduct.intProductId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    public static void RemoveSpecial(
        int productId,
        int objectId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Record a manual uninstallation on a computer.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Installation_Uninstall.htm"/>
    ///
    /// <param name="installationIds">List of installation IDs (tblInstHist.intInstHistId)</param>
    public static void Uninstall(
        IEnumerable<int> installationIds
    ) { throw new System.NotImplementedException(); }
}
