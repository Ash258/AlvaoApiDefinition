using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD;

/// <summary>Facade class grouping organization methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Organization.html"/>
public static class Organization {
    /// <summary>Creates new organization and returns it's ID (tAccount.iAccountId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Organization.html#Alvao_API_SD_Organization_Create_Alvao_API_Common_Model_Database_tAccount_"/>
    /// <param name="organization">Organization</param>
    public static int Create(tAccount organization) { throw new System.NotImplementedException(); }
    /// <summary>If exists returns organization with given id.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Organization.html#Alvao_API_SD_Organization_GetById_System_Int32_"/>
    /// <param name="id">Organization ID (tAccount.iAccountId).</param>
    public static tAccount GetById(int id) { throw new System.NotImplementedException(); }
    /// <summary>If exists returns organization with given name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Organization.html#Alvao_API_SD_Organization_GetByName_System_String_"/>
    /// <param name="name">Organization name (tAccount.sAccount). Case insensitive.</param>
    public static tAccount GetByName(string name) { throw new System.NotImplementedException(); }
}
