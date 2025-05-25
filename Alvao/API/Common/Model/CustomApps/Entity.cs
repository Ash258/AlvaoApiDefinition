namespace Alvao.API.Common.Model.CustomApps;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.Entity.html"/>
[Flags]
public enum Entity {
    General = 1,
    None = 0,
    Object = 4,
    Request = 2,
}
