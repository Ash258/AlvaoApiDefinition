namespace Alvao.API.Common;

/// <summary>Facade class grouping profile value methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.ProfileValue.html"/>
public static class ProfileValue {
    /// <summary>Delete ProfileValue rows.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.ProfileValue.html#Alvao_API_Common_ProfileValue_Delete_System_String_System_String_System_Nullable_System_Int32__System_Nullable_System_Int32__System_Boolean_"/>
    /// <param name="valueName">Value name of ProfileValue</param>
    /// <param name="stringValue">String value of ProfileValue</param>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="intValue">Int value of ProfileValue</param>
    /// <param name="backup">Sets Backup value of ProfileValue, default is false</param>
    /// <exception cref="ArgumentException">Throws when personId is less or equal to 0 or valueName is null or empty.</exception>
    public static void Delete(string valueName, string stringValue = null, int? personId = null, int? intValue = null, bool backup = false) { throw new NotImplementedException(); }
    /// <summary>Returns ProfileValue row.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.ProfileValue.html#Alvao_API_Common_ProfileValue_Get_System_Int32_System_String_System_Boolean_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="valueName">Value name of ProfileValue</param>
    /// <param name="backup">Sets Backup value of ProfileValue, default is false</param>
    /// <exception cref="ArgumentException">Throws when personId is less or equal to 0 or valueName is null or empty.</exception>
    /// <returns>Returns ProfileValue (ProfileValue) where personId and valueName match.</returns>
    public static Alvao.API.Common.Model.Database.ProfileValue Get(int personId, string valueName, bool backup = false) { throw new NotImplementedException(); }
    /// <summary>Returns table display mode.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.ProfileValue.html#Alvao_API_Common_ProfileValue_GetTableDisplayMode_System_Int32_System_String_"/>
    /// <param name="personId">Person ID((tPerson.iPersonId)</param>
    /// <param name="valueName">Name of table and device identificator</param>
    /// <exception cref="ArgumentException">Throws when personId is less or equal to 0 or valueName is null or empty.</exception>
    /// <returns>Returns true if grid should display in compact mode, returns false if grid shoud display in table mode, returns null for default settings.</returns>
    public static bool? GetTableDisplayMode(int personId, string valueName) { throw new NotImplementedException(); }
    /// <summary>Insert or upgrade of ProfileValue row.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.ProfileValue.html#Alvao_API_Common_ProfileValue_InsertOrUpdate_System_Int32_System_String_System_String_System_Nullable_System_Int32__System_Boolean_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="valueName">Value name of ProfileValue</param>
    /// <param name="stringValue">String value of ProfileValue</param>
    /// <param name="intValue">Int value of ProfileValue</param>
    /// <param name="backup">Sets Backup value of ProfileValue, default is false</param>
    /// <exception cref="ArgumentException">Throws when personId is less or equal to 0 or valueName is null or empty.</exception>
    public static void InsertOrUpdate(int personId, string valueName, string stringValue, int? intValue, bool backup = false) { throw new NotImplementedException(); }
    /// <summary>Sets table display mode.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.ProfileValue.html#Alvao_API_Common_ProfileValue_SetTableDisplayMode_System_Int32_System_String_System_Boolean_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="valueName">Name of table and device identificator</param>
    /// <param name="value">True for compact mode, false for table mode</param>
    /// <exception cref="ArgumentException">Throws when personId is less or equal to 0 or valueName is null or empty.</exception>
    public static void SetTableDisplayMode(int personId, string valueName, bool value) { throw new NotImplementedException(); }
}
