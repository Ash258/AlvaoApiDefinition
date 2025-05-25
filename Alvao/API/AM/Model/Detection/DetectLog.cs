using Alvao.API.Common.Model.Database;

namespace Alvao.API.AM.Model.Detection;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectLog.html"/>
public class DetectLog {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectLog.html#Alvao_API_AM_Model_Detection_DetectLog_Add_Alvao_API_AM_Repository_IDetectionRepository_Alvao_API_Common_Model_Database_tString_Id_Alvao_API_Common_Model_Database_tblDetect_System_Int32_System_String___"/>
    public static void Add(IDetectionRepository detectionRepository, tString.Id stringId, tblDetect detect, int personId, params string[] parameters) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectLog.html#Alvao_API_AM_Model_Detection_DetectLog_Add_Alvao_API_AM_Repository_IDetectionRepository_Alvao_API_Common_Model_Database_tString_Id_System_Int32_Alvao_API_AM_Model_Detection_Detection_Kind_System_Int32_System_String___"/>
    public static void Add(IDetectionRepository detectionRepository, tString.Id stringId, int nodeId, Detection.Kind detectionKind, int personId, params string[] parameters) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectLog.html#Alvao_API_AM_Model_Detection_DetectLog_Add_Alvao_API_AM_Repository_IDetectionRepository_Alvao_API_Common_Model_Database_tString_Id_System_Int32_System_Nullable_System_Int32__System_Int32_System_String___"/>
    public static void Add(IDetectionRepository detectionRepository, tString.Id stringId, int detectId, int? nodeId, int personId, params string[] parameters) { throw new NotImplementedException(); }
}
