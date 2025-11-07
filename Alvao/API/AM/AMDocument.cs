using Alvao.API.AM.Model;
using Alvao.API.Common.Model;

namespace Alvao.API.AM;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.AMDocument.html"/>
public static class AMDocument {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.AMDocument.html#Alvao_API_AM_AMDocument_AddFilesToDocument_System_Int32_System_Collections_Generic_IEnumerable_Alvao_API_Common_Model_IAttachment__"/>
    public static void AddFilesToDocument(int id, IEnumerable<IAttachment> files) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.AMDocument.html#Alvao_API_AM_AMDocument_CreateOrUpdate_Alvao_API_AM_Model_AMDocumentsModel_"/>
    public static int CreateOrUpdate(AMDocumentsModel model) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.AMDocument.html#Alvao_API_AM_AMDocument_LinkLicenses_System_Int32_System_Collections_Generic_IEnumerable_System_Int32__"/>
    public static void LinkLicenses(int id, IEnumerable<int> licenseIds) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.AMDocument.html#Alvao_API_AM_AMDocument_LinkObjects_System_Int32_System_Collections_Generic_IEnumerable_System_Int32__"/>
    public static void LinkObjects(int id, IEnumerable<int> objectIds) { throw new NotImplementedException(); }
}
