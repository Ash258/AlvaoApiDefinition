namespace Alvao.API.Common.Model.CustomApps;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.CommandResult.html"/>
public class CommandResult {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.CommandResult.html#Alvao_API_Common_Model_CustomApps_CommandResult_MessageText"/>
    public string MessageText { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.CommandResult.html#Alvao_API_Common_Model_CustomApps_CommandResult_MessageType"/>
    public MessageType MessageType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.CommandResult.html#Alvao_API_Common_Model_CustomApps_CommandResult_NavigateToUrl"/>
    public string NavigateToUrl { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.CommandResult.html#Alvao_API_Common_Model_CustomApps_CommandResult__ctor"/>
    public CommandResult() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.CommandResult.html#Alvao_API_Common_Model_CustomApps_CommandResult__ctor_Alvao_API_Common_Model_CustomApps_MessageType_System_String_System_String_"/>
    public CommandResult(MessageType messageType, string messageText, string navigateToUrl) { }

    /// <summary>Determines whether the specified object is equal to the current object.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.CommandResult.html#Alvao_API_Common_Model_CustomApps_CommandResult_Equals_System_Object_"/>
    /// <param name="obj">The object to compare with the current object.</param>
    /// <returns>true if the specified object  is equal to the current object; otherwise, false.</returns>
    public override bool Equals(object obj) { throw new System.NotImplementedException(); }
    /// <summary>Serves as the default hash function.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.CustomApps.CommandResult.html#Alvao_API_Common_Model_CustomApps_CommandResult_GetHashCode"/>
    /// <returns>A hash code for the current object.</returns>
    public override int GetHashCode() { throw new System.NotImplementedException(); }
}
