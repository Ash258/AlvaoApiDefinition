namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.TicketMessageTag.html"/>
public class TicketMessageTag {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.TicketMessageTag.html#Alvao_API_SD_Model_TicketMessageTag_Prefix"/>
    public string Prefix { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.TicketMessageTag.html#Alvao_API_SD_Model_TicketMessageTag_Suffix"/>
    public string Suffix { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.TicketMessageTag.html#Alvao_API_SD_Model_TicketMessageTag__ctor"/>
    public TicketMessageTag() { }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.TicketMessageTag.html#Alvao_API_SD_Model_TicketMessageTag__ctor_System_String_System_String_"/>
    public TicketMessageTag(string prefix, string suffix) { }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.TicketMessageTag.html#Alvao_API_SD_Model_TicketMessageTag_GetIdFromText_System_String_"/>
    public int? GetIdFromText(string text) { throw new System.NotImplementedException(); }
}
