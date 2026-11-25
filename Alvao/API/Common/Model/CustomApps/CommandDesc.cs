using System.Diagnostics.CodeAnalysis;

namespace Alvao.API.Common.Model.CustomApps;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.CommandDesc.html"/>
[SuppressMessage("Design", "CA1051:Do not declare visible instance fields", Justification = "UÅ¾ se pouÅ¾&#237;v&#225; v customizac&#237;ch, nemÅ¯Å¾eme zmÄnit.")]
public class CommandDesc {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.CommandDesc.html#Alvao_API_Common_Model_CustomApps_CommandDesc_icon"/>
    public string icon;
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.CommandDesc.html#Alvao_API_Common_Model_CustomApps_CommandDesc_id"/>
    public int id;
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.CommandDesc.html#Alvao_API_Common_Model_CustomApps_CommandDesc_name"/>
    public string name;
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.CommandDesc.html#Alvao_API_Common_Model_CustomApps_CommandDesc_position"/>
    public int position;
}
