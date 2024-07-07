namespace Alvao.API.Common;

/// <summary>
/// Facade class grouping profile value methods.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_ProfileValue.htm"/>
public static class ProfileValue
{

    /// <summary>Delete ProfileValue rows.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_ProfileValue_Delete.htm"/>
    /// <param name="valueName">Value name of ProfileValue</param>
    /// <param name="stringValue">String value of ProfileValue</param>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="intValue">Int value of ProfileValue</param>
    /// <param name="backup">Sets Backup value of ProfileValue, default is false</param>
    public static void Delete(
        string valueName,
        string stringValue = null,
        int? personId = null,
        int? intValue = null,
        bool backup = false
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Returns table display mode.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_ProfileValue_GetTableDisplayMode.htm"/>
    /// <param name="personId">Person ID((tPerson.iPersonId)</param>
    /// <param name="valueName">Name of table and device identificator</param>
    public static bool? GetTableDisplayMode(
        int personId,
        string valueName
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Insert or upgrade of ProfileValue row.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_ProfileValue_InsertOrUpdate.htm"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="valueName">Value name of ProfileValue</param>
    /// <param name="stringValue">String value of ProfileValue</param>
    /// <param name="intValue">Int value of ProfileValue</param>
    /// <param name="backup">Sets Backup value of ProfileValue, default is false</param>
    public static void InsertOrUpdate(
        int personId,
        string valueName,
        string stringValue,
        int? intValue,
        bool backup = false
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Sets table display mode.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_ProfileValue_SetTableDisplayMode.htm"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="valueName">Name of table and device identificator</param>
    /// <param name="value">True for compact mode, false for table mode</param>
    public static void SetTableDisplayMode(
        int personId,
        string valueName,
        bool value
    )
    { throw new System.NotImplementedException(); }
}
