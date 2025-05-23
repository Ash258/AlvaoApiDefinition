namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Model_BasicTicketInfo.htm"/>
public class BasicTicketInfo {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_BasicTicketInfo_TicketId.htm"/>
    public int TicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_BasicTicketInfo_TicketName.htm"/>
    public string TicketName { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_BasicTicketInfo__ctor.htm"/>
    public BasicTicketInfo() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_BasicTicketInfo__ctor_1.htm"/>
    public BasicTicketInfo(
        string ticketName,
        int ticketId
    ) { }
}
