using System.Diagnostics.CodeAnalysis;

namespace Alvao.API.Common.Model.CustomApps;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.CustomViewDesc.html"/>
[SuppressMessage("Design", "CA1051:Do not declare visible instance fields", Justification = "UÅ¾ se pouÅ¾&#237;v&#225; v customizac&#237;ch, nemÅ¯Å¾eme zmÄnit.")]
public class CustomViewDesc {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.CustomViewDesc.html#Alvao_API_Common_Model_CustomApps_CustomViewDesc_Id"/>
    public int Id;
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.CustomViewDesc.html#Alvao_API_Common_Model_CustomApps_CustomViewDesc_Name"/>
    public string Name;
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.CustomViewDesc.html#Alvao_API_Common_Model_CustomApps_CustomViewDesc_Url"/>
    public string Url;
}
