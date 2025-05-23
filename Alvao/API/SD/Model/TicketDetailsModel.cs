namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Model_TicketDetailsModel.htm"/>
public class TicketDetailsModel
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_TicketDetailsModel_dHdTicket.htm"/>
    public DateTime? dHdTicket { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_TicketDetailsModel_dHdTicketDeadline.htm"/>
    public DateTime? dHdTicketDeadline { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_TicketDetailsModel_Priority.htm"/>
    public string Priority { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_TicketDetailsModel_sHdSection.htm"/>
    public string sHdSection { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_TicketDetailsModel_sHdTicket.htm"/>
    public string sHdTicket { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_TicketDetailsModel_sHdTicketDeviceCode.htm"/>
    public string sHdTicketDeviceCode { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_TicketDetailsModel_sHdTicketMessageTag.htm"/>
    public string sHdTicketMessageTag { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_TicketDetailsModel_sHdTicketSla.htm"/>
    public string sHdTicketSla { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_TicketDetailsModel_sHdTicketSolverPerson.htm"/>
    public string sHdTicketSolverPerson { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_TicketDetailsModel_sHdTicketUser.htm"/>
    public string sHdTicketUser { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_TicketDetailsModel_sHdTicketUserEmail.htm"/>
    public string sHdTicketUserEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_TicketDetailsModel_sHdTicketUserMobile.htm"/>
    public string sHdTicketUserMobile { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_TicketDetailsModel_sHdTicketUserPhone.htm"/>
    public string sHdTicketUserPhone { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_TicketDetailsModel_sUserAccount.htm"/>
    public string sUserAccount { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_TicketDetailsModel__ctor.htm"/>
    public TicketDetailsModel() { }
}
