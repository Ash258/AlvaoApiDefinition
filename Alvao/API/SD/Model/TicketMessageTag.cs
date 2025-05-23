namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Model_TicketMessageTag.htm"/>
public class TicketMessageTag
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_TicketMessageTag_Prefix.htm"/>
    public string Prefix { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_TicketMessageTag_Suffix.htm"/>
    public string Suffix { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_TicketMessageTag__ctor.htm"/>
    public TicketMessageTag() { }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_TicketMessageTag__ctor_1.htm"/>
    public TicketMessageTag(
        string prefix,
        string suffix
    )
    { }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_TicketMessageTag_GetIdFromText.htm"/>
    ///
    /// <param name="text"> </param>
    public int? GetIdFromText(
        string text
    )
    { throw new System.NotImplementedException(); }
}
