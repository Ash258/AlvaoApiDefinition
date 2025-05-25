using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model;

/// <summary>Ticket initial act settings</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.InitialActSettings.html"/>
public class InitialActSettings : ActCreateSettings {
    /// <summary>Initial act author. If null, ticket requester is set.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.InitialActSettings.html#Alvao_API_SD_Model_InitialActSettings_ActAuthor"/>
    public tPerson ActAuthor { get; set; }
    /// <summary>Act kind,tActKind.ActKind.Form is default.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.InitialActSettings.html#Alvao_API_SD_Model_InitialActSettings_ActKind"/>
    public tActKind.ActKind ActKind { get; set; }
    /// <summary>Initial act receiver, can be null.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.InitialActSettings.html#Alvao_API_SD_Model_InitialActSettings_ToPerson"/>
    public tPerson ToPerson { get; set; }
}
