using System.Xml;

namespace Alvao.API.AM.Model.Detection;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionMessage.html"/>
public class DetectionMessage {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionMessage.MessageType.html#fields"/>
    public enum MessageType {
        Info = 0,
        Warning = 1,
        Error = 2,
    }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionMessage.html#Alvao_API_AM_Model_Detection_DetectionMessage_Code"/>
    public int Code { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionMessage.html#Alvao_API_AM_Model_Detection_DetectionMessage_Description"/>
    public string Description { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionMessage.html#Alvao_API_AM_Model_Detection_DetectionMessage_LogKind"/>
    public Log.Kind LogKind { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionMessage.html#Alvao_API_AM_Model_Detection_DetectionMessage_LogMessage"/>
    public string LogMessage { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionMessage.html#Alvao_API_AM_Model_Detection_DetectionMessage_Source"/>
    public string Source { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionMessage.html#Alvao_API_AM_Model_Detection_DetectionMessage_Type"/>
    public DetectionMessage.MessageType Type { get; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionMessage.html#Alvao_API_AM_Model_Detection_DetectionMessage__ctor_System_Xml_XmlNode_"/>
    public DetectionMessage(XmlNode msgNode) { }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionMessage.html#Alvao_API_AM_Model_Detection_DetectionMessage_MessageTypeToDetectStatus_Alvao_API_AM_Model_Detection_DetectionMessage_MessageType_"/>
    public static Detection.Status MessageTypeToDetectStatus(DetectionMessage.MessageType msgType) { throw new NotImplementedException(); }
}
