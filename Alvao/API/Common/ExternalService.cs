using Alvao.API.Common.Model;

namespace Alvao.API.Common;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.ExternalService.html"/>
public static class ExternalService {
    /// <summary>Gets value of today service usage.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.ExternalService.html#Alvao_API_Common_ExternalService_GetTodayValue_Alvao_API_Common_Model_ExternalServices_ExternalServiceType_System_String_"/>
    /// <param name="externalServiceId">Id of the service</param>
    /// <param name="metricName">Metric name</param>
    /// <returns>Today service usage value (tPerson.iPersonId)</returns>
    public static int GetTodayValue(ExternalServices.ExternalServiceType externalServiceId, string metricName) { throw new NotImplementedException(); }
    /// <summary>Updates value of today service usage.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.ExternalService.html#Alvao_API_Common_ExternalService_UpdateTodayValue_Alvao_API_Common_Model_ExternalServices_ExternalServiceType_System_String_System_String_System_String_System_Int32_"/>
    /// <param name="externalServiceId">Id of the service</param>
    /// <param name="metricName">Metric name</param>
    /// <param name="feature">User name</param>
    /// <param name="groupName">Group name</param>
    /// <param name="value">Value to add</param>
    public static void UpdateTodayValue(ExternalServices.ExternalServiceType externalServiceId, string metricName, string feature, string groupName, int value) { throw new NotImplementedException(); }
}
