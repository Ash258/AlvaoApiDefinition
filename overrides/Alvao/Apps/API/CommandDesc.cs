using System.Diagnostics.CodeAnalysis;

namespace Alvao.Apps.API;

/// <summary>!!!CAUTION: This class is not documented. It was generated as empty, to make the project compilable<br/><br/></summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.CommandDesc.html"/>
[SuppressMessage("Design", "CA1051:Do not declare visible instance fields", Justification = "Už se používá v customizacích, nemůžeme změnit.")]
public class CommandDesc {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.CommandDesc.html#Alvao_API_Common_Model_CustomApps_CommandDesc_icon"/>
    public string icon;
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.CommandDesc.html#Alvao_API_Common_Model_CustomApps_CommandDesc_id"/>
    public int id;
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.CommandDesc.html#Alvao_API_Common_Model_CustomApps_CommandDesc_name"/>
    public string name;
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.CommandDesc.html#Alvao_API_Common_Model_CustomApps_CommandDesc_position"/>
    public int position;

    public CommandDesc(int id, string name, int position, string icon) { }
}
