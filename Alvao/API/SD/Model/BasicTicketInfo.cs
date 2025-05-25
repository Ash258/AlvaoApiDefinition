namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.BasicTicketInfo.html"/>
public class BasicTicketInfo {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.BasicTicketInfo.html#Alvao_API_SD_Model_BasicTicketInfo_TicketId"/>
    public int TicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.BasicTicketInfo.html#Alvao_API_SD_Model_BasicTicketInfo_TicketName"/>
    public string TicketName { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.BasicTicketInfo.html#Alvao_API_SD_Model_BasicTicketInfo__ctor"/>
    public BasicTicketInfo() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.BasicTicketInfo.html#Alvao_API_SD_Model_BasicTicketInfo__ctor_System_String_System_Int32_"/>
    public BasicTicketInfo(string ticketName, int ticketId) { }
}
