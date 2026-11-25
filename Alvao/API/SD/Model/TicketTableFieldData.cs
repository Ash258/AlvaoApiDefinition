namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.TicketTableFieldData.html"/>
public class TicketTableFieldData {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.TicketTableFieldData.html#Alvao_API_SD_Model_TicketTableFieldData_DatabaseField"/>
    public string DatabaseField;
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.TicketTableFieldData.html#Alvao_API_SD_Model_TicketTableFieldData_Field"/>
    public TicketField Field;
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.TicketTableFieldData.html#Alvao_API_SD_Model_TicketTableFieldData_Label"/>
    public string Label;

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.SD.Model.TicketTableFieldData.html#Alvao_API_SD_Model_TicketTableFieldData__ctor_Alvao_API_SD_Model_TicketField_System_String_System_String_"/>
    public TicketTableFieldData(TicketField field, string databaseField, string label) { }
}
