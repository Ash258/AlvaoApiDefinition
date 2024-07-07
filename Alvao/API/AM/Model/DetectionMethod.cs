namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Model_DetectionMethod.htm"/>
public static class DetectionMethod
{
    public enum Type
    {
        None = 0,
        Direct = 1,
        Tcpip = 2,
        SharedFolder = 3,
        Manual = 4,
        Auto = 5,
        Ssh = 6,
        Autonomous = 7,
        MSSccm = 8,
    }
}
