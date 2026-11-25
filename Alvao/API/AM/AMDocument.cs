using Alvao.API.AM.Model;
using Alvao.API.Common.Model;
using Alvao.API.Common.Model.Database;

namespace Alvao.API.AM;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.AMDocument.html"/>
public static class AMDocument {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.AMDocument.html#Alvao_API_AM_AMDocument_AddFilesToDocument_System_Int32_System_Collections_Generic_IEnumerable_Alvao_API_Common_Model_IAttachment__"/>
    public static void AddFilesToDocument(int id, IEnumerable<IAttachment> files) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.AMDocument.html#Alvao_API_AM_AMDocument_CreateOrUpdate_Alvao_API_AM_Model_AMDocumentsModel_"/>
    public static int CreateOrUpdate(AMDocumentsModel model) { throw new NotImplementedException(); }
    /// <summary>Retrieves the collection of document folders associated with the current user.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.AMDocument.html#Alvao_API_AM_AMDocument_GetDocumentFoldersForCurrentPerson"/>
    /// <remarks>
    /// This method invokes the underlying document service to fetch the document folders for the user currently
    /// authenticated in the system. Ensure that the current user context is properly set before calling this method.
    /// </remarks>
    /// <returns>
    /// An IEnumerable&lt;T&gt; of DocumentFolder objects representing the document folders available to the current
    /// user. The collection will be empty if no folders are associated with the user.
    /// </returns>
    public static IEnumerable<DocumentFolder> GetDocumentFoldersForCurrentPerson() { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.AMDocument.html#Alvao_API_AM_AMDocument_LinkLicenses_System_Int32_System_Collections_Generic_IEnumerable_System_Int32__"/>
    public static void LinkLicenses(int id, IEnumerable<int> licenseIds) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.AMDocument.html#Alvao_API_AM_AMDocument_LinkObjects_System_Int32_System_Collections_Generic_IEnumerable_System_Int32__"/>
    public static void LinkObjects(int id, IEnumerable<int> objectIds) { throw new NotImplementedException(); }
}
